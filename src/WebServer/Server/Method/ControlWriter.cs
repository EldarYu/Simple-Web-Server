using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Controls;
using System.Threading;

namespace Server.Method
{
     public class ControlWriter : TextWriter
    {
        private TextBox _textBox { set; get; }

        public ControlWriter(TextBox textBox)
        {
            this._textBox = textBox;
            Console.SetOut(this);
        }

        public override void Write(string value)
        {
            _textBox.Dispatcher.BeginInvoke(new ThreadStart(() => _textBox.AppendText(value + " ")));
        }

        public override void WriteLine(string value)
        {
            _textBox.Dispatcher.BeginInvoke(new ThreadStart(() => _textBox.AppendText(value + "\r\n")));
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
