/**** ProjectName  :  Simple Webserver CSharp
  *** Author       :  Yu Jiang
  *** Date         :  4/21-2017               */
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Simple_WebServer
{
    class Server
    {
        public bool RUN_STATUS = false;  //Run status 服务器运行状态
        private int TIME_LIMIT = 8;  //Time limit for data transfers 数据传输时间限制
        private Encoding CONTENT_ENCODE = Encoding.UTF8;  //String encoding  字符串编码
        private Socket SERVER_SOCKET;
        private string ROOT_PATH;   //Default root path of server  //服务器根目录
        /// <summary>
        /// error page  
        /// 错误页面
        /// </summary>
        private Dictionary<int, string[]> CUSTOM_ERROR_MESSAGE = new Dictionary<int, string[]>()
        {
            //501 error page content  501错误页面内容
            {  501  ,
                new string[]{ "501 Not Implemented" ,
                    "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"></head>" +
                    "<body><h2>Simple WebServer</h2><div>501 - Method Not Implemented</div></body></html>"    } },     
            //404 error page content  404错误页面内容
            {  404  ,
                new string[]{ "404 Not Found"       ,
                    "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"></head>" +
                    "<body><h2>Simple WebServer</h2><div>404 - File Not Found</div></body></html>"            } },     
            //406 error page content  406错误页面
            {  406  ,
                new string[]{ "406 Not Acceptable"  ,
                    "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"></head>" +
                    "<body><h2>Simple WebServer</h2><div>406 - File Type Not Support</div></body></html>"     } },
        };


        /// <summary>
        /// Content types that are supported by server
        /// 服务器支持的内容类型
        /// See or add other types : http://www.w3school.com.cn/media/media_mimeref.asp
        /// 添加其他类型可以参照上方链接
        /// </summary>
        private Dictionary<string, string> MIME = new Dictionary<string, string>()
        {
            {   "htm"    ,     "text/html"                   },
            {   "html"   ,     "text/html"                   },
            {   "css"    ,     "text/css"                    },
            {   "png"    ,     "image/png"                   },
            {   "gif"    ,     "image/gif"                   },
            {   "jpg"    ,     "image/jpg"                   },
            {   "jpeg"   ,     "image/jpeg"                  },
            {   "xml"    ,     "text/xml"                    },
            {   "zip"    ,     "application/zip"             },
            {   "js"     ,     "application/x-javascript"    },
        };

        /// <summary>
        /// Start server
        /// 启动服务器
        /// </summary>
        public bool Start(IPAddress ipAddress, int port, int maxBacklog, string rootPath)
        {
            if (RUN_STATUS) return false;

            //Start server
            //开启服务器
            try
            {
                SERVER_SOCKET = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                SERVER_SOCKET.Bind(new IPEndPoint(ipAddress, port));
                SERVER_SOCKET.Listen(maxBacklog);
                SERVER_SOCKET.ReceiveTimeout = TIME_LIMIT;
                SERVER_SOCKET.SendTimeout = TIME_LIMIT;
                RUN_STATUS = true;
                ROOT_PATH = rootPath;
            }
            catch
            { return false; }

            //
            Thread requestListener = new Thread(() =>
            {
                while (RUN_STATUS)
                {
                    try
                    {
                        Socket clientSocket;
                        clientSocket = SERVER_SOCKET.Accept();
                        Thread requestHandler = new Thread(() =>
                        {
                            clientSocket.ReceiveTimeout = TIME_LIMIT;
                            clientSocket.SendTimeout = TIME_LIMIT;
                            try { HandleRequest(clientSocket); }
                            catch
                            {
                                clientSocket.Close();
                            }
                        });
                        requestHandler.Start();
                    }
                    catch { }
                }
            });
            requestListener.Start();

            return true;
        }

        /// <summary>
        /// Stop server
        /// 关闭服务器
        /// </summary>
        public void Stop()
        {
            if (RUN_STATUS)
            {
                RUN_STATUS = false;
                SERVER_SOCKET.Close();
                SERVER_SOCKET = null;
            }
        }

        /// <summary>
        /// Parse request
        /// 解析请求
        /// </summary>
        private void HandleRequest(Socket clientSocket)
        {
            //Receive the request,convert to string 
            //接受请求并转换为字符串
            byte[] buffer = new byte[10240];
            int receiveByteCount = clientSocket.Receive(buffer);
            string strReceive = CONTENT_ENCODE.GetString(buffer, 0, receiveByteCount);

            //Parse the method of the request
            //解析除请求方式
            string httpMethod = strReceive.Substring(0, strReceive.IndexOf(" "));

            //Parse the url of the request
            //解析除请求的路径
            int start = strReceive.IndexOf(httpMethod) + httpMethod.Length + 1;
            int length = strReceive.LastIndexOf("HTTP") - start - 1;
            string requestedUrl = strReceive.Substring(start, length);

            //Determine whether the request mode support,parse the file of the url
            //判断请求方式是否支持,解析出请求的文件
            string requestedFile = string.Empty;
            if (httpMethod.Equals("GET") || httpMethod.Equals("POST"))
                requestedFile = requestedUrl.Split('?')[0];
            else
            {
                SendErrorResponse(clientSocket, 501);
                return;
            }

            //parse the file type of the url
            //解析请求的文件类型
            requestedFile = requestedFile.Replace("/", "\\").Replace("\\..", "");
            start = requestedFile.LastIndexOf('.') + 1;
            if (start > 0)
            {
                length = requestedFile.Length - start;
                string fileType = requestedFile.Substring(start, length);
                //Determine whether the file type support, if support, send requested file
                //判断文件类型是否支持,支持则发送文件
                if (MIME.ContainsKey(fileType))
                {
                    if (File.Exists(ROOT_PATH + requestedFile))
                        SendFileResponse(clientSocket, File.ReadAllBytes(ROOT_PATH + requestedFile), MIME[fileType]);
                    else
                        SendErrorResponse(clientSocket, 404);
                }
                else
                    SendErrorResponse(clientSocket, 406);
            }
            else
            {
                if (requestedFile.Substring(length - 1, 1) != "\\")
                    requestedFile += "\\";
                if (File.Exists(ROOT_PATH + requestedFile + "index.html"))
                    SendFileResponse(clientSocket, File.ReadAllBytes(ROOT_PATH + requestedFile + "\\index.html"), MIME["html"]);
                else if (File.Exists(ROOT_PATH + requestedFile + "index.htm"))
                    SendFileResponse(clientSocket, File.ReadAllBytes(ROOT_PATH + requestedFile + "\\index.htm"), MIME["htm"]);
                else
                    SendErrorResponse(clientSocket, 404);
            }

        }

        /// <summary>
        /// An error occurred, send error information
        /// 发生错误,发送错误信息
        /// </summary>
        private void SendErrorResponse(Socket clientSocket, int errorCode)
        {
            SendResponse(clientSocket, CONTENT_ENCODE.GetBytes(CUSTOM_ERROR_MESSAGE[errorCode][1]),
                CUSTOM_ERROR_MESSAGE[errorCode][0], MIME["html"]);
        }

        /// <summary>
        /// Send requested file
        /// 成功连接,发送请求的文件
        /// </summary>
        private void SendFileResponse(Socket clientSocket, byte[] byteContent, string contentType)
        {
            SendResponse(clientSocket, byteContent, "200 OK", contentType);
        }

        /// <summary>
        /// Send response
        /// 响应具体实现
        /// </summary>
        private void SendResponse(Socket clientSocket, byte[] byteContent, string responseCode, string contentType)
        {
            byte[] byteHeader = CONTENT_ENCODE.GetBytes(
                "HTTP/1.1 " + responseCode + "\r\n" +
                "Server: Simple WebServer\r\n" +
                "Content-Length: " + byteContent.Length.ToString() + "\r\n" +
                "Connection: close\r\n" +
                "Content-Type: " + contentType + "\r\n\r\n"
                );
            clientSocket.Send(byteHeader);
            clientSocket.Send(byteContent);
            clientSocket.Close();
        }
    }
}