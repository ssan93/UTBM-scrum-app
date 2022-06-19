namespace pr74_scrum_app.View
{   using System.Windows.Forms;
    using pr74_scrum_app.Controller;
    using pr74_scrum_app.Model;
    using System.Collections.Generic;
    partial class SprintForm
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
            this.inProgressListBox = new System.Windows.Forms.ListBox();
            this.inReviewListBox = new System.Windows.Forms.ListBox();
            this.doneListBox = new System.Windows.Forms.ListBox();
            this.testPanel = new System.Windows.Forms.Panel();
            this.button1 = new Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.todoListBox = new System.Windows.Forms.Panel();
            this.testPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inProgressListBox
            // 
            this.inProgressListBox.AllowDrop = true;
            this.inProgressListBox.FormattingEnabled = true;
            this.inProgressListBox.ItemHeight = 16;
            this.inProgressListBox.Location = new System.Drawing.Point(530, 188);
            this.inProgressListBox.Name = "inProgressListBox";
            this.inProgressListBox.Size = new System.Drawing.Size(248, 500);
            this.inProgressListBox.TabIndex = 13;
            this.inProgressListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.inProgressListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.inProgressListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // inReviewListBox
            // 
            this.inReviewListBox.AllowDrop = true;
            this.inReviewListBox.FormattingEnabled = true;
            this.inReviewListBox.ItemHeight = 16;
            this.inReviewListBox.Location = new System.Drawing.Point(804, 188);
            this.inReviewListBox.Name = "inReviewListBox";
            this.inReviewListBox.Size = new System.Drawing.Size(248, 500);
            this.inReviewListBox.TabIndex = 14;
            this.inReviewListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.inReviewListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.inReviewListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // doneListBox
            // 
            this.doneListBox.AllowDrop = true;
            this.doneListBox.FormattingEnabled = true;
            this.doneListBox.ItemHeight = 16;
            this.doneListBox.Location = new System.Drawing.Point(1076, 188);
            this.doneListBox.Name = "doneListBox";
            this.doneListBox.Size = new System.Drawing.Size(248, 500);
            this.doneListBox.TabIndex = 15;
            this.doneListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.doneListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.doneListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.button1);
            this.testPanel.Controls.Add(this.button2);
            this.testPanel.Controls.Add(this.button3);
            this.testPanel.Location = new System.Drawing.Point(46, 188);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(200, 500);
            this.testPanel.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "WEEEESH 1 ! ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "WEEEESH 2 ! ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "WEEEESH 3 ! ";
            // 
            // todoListBox
            // 
            this.todoListBox.AllowDrop = true;
            this.todoListBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.todoListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todoListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.todoListBox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.todoListBox.Location = new System.Drawing.Point(259, 188);
            this.todoListBox.Margin = new System.Windows.Forms.Padding(25);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(248, 498);
            this.todoListBox.TabIndex = 4;
            this.todoListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.todoListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.todoListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // SprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.todoListBox);
            this.Controls.Add(this.doneListBox);
            this.Controls.Add(this.inReviewListBox);
            this.Controls.Add(this.inProgressListBox);
            this.Name = "SprintForm";
            this.Text = "Sprint View";
            this.testPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ListBox inProgressListBox;
        private System.Windows.Forms.ListBox inReviewListBox;
        private System.Windows.Forms.ListBox doneListBox;
        private System.Windows.Forms.Panel testPanel;
        private Button button1;
        private Button button2;
        private Button button3;
        public Panel todoListBox;
    }
}