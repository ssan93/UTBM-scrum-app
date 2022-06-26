namespace pr74_scrum_app
{
    partial class ProjectForm
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
            this.addToSprintsButton = new System.Windows.Forms.Button();
            this.addToBacklogButton = new System.Windows.Forms.Button();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.porjectDescription = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.sprintsList = new System.Windows.Forms.Label();
            this.MembersLabel = new System.Windows.Forms.Label();
            this.BacklogLabel = new System.Windows.Forms.Label();
            this.searchBarComboBox = new System.Windows.Forms.ComboBox();
            this.addToMembersButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.archiveProjectButton = new System.Windows.Forms.Button();
            this.separator1 = new pr74_scrum_app.View.Components.Separator();
            this.membersList = new pr74_scrum_app.View.ListPanel();
            this.membersNoneLabel = new System.Windows.Forms.Label();
            this.listPanel2 = new pr74_scrum_app.View.ListPanel();
            this.sprintsNoneLabel = new System.Windows.Forms.Label();
            this.BacklogList = new pr74_scrum_app.View.ListPanel();
            this.roundButton1 = new pr74_scrum_app.View.RoundButton();
            this.backlogNoneLabel = new System.Windows.Forms.Label();
            this.roundButton2 = new pr74_scrum_app.View.RoundButton();
            this.roundButton3 = new pr74_scrum_app.View.RoundButton();
            this.ProjectPanel.SuspendLayout();
            this.membersList.SuspendLayout();
            this.listPanel2.SuspendLayout();
            this.BacklogList.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToSprintsButton
            // 
            this.addToSprintsButton.Location = new System.Drawing.Point(557, 148);
            this.addToSprintsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToSprintsButton.Name = "addToSprintsButton";
            this.addToSprintsButton.Size = new System.Drawing.Size(77, 27);
            this.addToSprintsButton.TabIndex = 15;
            this.addToSprintsButton.Text = "+ Ajouter";
            this.addToSprintsButton.UseVisualStyleBackColor = true;
            this.addToSprintsButton.Click += new System.EventHandler(this.addToSprintsButton_Click);
            // 
            // addToBacklogButton
            // 
            this.addToBacklogButton.Location = new System.Drawing.Point(188, 146);
            this.addToBacklogButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToBacklogButton.Name = "addToBacklogButton";
            this.addToBacklogButton.Size = new System.Drawing.Size(77, 27);
            this.addToBacklogButton.TabIndex = 12;
            this.addToBacklogButton.Text = "+ Ajouter";
            this.addToBacklogButton.UseVisualStyleBackColor = true;
            this.addToBacklogButton.Click += new System.EventHandler(this.addToBacklogButton_Click);
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectPanel.Controls.Add(this.separator1);
            this.ProjectPanel.Controls.Add(this.membersList);
            this.ProjectPanel.Controls.Add(this.listPanel2);
            this.ProjectPanel.Controls.Add(this.BacklogList);
            this.ProjectPanel.Controls.Add(this.porjectDescription);
            this.ProjectPanel.Controls.Add(this.projectNameLabel);
            this.ProjectPanel.Controls.Add(this.sprintsList);
            this.ProjectPanel.Controls.Add(this.MembersLabel);
            this.ProjectPanel.Controls.Add(this.BacklogLabel);
            this.ProjectPanel.Controls.Add(this.searchBarComboBox);
            this.ProjectPanel.Controls.Add(this.addToMembersButton);
            this.ProjectPanel.Controls.Add(this.addToSprintsButton);
            this.ProjectPanel.Controls.Add(this.addToBacklogButton);
            this.ProjectPanel.Controls.Add(this.searchTextBox);
            this.ProjectPanel.Controls.Add(this.archiveProjectButton);
            this.ProjectPanel.Location = new System.Drawing.Point(299, 152);
            this.ProjectPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(1037, 558);
            this.ProjectPanel.TabIndex = 16;
            // 
            // porjectDescription
            // 
            this.porjectDescription.BackColor = System.Drawing.Color.White;
            this.porjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.porjectDescription.Location = new System.Drawing.Point(29, 58);
            this.porjectDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.porjectDescription.Multiline = true;
            this.porjectDescription.Name = "porjectDescription";
            this.porjectDescription.ReadOnly = true;
            this.porjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.porjectDescription.Size = new System.Drawing.Size(625, 60);
            this.porjectDescription.TabIndex = 25;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(24, 17);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(241, 29);
            this.projectNameLabel.TabIndex = 24;
            this.projectNameLabel.Text = "Nom du projet";
            this.projectNameLabel.Click += new System.EventHandler(this.projectNameLabel_Click);
            // 
            // sprintsList
            // 
            this.sprintsList.AutoSize = true;
            this.sprintsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintsList.Location = new System.Drawing.Point(399, 153);
            this.sprintsList.Name = "sprintsList";
            this.sprintsList.Size = new System.Drawing.Size(80, 25);
            this.sprintsList.TabIndex = 23;
            this.sprintsList.Text = "Sprints";
            // 
            // MembersLabel
            // 
            this.MembersLabel.AutoSize = true;
            this.MembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersLabel.Location = new System.Drawing.Point(768, 153);
            this.MembersLabel.Name = "MembersLabel";
            this.MembersLabel.Size = new System.Drawing.Size(101, 25);
            this.MembersLabel.TabIndex = 22;
            this.MembersLabel.Text = "Membres";
            // 
            // BacklogLabel
            // 
            this.BacklogLabel.AutoSize = true;
            this.BacklogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklogLabel.Location = new System.Drawing.Point(28, 151);
            this.BacklogLabel.Name = "BacklogLabel";
            this.BacklogLabel.Size = new System.Drawing.Size(89, 25);
            this.BacklogLabel.TabIndex = 21;
            this.BacklogLabel.Text = "Backlog";
            // 
            // searchBarComboBox
            // 
            this.searchBarComboBox.FormattingEnabled = true;
            this.searchBarComboBox.Items.AddRange(new object[] {
            "Backlog",
            "Sprints",
            "Membres"});
            this.searchBarComboBox.Location = new System.Drawing.Point(763, 24);
            this.searchBarComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBarComboBox.Name = "searchBarComboBox";
            this.searchBarComboBox.Size = new System.Drawing.Size(81, 24);
            this.searchBarComboBox.TabIndex = 20;
            // 
            // addToMembersButton
            // 
            this.addToMembersButton.Location = new System.Drawing.Point(927, 146);
            this.addToMembersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToMembersButton.Name = "addToMembersButton";
            this.addToMembersButton.Size = new System.Drawing.Size(77, 27);
            this.addToMembersButton.TabIndex = 16;
            this.addToMembersButton.Text = "+ Ajouter";
            this.addToMembersButton.UseVisualStyleBackColor = true;
            this.addToMembersButton.Click += new System.EventHandler(this.addToMembersButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(847, 24);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(157, 22);
            this.searchTextBox.TabIndex = 7;
            // 
            // archiveProjectButton
            // 
            this.archiveProjectButton.BackColor = System.Drawing.Color.Gray;
            this.archiveProjectButton.ForeColor = System.Drawing.Color.White;
            this.archiveProjectButton.Location = new System.Drawing.Point(271, 20);
            this.archiveProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.archiveProjectButton.Name = "archiveProjectButton";
            this.archiveProjectButton.Size = new System.Drawing.Size(88, 30);
            this.archiveProjectButton.TabIndex = 8;
            this.archiveProjectButton.Text = "Archiver";
            this.archiveProjectButton.UseVisualStyleBackColor = false;
            this.archiveProjectButton.Click += new System.EventHandler(this.archiveProjectButton_Click);
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.White;
            this.separator1.isVertical = false;
            this.separator1.Location = new System.Drawing.Point(27, 125);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(977, 23);
            this.separator1.TabIndex = 17;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 1;
            // 
            // membersList
            // 
            this.membersList.Controls.Add(this.roundButton3);
            this.membersList.Controls.Add(this.membersNoneLabel);
            this.membersList.Location = new System.Drawing.Point(766, 180);
            this.membersList.Margin = new System.Windows.Forms.Padding(4);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(238, 360);
            this.membersList.TabIndex = 28;
            // 
            // membersNoneLabel
            // 
            this.membersNoneLabel.AutoSize = true;
            this.membersNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersNoneLabel.Location = new System.Drawing.Point(49, 15);
            this.membersNoneLabel.Name = "membersNoneLabel";
            this.membersNoneLabel.Size = new System.Drawing.Size(130, 22);
            this.membersNoneLabel.TabIndex = 3;
            this.membersNoneLabel.Text = "Aucun membre";
            // 
            // listPanel2
            // 
            this.listPanel2.Controls.Add(this.roundButton2);
            this.listPanel2.Controls.Add(this.sprintsNoneLabel);
            this.listPanel2.Location = new System.Drawing.Point(396, 180);
            this.listPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.listPanel2.Name = "listPanel2";
            this.listPanel2.Size = new System.Drawing.Size(238, 360);
            this.listPanel2.TabIndex = 28;
            // 
            // sprintsNoneLabel
            // 
            this.sprintsNoneLabel.AutoSize = true;
            this.sprintsNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintsNoneLabel.Location = new System.Drawing.Point(65, 15);
            this.sprintsNoneLabel.Name = "sprintsNoneLabel";
            this.sprintsNoneLabel.Size = new System.Drawing.Size(110, 22);
            this.sprintsNoneLabel.TabIndex = 2;
            this.sprintsNoneLabel.Text = "Aucun sprint";
            // 
            // BacklogList
            // 
            this.BacklogList.Controls.Add(this.roundButton1);
            this.BacklogList.Controls.Add(this.backlogNoneLabel);
            this.BacklogList.Location = new System.Drawing.Point(27, 180);
            this.BacklogList.Margin = new System.Windows.Forms.Padding(4);
            this.BacklogList.Name = "BacklogList";
            this.BacklogList.Size = new System.Drawing.Size(238, 360);
            this.BacklogList.TabIndex = 27;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(6, 54);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(229, 40);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "exemple de user story";
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // backlogNoneLabel
            // 
            this.backlogNoneLabel.AutoSize = true;
            this.backlogNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogNoneLabel.Location = new System.Drawing.Point(39, 15);
            this.backlogNoneLabel.Name = "backlogNoneLabel";
            this.backlogNoneLabel.Size = new System.Drawing.Size(155, 22);
            this.backlogNoneLabel.TabIndex = 1;
            this.backlogNoneLabel.Text = "Aucune user story";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(6, 54);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(229, 40);
            this.roundButton2.TabIndex = 2;
            this.roundButton2.Text = "exemple de sprint";
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(6, 54);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(229, 40);
            this.roundButton3.TabIndex = 3;
            this.roundButton3.Text = "exemple membre";
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.ProjectPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectViewForm";
            this.ProjectPanel.ResumeLayout(false);
            this.ProjectPanel.PerformLayout();
            this.membersList.ResumeLayout(false);
            this.membersList.PerformLayout();
            this.listPanel2.ResumeLayout(false);
            this.listPanel2.PerformLayout();
            this.BacklogList.ResumeLayout(false);
            this.BacklogList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addToSprintsButton;
        private System.Windows.Forms.Button addToBacklogButton;
        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.Button addToMembersButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button archiveProjectButton;
        private System.Windows.Forms.ComboBox searchBarComboBox;
        private System.Windows.Forms.Label sprintsList;
        private System.Windows.Forms.Label MembersLabel;
        private System.Windows.Forms.Label BacklogLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox porjectDescription;
        private View.ListPanel BacklogList;
        private View.Components.Separator separator1;
        private View.ListPanel membersList;
        private View.ListPanel listPanel2;
        private System.Windows.Forms.Label membersNoneLabel;
        private System.Windows.Forms.Label sprintsNoneLabel;
        private View.RoundButton roundButton1;
        private System.Windows.Forms.Label backlogNoneLabel;
        private View.RoundButton roundButton3;
        private View.RoundButton roundButton2;
    }
}