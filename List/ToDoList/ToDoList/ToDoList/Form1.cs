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
    public partial class ToDoListForm : Form
    {
        private List<string> toDoList;
        public ToDoListForm()
        {
            InitializeComponent();
            toDoList = new List<string>();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NewToDoItemForm newToDoItemForm = new NewToDoItemForm();
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (newToDoItemForm.ShowDialog(this) == DialogResult.OK)
            {
                toDoList.Add(newToDoItemForm.NewToDoItem.Trim());
            }
            newToDoItemForm.Dispose();
            RefreshList();
        }

        private void RefreshList()
        {
            RefreshListBox();
            RefreshGroup();
        }

        private void RefreshListBox()
        {
            toDoListBox.Items.Clear();

            for (int i = 0; i < toDoList.Count; i++)
            {
                toDoListBox.Items.Add(i+1+": "+toDoList[i]);
            }            
        }

        private void RefreshGroup()
        {
            toDoGroup.Controls.Clear();

            for (int i = 0; i < toDoList.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = toDoList[i];
                checkBox.Location = new Point(2, 30 * i + 10);
                toDoGroup.Controls.Add(checkBox);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(toDoListBox.SelectedItem==null)
            {
                return;
            }
            string selectedItem = toDoListBox.SelectedItem.ToString();
            string selectedItemToDoItemString = selectedItem.Split(' ')[1];
            int indexOfSelectedItem = toDoList.IndexOf(selectedItemToDoItemString);

            if (indexOfSelectedItem != -1)
            {
               DialogResult dialogResult = MessageBox.Show("Delete This To Do Item?\n" + toDoList[indexOfSelectedItem], "Delete To Do Item", MessageBoxButtons.OKCancel);
                if(dialogResult == DialogResult.OK)
                {
                    toDoList.RemoveAt(indexOfSelectedItem);
                }
                RefreshList();
            }
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (toDoListBox.SelectedItem == null)
            {
                return;
            }
        }
    }
}
