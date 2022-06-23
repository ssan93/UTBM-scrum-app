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
            this.todoLabel = new System.Windows.Forms.Label();
            this.todoTitlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inProgressTitlePanel = new System.Windows.Forms.Panel();
            this.InProgressLabel = new System.Windows.Forms.Label();
            this.inReviewTitlePanel = new System.Windows.Forms.Panel();
            this.InReviewLabel = new System.Windows.Forms.Label();
            this.doneTitlePanel = new System.Windows.Forms.Panel();
            this.doneLabel = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.cancelSearchButton = new pr74_scrum_app.View.RoundButton();
            this.searchButton = new pr74_scrum_app.View.RoundButton();
            this.roundButton3 = new pr74_scrum_app.View.RoundButton();
            this.separator1 = new pr74_scrum_app.View.Components.Separator();
            this.doneBadge = new pr74_scrum_app.View.RoundButton();
            this.inReviewBadge = new pr74_scrum_app.View.RoundButton();
            this.inProgressBadge = new pr74_scrum_app.View.RoundButton();
            this.todoBadge = new pr74_scrum_app.View.RoundButton();
            this.todoList = new pr74_scrum_app.View.ListPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundButton1 = new pr74_scrum_app.View.RoundButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.doneList = new pr74_scrum_app.View.ListPanel();
            this.inReviewList = new pr74_scrum_app.View.ListPanel();
            this.inProgressList = new pr74_scrum_app.View.ListPanel();
            this.todoTitlePanel.SuspendLayout();
            this.inProgressTitlePanel.SuspendLayout();
            this.inReviewTitlePanel.SuspendLayout();
            this.doneTitlePanel.SuspendLayout();
            this.todoList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.todoLabel.Location = new System.Drawing.Point(45, 14);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(110, 29);
            this.todoLabel.TabIndex = 16;
            this.todoLabel.Text = "A FAIRE";
            // 
            // todoTitlePanel
            // 
            this.todoTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.todoTitlePanel.Controls.Add(this.todoBadge);
            this.todoTitlePanel.Controls.Add(this.label1);
            this.todoTitlePanel.Controls.Add(this.todoLabel);
            this.todoTitlePanel.Location = new System.Drawing.Point(262, 157);
            this.todoTitlePanel.Name = "todoTitlePanel";
            this.todoTitlePanel.Size = new System.Drawing.Size(250, 54);
            this.todoTitlePanel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 17;
            // 
            // inProgressTitlePanel
            // 
            this.inProgressTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.inProgressTitlePanel.Controls.Add(this.inProgressBadge);
            this.inProgressTitlePanel.Controls.Add(this.InProgressLabel);
            this.inProgressTitlePanel.Location = new System.Drawing.Point(533, 157);
            this.inProgressTitlePanel.Name = "inProgressTitlePanel";
            this.inProgressTitlePanel.Size = new System.Drawing.Size(250, 54);
            this.inProgressTitlePanel.TabIndex = 18;
            // 
            // InProgressLabel
            // 
            this.InProgressLabel.AutoSize = true;
            this.InProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InProgressLabel.Location = new System.Drawing.Point(22, 12);
            this.InProgressLabel.Name = "InProgressLabel";
            this.InProgressLabel.Size = new System.Drawing.Size(147, 29);
            this.InProgressLabel.TabIndex = 16;
            this.InProgressLabel.Text = "EN COURS";
            // 
            // inReviewTitlePanel
            // 
            this.inReviewTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.inReviewTitlePanel.Controls.Add(this.inReviewBadge);
            this.inReviewTitlePanel.Controls.Add(this.InReviewLabel);
            this.inReviewTitlePanel.Location = new System.Drawing.Point(807, 157);
            this.inReviewTitlePanel.Name = "inReviewTitlePanel";
            this.inReviewTitlePanel.Size = new System.Drawing.Size(250, 54);
            this.inReviewTitlePanel.TabIndex = 19;
            // 
            // InReviewLabel
            // 
            this.InReviewLabel.AutoSize = true;
            this.InReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.InReviewLabel.Location = new System.Drawing.Point(15, 12);
            this.InReviewLabel.Name = "InReviewLabel";
            this.InReviewLabel.Size = new System.Drawing.Size(177, 29);
            this.InReviewLabel.TabIndex = 16;
            this.InReviewLabel.Text = "EN REVISION";
            // 
            // doneTitlePanel
            // 
            this.doneTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.doneTitlePanel.Controls.Add(this.doneBadge);
            this.doneTitlePanel.Controls.Add(this.doneLabel);
            this.doneTitlePanel.Location = new System.Drawing.Point(1079, 157);
            this.doneTitlePanel.Name = "doneTitlePanel";
            this.doneTitlePanel.Size = new System.Drawing.Size(250, 54);
            this.doneTitlePanel.TabIndex = 19;
            // 
            // doneLabel
            // 
            this.doneLabel.AutoSize = true;
            this.doneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.doneLabel.Location = new System.Drawing.Point(20, 12);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(146, 29);
            this.doneLabel.TabIndex = 16;
            this.doneLabel.Text = "TERMINEE";
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Location = new System.Drawing.Point(1084, 87);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(214, 22);
            this.searchBar.TabIndex = 21;
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.BackColor = System.Drawing.Color.Red;
            this.cancelSearchButton.FlatAppearance.BorderSize = 0;
            this.cancelSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchButton.ForeColor = System.Drawing.Color.White;
            this.cancelSearchButton.Location = new System.Drawing.Point(936, 82);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(36, 33);
            this.cancelSearchButton.TabIndex = 24;
            this.cancelSearchButton.Text = "X";
            this.cancelSearchButton.UseVisualStyleBackColor = false;
            this.cancelSearchButton.Visible = false;
            this.cancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(987, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 33);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.roundButton3.Enabled = false;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(978, 71);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(336, 54);
            this.roundButton3.TabIndex = 23;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // separator1
            // 
            this.separator1.isVertical = false;
            this.separator1.Location = new System.Drawing.Point(262, 128);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(1067, 23);
            this.separator1.TabIndex = 20;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 1;
            // 
            // doneBadge
            // 
            this.doneBadge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.doneBadge.Enabled = false;
            this.doneBadge.FlatAppearance.BorderSize = 0;
            this.doneBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBadge.ForeColor = System.Drawing.Color.White;
            this.doneBadge.Location = new System.Drawing.Point(172, 10);
            this.doneBadge.Name = "doneBadge";
            this.doneBadge.Size = new System.Drawing.Size(41, 31);
            this.doneBadge.TabIndex = 20;
            this.doneBadge.Text = "10";
            this.doneBadge.UseVisualStyleBackColor = false;
            // 
            // inReviewBadge
            // 
            this.inReviewBadge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inReviewBadge.Enabled = false;
            this.inReviewBadge.FlatAppearance.BorderSize = 0;
            this.inReviewBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inReviewBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inReviewBadge.ForeColor = System.Drawing.Color.White;
            this.inReviewBadge.Location = new System.Drawing.Point(198, 10);
            this.inReviewBadge.Name = "inReviewBadge";
            this.inReviewBadge.Size = new System.Drawing.Size(41, 31);
            this.inReviewBadge.TabIndex = 19;
            this.inReviewBadge.Text = "10";
            this.inReviewBadge.UseVisualStyleBackColor = false;
            // 
            // inProgressBadge
            // 
            this.inProgressBadge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inProgressBadge.Enabled = false;
            this.inProgressBadge.FlatAppearance.BorderSize = 0;
            this.inProgressBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inProgressBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressBadge.ForeColor = System.Drawing.Color.White;
            this.inProgressBadge.Location = new System.Drawing.Point(175, 10);
            this.inProgressBadge.Name = "inProgressBadge";
            this.inProgressBadge.Size = new System.Drawing.Size(41, 31);
            this.inProgressBadge.TabIndex = 18;
            this.inProgressBadge.Text = "10";
            this.inProgressBadge.UseVisualStyleBackColor = false;
            // 
            // todoBadge
            // 
            this.todoBadge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.todoBadge.Enabled = false;
            this.todoBadge.FlatAppearance.BorderSize = 0;
            this.todoBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoBadge.ForeColor = System.Drawing.Color.White;
            this.todoBadge.Location = new System.Drawing.Point(164, 12);
            this.todoBadge.Name = "todoBadge";
            this.todoBadge.Size = new System.Drawing.Size(41, 31);
            this.todoBadge.TabIndex = 2;
            this.todoBadge.Text = "10";
            this.todoBadge.UseVisualStyleBackColor = false;
            // 
            // todoList
            // 
            this.todoList.AllowDrop = true;
            this.todoList.AutoScroll = true;
            this.todoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.todoList.Controls.Add(this.panel1);
            this.todoList.Cursor = System.Windows.Forms.Cursors.Default;
            this.todoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoList.Location = new System.Drawing.Point(262, 209);
            this.todoList.Margin = new System.Windows.Forms.Padding(25);
            this.todoList.Name = "todoList";
            this.todoList.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.todoList.Size = new System.Drawing.Size(250, 500);
            this.todoList.TabIndex = 4;
            this.todoList.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.todoList.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(7, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 76);
            this.panel1.TabIndex = 16;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.roundButton1.Enabled = false;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(3, 3);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(22, 21);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(31, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(182, 45);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "voila commennt ça marche le multiline ooo";
            // 
            // doneList
            // 
            this.doneList.AllowDrop = true;
            this.doneList.AutoScroll = true;
            this.doneList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.doneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneList.Location = new System.Drawing.Point(1079, 209);
            this.doneList.Name = "doneList";
            this.doneList.Size = new System.Drawing.Size(250, 500);
            this.doneList.TabIndex = 15;
            this.doneList.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.doneList.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // inReviewList
            // 
            this.inReviewList.AllowDrop = true;
            this.inReviewList.AutoScroll = true;
            this.inReviewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.inReviewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inReviewList.Location = new System.Drawing.Point(807, 209);
            this.inReviewList.Name = "inReviewList";
            this.inReviewList.Size = new System.Drawing.Size(250, 500);
            this.inReviewList.TabIndex = 14;
            this.inReviewList.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.inReviewList.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // inProgressList
            // 
            this.inProgressList.AllowDrop = true;
            this.inProgressList.AutoScroll = true;
            this.inProgressList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.inProgressList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressList.Location = new System.Drawing.Point(533, 209);
            this.inProgressList.Name = "inProgressList";
            this.inProgressList.Size = new System.Drawing.Size(250, 500);
            this.inProgressList.TabIndex = 13;
            this.inProgressList.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.inProgressList.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // SprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.cancelSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.doneTitlePanel);
            this.Controls.Add(this.inReviewTitlePanel);
            this.Controls.Add(this.inProgressTitlePanel);
            this.Controls.Add(this.todoTitlePanel);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.doneList);
            this.Controls.Add(this.inReviewList);
            this.Controls.Add(this.inProgressList);
            this.Name = "SprintForm";
            this.Text = "Sprint View";
            this.todoTitlePanel.ResumeLayout(false);
            this.todoTitlePanel.PerformLayout();
            this.inProgressTitlePanel.ResumeLayout(false);
            this.inProgressTitlePanel.PerformLayout();
            this.inReviewTitlePanel.ResumeLayout(false);
            this.inReviewTitlePanel.PerformLayout();
            this.doneTitlePanel.ResumeLayout(false);
            this.doneTitlePanel.PerformLayout();
            this.todoList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private ListPanel inProgressList;
        private ListPanel inReviewList;
        private ListPanel doneList;
        private ListPanel todoList;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private RoundButton roundButton1;
        private Label todoLabel;
        private Panel todoTitlePanel;
        private Label label1;
        private Panel inProgressTitlePanel;
        private Label InProgressLabel;
        private Panel inReviewTitlePanel;
        private Label InReviewLabel;
        private Panel doneTitlePanel;
        private Label doneLabel;
        private RoundButton todoBadge;
        private RoundButton inProgressBadge;
        private RoundButton inReviewBadge;
        private RoundButton doneBadge;
        private Components.Separator separator1;
        private TextBox searchBar;
        private RoundButton searchButton;
        private RoundButton roundButton3;
        private RoundButton cancelSearchButton;
    }
}