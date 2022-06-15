
namespace pr74_scrum_app
{
    partial class CreatePojetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePojetForm));
            this.CreationProjetLabel = new System.Windows.Forms.Label();
            this.NomduProjetLabel = new System.Windows.Forms.Label();
            this.NameProjetText = new System.Windows.Forms.TextBox();
            this.CreateValidedButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreationProjetLabel
            // 
            this.CreationProjetLabel.AutoSize = true;
            this.CreationProjetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationProjetLabel.Location = new System.Drawing.Point(142, 26);
            this.CreationProjetLabel.Name = "CreationProjetLabel";
            this.CreationProjetLabel.Size = new System.Drawing.Size(242, 29);
            this.CreationProjetLabel.TabIndex = 26;
            this.CreationProjetLabel.Text = "Création d\'un projet";
            // 
            // NomduProjetLabel
            // 
            this.NomduProjetLabel.AutoSize = true;
            this.NomduProjetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomduProjetLabel.Location = new System.Drawing.Point(12, 87);
            this.NomduProjetLabel.Name = "NomduProjetLabel";
            this.NomduProjetLabel.Size = new System.Drawing.Size(127, 20);
            this.NomduProjetLabel.TabIndex = 25;
            this.NomduProjetLabel.Text = "Nom du projet";
            // 
            // NameProjetText
            // 
            this.NameProjetText.Location = new System.Drawing.Point(191, 87);
            this.NameProjetText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameProjetText.Name = "NameProjetText";
            this.NameProjetText.Size = new System.Drawing.Size(265, 22);
            this.NameProjetText.TabIndex = 24;
            // 
            // CreateValidedButton
            // 
            this.CreateValidedButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.CreateValidedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CreateValidedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateValidedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateValidedButton.Location = new System.Drawing.Point(189, 145);
            this.CreateValidedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateValidedButton.Name = "CreateValidedButton";
            this.CreateValidedButton.Size = new System.Drawing.Size(140, 29);
            this.CreateValidedButton.TabIndex = 27;
            this.CreateValidedButton.Text = "Valider ";
            this.CreateValidedButton.UseVisualStyleBackColor = true;
            this.CreateValidedButton.Click += new System.EventHandler(this.CreateValidedButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(189, 116);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(275, 17);
            this.ErrorLabel.TabIndex = 28;
            this.ErrorLabel.Text = "La valeur du champs ne peut pas est null !";
            this.ErrorLabel.Visible = false;
            // 
            // CreatePojetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 208);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CreateValidedButton);
            this.Controls.Add(this.CreationProjetLabel);
            this.Controls.Add(this.NomduProjetLabel);
            this.Controls.Add(this.NameProjetText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePojetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrumApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreationProjetLabel;
        private System.Windows.Forms.Label NomduProjetLabel;
        private System.Windows.Forms.TextBox NameProjetText;
        private System.Windows.Forms.Button CreateValidedButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}