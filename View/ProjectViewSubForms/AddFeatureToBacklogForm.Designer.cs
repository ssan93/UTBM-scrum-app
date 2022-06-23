namespace pr74_scrum_app
{
    partial class AddFeatureToBacklogForm
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
            this.typeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.FeatureTypeLabel = new System.Windows.Forms.Label();
            this.FeatureTitleLabel = new System.Windows.Forms.Label();
            this.formTitle = new System.Windows.Forms.Label();
            this.backlogFeatureTitleTextBox = new System.Windows.Forms.TextBox();
            this.cancelForm = new System.Windows.Forms.Button();
            this.ConfirmForm = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.ComplexityLevelLabel = new System.Windows.Forms.Label();
            this.PriorityLevelLabel = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.complexityLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.featureDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.complexityLevelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // typeSelectionComboBox
            // 
            this.typeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelectionComboBox.FormattingEnabled = true;
            this.typeSelectionComboBox.Items.AddRange(new object[] {
            "Fix",
            "Feature",
            "Documentation"});
            this.typeSelectionComboBox.Location = new System.Drawing.Point(129, 276);
            this.typeSelectionComboBox.Name = "typeSelectionComboBox";
            this.typeSelectionComboBox.Size = new System.Drawing.Size(267, 33);
            this.typeSelectionComboBox.TabIndex = 20;
            // 
            // FeatureTypeLabel
            // 
            this.FeatureTypeLabel.AutoSize = true;
            this.FeatureTypeLabel.Location = new System.Drawing.Point(134, 242);
            this.FeatureTypeLabel.Name = "FeatureTypeLabel";
            this.FeatureTypeLabel.Size = new System.Drawing.Size(60, 25);
            this.FeatureTypeLabel.TabIndex = 19;
            this.FeatureTypeLabel.Text = "Type";
            // 
            // FeatureTitleLabel
            // 
            this.FeatureTitleLabel.AutoSize = true;
            this.FeatureTitleLabel.Location = new System.Drawing.Point(134, 131);
            this.FeatureTitleLabel.Name = "FeatureTitleLabel";
            this.FeatureTitleLabel.Size = new System.Drawing.Size(75, 25);
            this.FeatureTitleLabel.TabIndex = 18;
            this.FeatureTitleLabel.Text = "Intitulé";
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Location = new System.Drawing.Point(219, 48);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(230, 25);
            this.formTitle.TabIndex = 17;
            this.formTitle.Text = "Nouvelle fonctionnalité";
            // 
            // backlogFeatureTitleTextBox
            // 
            this.backlogFeatureTitleTextBox.Location = new System.Drawing.Point(129, 168);
            this.backlogFeatureTitleTextBox.Name = "backlogFeatureTitleTextBox";
            this.backlogFeatureTitleTextBox.Size = new System.Drawing.Size(380, 31);
            this.backlogFeatureTitleTextBox.TabIndex = 16;
            // 
            // cancelForm
            // 
            this.cancelForm.Location = new System.Drawing.Point(431, 774);
            this.cancelForm.Name = "cancelForm";
            this.cancelForm.Size = new System.Drawing.Size(117, 55);
            this.cancelForm.TabIndex = 15;
            this.cancelForm.Text = "Cancel";
            this.cancelForm.UseVisualStyleBackColor = true;
            this.cancelForm.Click += new System.EventHandler(this.cancelForm_Click);
            // 
            // ConfirmForm
            // 
            this.ConfirmForm.BackColor = System.Drawing.Color.SteelBlue;
            this.ConfirmForm.ForeColor = System.Drawing.Color.White;
            this.ConfirmForm.Location = new System.Drawing.Point(570, 774);
            this.ConfirmForm.Name = "ConfirmForm";
            this.ConfirmForm.Size = new System.Drawing.Size(117, 55);
            this.ConfirmForm.TabIndex = 14;
            this.ConfirmForm.Text = "Ajouter";
            this.ConfirmForm.UseVisualStyleBackColor = false;
            this.ConfirmForm.Click += new System.EventHandler(this.ConfirmForm_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(134, 585);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(120, 25);
            this.Description.TabIndex = 21;
            this.Description.Text = "Description";
            // 
            // ComplexityLevelLabel
            // 
            this.ComplexityLevelLabel.AutoSize = true;
            this.ComplexityLevelLabel.Location = new System.Drawing.Point(134, 483);
            this.ComplexityLevelLabel.Name = "ComplexityLevelLabel";
            this.ComplexityLevelLabel.Size = new System.Drawing.Size(218, 25);
            this.ComplexityLevelLabel.TabIndex = 22;
            this.ComplexityLevelLabel.Text = "Niveau de complexité";
            // 
            // PriorityLevelLabel
            // 
            this.PriorityLevelLabel.AutoSize = true;
            this.PriorityLevelLabel.Location = new System.Drawing.Point(134, 349);
            this.PriorityLevelLabel.Name = "PriorityLevelLabel";
            this.PriorityLevelLabel.Size = new System.Drawing.Size(181, 25);
            this.PriorityLevelLabel.TabIndex = 23;
            this.PriorityLevelLabel.Text = "Niveau de priorité";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "Basse",
            "Moyenne",
            "Haute"});
            this.priorityComboBox.Location = new System.Drawing.Point(129, 405);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(267, 33);
            this.priorityComboBox.TabIndex = 24;
            // 
            // complexityLevelNumericUpDown
            // 
            this.complexityLevelNumericUpDown.Location = new System.Drawing.Point(139, 528);
            this.complexityLevelNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.complexityLevelNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.complexityLevelNumericUpDown.Name = "complexityLevelNumericUpDown";
            this.complexityLevelNumericUpDown.Size = new System.Drawing.Size(115, 31);
            this.complexityLevelNumericUpDown.TabIndex = 25;
            this.complexityLevelNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // featureDescription
            // 
            this.featureDescription.Location = new System.Drawing.Point(139, 636);
            this.featureDescription.Name = "featureDescription";
            this.featureDescription.Size = new System.Drawing.Size(496, 96);
            this.featureDescription.TabIndex = 27;
            this.featureDescription.Text = "";
            // 
            // AddFeatureToBacklogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 878);
            this.Controls.Add(this.featureDescription);
            this.Controls.Add(this.complexityLevelNumericUpDown);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.PriorityLevelLabel);
            this.Controls.Add(this.ComplexityLevelLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.typeSelectionComboBox);
            this.Controls.Add(this.FeatureTypeLabel);
            this.Controls.Add(this.FeatureTitleLabel);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.backlogFeatureTitleTextBox);
            this.Controls.Add(this.cancelForm);
            this.Controls.Add(this.ConfirmForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFeatureToBacklogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une fonctionnalité au backlog";
            this.Load += new System.EventHandler(this.AddFeatureToBacklogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.complexityLevelNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeSelectionComboBox;
        private System.Windows.Forms.Label FeatureTypeLabel;
        private System.Windows.Forms.Label FeatureTitleLabel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.TextBox backlogFeatureTitleTextBox;
        private System.Windows.Forms.Button cancelForm;
        private System.Windows.Forms.Button ConfirmForm;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label ComplexityLevelLabel;
        private System.Windows.Forms.Label PriorityLevelLabel;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.NumericUpDown complexityLevelNumericUpDown;
        private System.Windows.Forms.RichTextBox featureDescription;
    }
}