using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuesser
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        async void StartGuessCycle()
        {
            startButton.Enabled = false;
            
            int lowerBound = 1;
            int upperBound = 2001;
            int currentTry = 0;
            bool isGuessed = false;
            Random random = new Random();
            while(isGuessed == false)
            {
                currentTry++;
                await Task.Run(() =>
                {
                    
                    int number = random.Next(lowerBound, upperBound);
                    MessageBoxForGuessing messageBox = new MessageBoxForGuessing($"Вы загадали число {number}", "");
                    MessageBoxForGuessing.UserAnswer answer = (MessageBoxForGuessing.UserAnswer)messageBox.ShowDialog(); 

                    if(answer == MessageBoxForGuessing.UserAnswer.Lower)
                    {
                        upperBound = number;
                    }
                    else if(answer == MessageBoxForGuessing.UserAnswer.Upper)
                    {
                        lowerBound = number + 1;
                    }
                    else
                    {
                        isGuessed = true;
                    }
                });
            }
            MessageBox.Show($"На угадывание ушло {currentTry} попыток");
            startButton.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGuessCycle();
        }
    }
}
