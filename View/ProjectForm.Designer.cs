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
            this.MembersDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.porjectDescription = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.SprintsLabel = new System.Windows.Forms.Label();
            this.MembersLabel = new System.Windows.Forms.Label();
            this.BacklogLabel = new System.Windows.Forms.Label();
            this.searchBarComboBox = new System.Windows.Forms.ComboBox();
            this.addToMembersButton = new System.Windows.Forms.Button();
            this.SprintsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.archiveProjectButton = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.listPanel1 = new pr74_scrum_app.View.ListPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MembersDataGridView)).BeginInit();
            this.ProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SprintsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addToSprintsButton
            // 
            this.addToSprintsButton.Location = new System.Drawing.Point(288, 130);
            this.addToSprintsButton.Margin = new System.Windows.Forms.Padding(2);
            this.addToSprintsButton.Name = "addToSprintsButton";
            this.addToSprintsButton.Size = new System.Drawing.Size(58, 22);
            this.addToSprintsButton.TabIndex = 15;
            this.addToSprintsButton.Text = "+ Ajouter";
            this.addToSprintsButton.UseVisualStyleBackColor = true;
            this.addToSprintsButton.Click += new System.EventHandler(this.addToSprintsButton_Click);
            // 
            // addToBacklogButton
            // 
            this.addToBacklogButton.Location = new System.Drawing.Point(110, 130);
            this.addToBacklogButton.Margin = new System.Windows.Forms.Padding(2);
            this.addToBacklogButton.Name = "addToBacklogButton";
            this.addToBacklogButton.Size = new System.Drawing.Size(58, 22);
            this.addToBacklogButton.TabIndex = 12;
            this.addToBacklogButton.Text = "+ Ajouter";
            this.addToBacklogButton.UseVisualStyleBackColor = true;
            this.addToBacklogButton.Click += new System.EventHandler(this.addToBacklogButton_Click);
            // 
            // MembersDataGridView
            // 
            this.MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersDataGridView.Location = new System.Drawing.Point(370, 155);
            this.MembersDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.MembersDataGridView.Name = "MembersDataGridView";
            this.MembersDataGridView.RowHeadersWidth = 82;
            this.MembersDataGridView.RowTemplate.Height = 33;
            this.MembersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MembersDataGridView.Size = new System.Drawing.Size(150, 214);
            this.MembersDataGridView.TabIndex = 11;
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.Controls.Add(this.listPanel1);
            this.ProjectPanel.Controls.Add(this.descriptionLabel);
            this.ProjectPanel.Controls.Add(this.porjectDescription);
            this.ProjectPanel.Controls.Add(this.projectNameLabel);
            this.ProjectPanel.Controls.Add(this.SprintsLabel);
            this.ProjectPanel.Controls.Add(this.MembersLabel);
            this.ProjectPanel.Controls.Add(this.BacklogLabel);
            this.ProjectPanel.Controls.Add(this.searchBarComboBox);
            this.ProjectPanel.Controls.Add(this.addToMembersButton);
            this.ProjectPanel.Controls.Add(this.addToSprintsButton);
            this.ProjectPanel.Controls.Add(this.addToBacklogButton);
            this.ProjectPanel.Controls.Add(this.MembersDataGridView);
            this.ProjectPanel.Controls.Add(this.SprintsDataGridView);
            this.ProjectPanel.Controls.Add(this.searchTextBox);
            this.ProjectPanel.Controls.Add(this.archiveProjectButton);
            this.ProjectPanel.Location = new System.Drawing.Point(126, 48);
            this.ProjectPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(538, 349);
            this.ProjectPanel.TabIndex = 16;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(27, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionLabel.TabIndex = 26;
            this.descriptionLabel.Text = "Description :";
            // 
            // porjectDescription
            // 
            this.porjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.porjectDescription.Location = new System.Drawing.Point(23, 67);
            this.porjectDescription.Multiline = true;
            this.porjectDescription.Name = "porjectDescription";
            this.porjectDescription.ReadOnly = true;
            this.porjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.porjectDescription.Size = new System.Drawing.Size(509, 51);
            this.porjectDescription.TabIndex = 25;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(20, 14);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(73, 13);
            this.projectNameLabel.TabIndex = 24;
            this.projectNameLabel.Text = "Nom du projet";
            this.projectNameLabel.Click += new System.EventHandler(this.projectNameLabel_Click);
            // 
            // SprintsLabel
            // 
            this.SprintsLabel.AutoSize = true;
            this.SprintsLabel.Location = new System.Drawing.Point(198, 133);
            this.SprintsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SprintsLabel.Name = "SprintsLabel";
            this.SprintsLabel.Size = new System.Drawing.Size(39, 13);
            this.SprintsLabel.TabIndex = 23;
            this.SprintsLabel.Text = "Sprints";
            // 
            // MembersLabel
            // 
            this.MembersLabel.AutoSize = true;
            this.MembersLabel.Location = new System.Drawing.Point(372, 133);
            this.MembersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MembersLabel.Name = "MembersLabel";
            this.MembersLabel.Size = new System.Drawing.Size(50, 13);
            this.MembersLabel.TabIndex = 22;
            this.MembersLabel.Text = "Membres";
            // 
            // BacklogLabel
            // 
            this.BacklogLabel.AutoSize = true;
            this.BacklogLabel.Location = new System.Drawing.Point(20, 133);
            this.BacklogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BacklogLabel.Name = "BacklogLabel";
            this.BacklogLabel.Size = new System.Drawing.Size(46, 13);
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
            this.searchBarComboBox.Location = new System.Drawing.Point(350, 10);
            this.searchBarComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBarComboBox.Name = "searchBarComboBox";
            this.searchBarComboBox.Size = new System.Drawing.Size(62, 21);
            this.searchBarComboBox.TabIndex = 20;
            // 
            // addToMembersButton
            // 
            this.addToMembersButton.Location = new System.Drawing.Point(462, 130);
            this.addToMembersButton.Margin = new System.Windows.Forms.Padding(2);
            this.addToMembersButton.Name = "addToMembersButton";
            this.addToMembersButton.Size = new System.Drawing.Size(58, 22);
            this.addToMembersButton.TabIndex = 16;
            this.addToMembersButton.Text = "+ Ajouter";
            this.addToMembersButton.UseVisualStyleBackColor = true;
            this.addToMembersButton.Click += new System.EventHandler(this.addToMembersButton_Click);
            // 
            // SprintsDataGridView
            // 
            this.SprintsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SprintsDataGridView.Location = new System.Drawing.Point(196, 155);
            this.SprintsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SprintsDataGridView.Name = "SprintsDataGridView";
            this.SprintsDataGridView.RowHeadersWidth = 82;
            this.SprintsDataGridView.RowTemplate.Height = 33;
            this.SprintsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SprintsDataGridView.Size = new System.Drawing.Size(150, 214);
            this.SprintsDataGridView.TabIndex = 10;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(413, 10);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(119, 20);
            this.searchTextBox.TabIndex = 7;
            // 
            // archiveProjectButton
            // 
            this.archiveProjectButton.Location = new System.Drawing.Point(280, 9);
            this.archiveProjectButton.Margin = new System.Windows.Forms.Padding(2);
            this.archiveProjectButton.Name = "archiveProjectButton";
            this.archiveProjectButton.Size = new System.Drawing.Size(66, 24);
            this.archiveProjectButton.TabIndex = 8;
            this.archiveProjectButton.Text = "Archiver";
            this.archiveProjectButton.UseVisualStyleBackColor = true;
            this.archiveProjectButton.Click += new System.EventHandler(this.archiveProjectButton_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // listPanel1
            // 
            this.listPanel1.Location = new System.Drawing.Point(23, 157);
            this.listPanel1.Name = "listPanel1";
            this.listPanel1.Size = new System.Drawing.Size(145, 186);
            this.listPanel1.TabIndex = 27;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 403);
            this.Controls.Add(this.ProjectPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.MembersDataGridView)).EndInit();
            this.ProjectPanel.ResumeLayout(false);
            this.ProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SprintsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addToSprintsButton;
        private System.Windows.Forms.Button addToBacklogButton;
        private System.Windows.Forms.DataGridView MembersDataGridView;
        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.Button addToMembersButton;
        private System.Windows.Forms.DataGridView SprintsDataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button archiveProjectButton;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ComboBox searchBarComboBox;
        private System.Windows.Forms.Label SprintsLabel;
        private System.Windows.Forms.Label MembersLabel;
        private System.Windows.Forms.Label BacklogLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox porjectDescription;
        private System.Windows.Forms.Label descriptionLabel;
        private View.ListPanel listPanel1;
    }
}