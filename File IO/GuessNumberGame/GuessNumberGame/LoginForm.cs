using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                Form1 gameForm =  new Form1(textBox1.Text, this);
                //gameForm.ShowDialog();
               DialogResult returnValue = gameForm.ShowDialog();
                switch (returnValue)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("You clicked Yes");
                        break;
                }
                //MessageBox.Show(returnValue.ToString());

            }
        }
    }
}
