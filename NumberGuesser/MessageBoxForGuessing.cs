using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumberGuesser
{
    public partial class MessageBoxForGuessing : Form
    {
        public enum UserAnswer
        {
            Lower = 1,
            Ok,
            Upper
        }
        public MessageBoxForGuessing(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void lowerButton_Click(object sender, EventArgs e)
        {
            DialogResult = (DialogResult)(int)UserAnswer.Lower;
            Close();
        }

        private void upperButton_Click(object sender, EventArgs e)
        {
            DialogResult = (DialogResult)(int)UserAnswer.Upper;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = (DialogResult)(int)UserAnswer.Ok;
            Close();
        }
    }
}
