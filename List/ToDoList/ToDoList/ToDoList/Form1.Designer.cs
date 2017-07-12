namespace ToDoList
{
    partial class ToDoListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toDoListBox = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.toDoGroup = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // toDoListBox
            // 
            this.toDoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoListBox.FormattingEnabled = true;
            this.toDoListBox.ItemHeight = 20;
            this.toDoListBox.Items.AddRange(new object[] {
            "Buy Milk",
            "Grocery"});
            this.toDoListBox.Location = new System.Drawing.Point(29, 70);
            this.toDoListBox.Name = "toDoListBox";
            this.toDoListBox.Size = new System.Drawing.Size(233, 184);
            this.toDoListBox.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Lime;
            this.AddBtn.Location = new System.Drawing.Point(302, 61);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(92, 83);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(302, 150);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(92, 83);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "-";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBtn.ForeColor = System.Drawing.Color.Yellow;
            this.CheckBtn.Location = new System.Drawing.Point(302, 239);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(92, 83);
            this.CheckBtn.TabIndex = 3;
            this.CheckBtn.Text = "√";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // toDoGroup
            // 
            this.toDoGroup.Location = new System.Drawing.Point(410, 61);
            this.toDoGroup.Name = "toDoGroup";
            this.toDoGroup.Size = new System.Drawing.Size(193, 193);
            this.toDoGroup.TabIndex = 4;
            this.toDoGroup.TabStop = false;
            this.toDoGroup.Text = "To Do List";
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 339);
            this.Controls.Add(this.toDoGroup);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.toDoListBox);
            this.Name = "ToDoListForm";
            this.Text = "To Do List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox toDoListBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.GroupBox toDoGroup;
    }
}

