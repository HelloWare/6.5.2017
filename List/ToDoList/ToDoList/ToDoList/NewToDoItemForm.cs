using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class NewToDoItemForm : Form
    {
        private string newToDoItem = "";
        public NewToDoItemForm()
        {
            InitializeComponent();
            // Make button1's dialog result OK.
            button2.DialogResult = DialogResult.OK;
            // Make button2's dialog result Cancel.
            button1.DialogResult = DialogResult.Cancel;
            this.AcceptButton = button2;
            this.CancelButton = button1;
        }

        public string NewToDoItem
        {
            get
            {
                return newToDoItem;
            }

            set
            {
                newToDoItem = value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(newToDoItemTextbox.Text!="")
            {
                this.newToDoItem = newToDoItemTextbox.Text.Trim();
            }
        }
    }
}
