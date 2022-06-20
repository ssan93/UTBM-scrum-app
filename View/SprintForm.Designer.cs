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
        private void initPanels()
        {
            this.todoList = new ListPanel();
            this.inProgressList = new ListPanel();
            this.inReviewList = new ListPanel();
            this.doneList = new ListPanel();
        }
        private void InitializeComponent()
        {
            this.todoList = new pr74_scrum_app.View.ListPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inProgressList = new pr74_scrum_app.View.ListPanel();
            this.inReviewList = new pr74_scrum_app.View.ListPanel();
            this.doneList = new pr74_scrum_app.View.ListPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.todoList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoList
            // 
            this.todoList.AllowDrop = true;
            this.todoList.AutoScroll = true;
            this.todoList.BackColor = System.Drawing.Color.White;
            this.todoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todoList.Controls.Add(this.panel1);
            this.todoList.Cursor = System.Windows.Forms.Cursors.Default;
            this.todoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoList.Location = new System.Drawing.Point(259, 188);
            this.todoList.Margin = new System.Windows.Forms.Padding(25);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(250, 500);
            this.todoList.TabIndex = 4;
            this.todoList.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.todoList.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 76);
            this.panel1.TabIndex = 16;
            // 
            // inProgressList
            // 
            this.inProgressList.AllowDrop = true;
            this.inProgressList.AutoScroll = true;
            this.inProgressList.BackColor = System.Drawing.Color.White;
            this.inProgressList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inProgressList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressList.Location = new System.Drawing.Point(530, 188);
            this.inProgressList.Name = "inProgressList";
            this.inProgressList.Size = new System.Drawing.Size(250, 500);
            this.inProgressList.TabIndex = 13;
            this.inProgressList.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.inProgressList.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // inReviewList
            // 
            this.inReviewList.AllowDrop = true;
            this.inReviewList.AutoScroll = true;
            this.inReviewList.BackColor = System.Drawing.Color.White;
            this.inReviewList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inReviewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inReviewList.Location = new System.Drawing.Point(804, 188);
            this.inReviewList.Name = "inReviewList";
            this.inReviewList.Size = new System.Drawing.Size(250, 500);
            this.inReviewList.TabIndex = 14;
            this.inReviewList.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.inReviewList.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // doneList
            // 
            this.doneList.AllowDrop = true;
            this.doneList.AutoScroll = true;
            this.doneList.BackColor = System.Drawing.Color.White;
            this.doneList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneList.Location = new System.Drawing.Point(1076, 188);
            this.doneList.Name = "doneList";
            this.doneList.Size = new System.Drawing.Size(250, 500);
            this.doneList.TabIndex = 15;
            this.doneList.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.doneList.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(71, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 22);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // SprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.doneList);
            this.Controls.Add(this.inReviewList);
            this.Controls.Add(this.inProgressList);
            this.Name = "SprintForm";
            this.Text = "Sprint View";
            this.todoList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private ListPanel inProgressList;
        private ListPanel inReviewList;
        private ListPanel doneList;
        private ListPanel todoList;
        private Panel panel1;
        private LinkLabel linkLabel1;
    }
}