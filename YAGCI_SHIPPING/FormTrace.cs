using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YAGCI_SHIPPING
{
    public partial class FormTrace : Form
    {
        public FormTrace()
        {
            InitializeComponent();
        }

        private void FormTrace_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.Listeners.Add(new TextTraceListener(this.richTextBox1));
        }
    }

    public class TextTraceListener : System.Diagnostics.TraceListener
    {
        RichTextBox _richTextBox;

        public TextTraceListener(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        delegate void SetLabelCallback(string str);
        public void SetThreadText(string str)
        {
            try
            {
                if (!object.ReferenceEquals(_richTextBox, null))
                {
                    if (_richTextBox.InvokeRequired)
                    {
                        SetLabelCallback d = new SetLabelCallback(SetThreadText);
                        _richTextBox.Invoke(d, new object[] { str });
                    }
                    else
                    {
                        if (_richTextBox.Lines.Count() > 600)
                            _richTextBox.Text = str;
                        else
                        {
                            _richTextBox.AppendText(str);
                            _richTextBox.ScrollToCaret();
                        }
                        Application.DoEvents();
                    }
                }
            }
            catch
            {
                ;
            }
        }

        public override void Write(string message)
        {
            SetThreadText(message);
        }

        public override void WriteLine(string message)
        {
            SetThreadText(message + "\r");
        }
    }
}
