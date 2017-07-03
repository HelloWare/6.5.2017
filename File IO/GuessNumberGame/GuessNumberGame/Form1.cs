using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGame
{
     
    public partial class Form1 : Form
    {
        int score =100;
        int answer;
        const int countLimit = 5;
        int count = 0;
        string output = "";
        private Form parentForm;
        string path = @"C:\Users\HelloWare Academy\Desktop\HelloWare\HelloWare Academy\6.5.2017\6.26\Sunday\gameResult.txt";
        public Form1(string name, Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            nameLbl.Text = name;
            StartANewGame();

            string[] text = File.ReadAllLines(path);
            foreach (var item in text)
            {
                if(item.Split(':')[0]==name)
                {
                    score = Convert.ToInt32(item.Split(':')[1].TrimStart());
                    MessageBox.Show("User Exists, score is: " + score);
                }
            }

        }

        private void UpdateUI()
        {
            CountLbl.Text = count.ToString();
            label2.Text = output;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            count++;
            if (count>=countLimit)
            {
                output = "You Lost!";
                UpdateUI();
                textBox1.Enabled = false;
                FlipTheCard();
                return;
            }

            string input = textBox1.Text;

            //check if it's int type
            int guessedNumber;
            bool isInt = Int32.TryParse(input, out guessedNumber);

            if (isInt)
            {
                if (guessedNumber > answer)
                {
                    output = "Answer is smaller";
                }
                else if (guessedNumber < answer)
                {
                    output = "Answer is larger";
                }
                else
                {
                    output = "You won!";
                    FlipTheCard();
                }
            }
            else
            {
                output = "You have to input int type!";
            }

            UpdateUI();
        }

        private void FlipTheCard()
        {
            button1.Text = answer.ToString() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartANewGame();
        }

        private void StartANewGame()
        {
            button1.Text = "";
            count = 0;
            textBox1.Enabled = true;
            output = "";

            Random rnd = new Random();
            answer = rnd.Next(0, 100);
            UpdateUI();
        }

        private void ShowMeSomething(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            MessageBox.Show(senderButton.Name+": Another event handler for Ok Button");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            //File.ReadAllText()
            //FileStream + StreamReader

            //File.WriteAllText(path, this.nameLbl.Text + ": " + score);
            FileStream fileStream = new FileStream(path, FileMode.Open);

            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine(this.nameLbl.Text + ": " + score);
            }

        }
    }
}
