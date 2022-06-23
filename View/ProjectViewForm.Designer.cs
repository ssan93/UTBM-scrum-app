namespace pr74_scrum_app
{
    partial class ProjectViewForm
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
            this.BacklogDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectPanel = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.MembersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogDataGridView)).BeginInit();
            this.ProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SprintsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addToSprintsButton
            // 
            this.addToSprintsButton.Location = new System.Drawing.Point(530, 93);
            this.addToSprintsButton.Name = "addToSprintsButton";
            this.addToSprintsButton.Size = new System.Drawing.Size(115, 31);
            this.addToSprintsButton.TabIndex = 15;
            this.addToSprintsButton.Text = "+ Ajouter";
            this.addToSprintsButton.UseVisualStyleBackColor = true;
            this.addToSprintsButton.Click += new System.EventHandler(this.addToSprintsButton_Click);
            // 
            // addToBacklogButton
            // 
            this.addToBacklogButton.Location = new System.Drawing.Point(198, 93);
            this.addToBacklogButton.Name = "addToBacklogButton";
            this.addToBacklogButton.Size = new System.Drawing.Size(115, 31);
            this.addToBacklogButton.TabIndex = 12;
            this.addToBacklogButton.Text = "+ Ajouter";
            this.addToBacklogButton.UseVisualStyleBackColor = true;
            this.addToBacklogButton.Click += new System.EventHandler(this.addToBacklogButton_Click);
            // 
            // MembersDataGridView
            // 
            this.MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersDataGridView.Location = new System.Drawing.Point(703, 156);
            this.MembersDataGridView.Name = "MembersDataGridView";
            this.MembersDataGridView.RowHeadersWidth = 82;
            this.MembersDataGridView.RowTemplate.Height = 33;
            this.MembersDataGridView.Size = new System.Drawing.Size(276, 412);
            this.MembersDataGridView.TabIndex = 11;
            // 
            // BacklogDataGridView
            // 
            this.BacklogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BacklogDataGridView.Location = new System.Drawing.Point(37, 156);
            this.BacklogDataGridView.Name = "BacklogDataGridView";
            this.BacklogDataGridView.RowHeadersWidth = 82;
            this.BacklogDataGridView.RowTemplate.Height = 33;
            this.BacklogDataGridView.Size = new System.Drawing.Size(276, 412);
            this.BacklogDataGridView.TabIndex = 9;
            // 
            // ProjectPanel
            // 
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
            this.ProjectPanel.Controls.Add(this.BacklogDataGridView);
            this.ProjectPanel.Controls.Add(this.searchTextBox);
            this.ProjectPanel.Controls.Add(this.archiveProjectButton);
            this.ProjectPanel.Location = new System.Drawing.Point(253, 92);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(1075, 593);
            this.ProjectPanel.TabIndex = 16;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(41, 26);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(146, 25);
            this.projectNameLabel.TabIndex = 24;
            this.projectNameLabel.Text = "Nom du projet";
            // 
            // SprintsLabel
            // 
            this.SprintsLabel.AutoSize = true;
            this.SprintsLabel.Location = new System.Drawing.Point(374, 99);
            this.SprintsLabel.Name = "SprintsLabel";
            this.SprintsLabel.Size = new System.Drawing.Size(79, 25);
            this.SprintsLabel.TabIndex = 23;
            this.SprintsLabel.Text = "Sprints";
            // 
            // MembersLabel
            // 
            this.MembersLabel.AutoSize = true;
            this.MembersLabel.Location = new System.Drawing.Point(708, 99);
            this.MembersLabel.Name = "MembersLabel";
            this.MembersLabel.Size = new System.Drawing.Size(101, 25);
            this.MembersLabel.TabIndex = 22;
            this.MembersLabel.Text = "Membres";
            // 
            // BacklogLabel
            // 
            this.BacklogLabel.AutoSize = true;
            this.BacklogLabel.Location = new System.Drawing.Point(41, 99);
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
            this.searchBarComboBox.Location = new System.Drawing.Point(699, 20);
            this.searchBarComboBox.Name = "searchBarComboBox";
            this.searchBarComboBox.Size = new System.Drawing.Size(121, 33);
            this.searchBarComboBox.TabIndex = 20;
            // 
            // addToMembersButton
            // 
            this.addToMembersButton.Location = new System.Drawing.Point(864, 93);
            this.addToMembersButton.Name = "addToMembersButton";
            this.addToMembersButton.Size = new System.Drawing.Size(115, 31);
            this.addToMembersButton.TabIndex = 16;
            this.addToMembersButton.Text = "+ Ajouter";
            this.addToMembersButton.UseVisualStyleBackColor = true;
            this.addToMembersButton.Click += new System.EventHandler(this.addToMembersButton_Click);
            // 
            // SprintsDataGridView
            // 
            this.SprintsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SprintsDataGridView.Location = new System.Drawing.Point(369, 156);
            this.SprintsDataGridView.Name = "SprintsDataGridView";
            this.SprintsDataGridView.RowHeadersWidth = 82;
            this.SprintsDataGridView.RowTemplate.Height = 33;
            this.SprintsDataGridView.Size = new System.Drawing.Size(276, 412);
            this.SprintsDataGridView.TabIndex = 10;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(826, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(234, 31);
            this.searchTextBox.TabIndex = 7;
            // 
            // archiveProjectButton
            // 
            this.archiveProjectButton.Location = new System.Drawing.Point(198, 17);
            this.archiveProjectButton.Name = "archiveProjectButton";
            this.archiveProjectButton.Size = new System.Drawing.Size(133, 37);
            this.archiveProjectButton.TabIndex = 8;
            this.archiveProjectButton.Text = "Archiver";
            this.archiveProjectButton.UseVisualStyleBackColor = true;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // ProjectViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.ProjectPanel);
            this.Name = "ProjectViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.MembersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogDataGridView)).EndInit();
            this.ProjectPanel.ResumeLayout(false);
            this.ProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SprintsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addToSprintsButton;
        private System.Windows.Forms.Button addToBacklogButton;
        private System.Windows.Forms.DataGridView MembersDataGridView;
        private System.Windows.Forms.DataGridView BacklogDataGridView;
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
    }
}