
namespace pr74_scrum_app
{
    partial class ProfilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilForm));
            this.CreateProjetButton = new System.Windows.Forms.Button();
            this.PictureProfilBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SideBarGroupBox = new System.Windows.Forms.GroupBox();
            this.ProfilListBox = new System.Windows.Forms.ListBox();
            this.RechercheTextBox = new System.Windows.Forms.TextBox();
            this.RechercheLabel = new System.Windows.Forms.Label();
            this.Navbarpanel = new System.Windows.Forms.Panel();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProfilBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Navbarpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateProjetButton
            // 
            this.CreateProjetButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.CreateProjetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CreateProjetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProjetButton.Location = new System.Drawing.Point(1121, 109);
            this.CreateProjetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateProjetButton.Name = "CreateProjetButton";
            this.CreateProjetButton.Size = new System.Drawing.Size(215, 35);
            this.CreateProjetButton.TabIndex = 19;
            this.CreateProjetButton.Text = "Créer un projet";
            this.CreateProjetButton.UseVisualStyleBackColor = true;
            this.CreateProjetButton.Click += new System.EventHandler(this.CreateProjetButton_Click);
            // 
            // PictureProfilBox
            // 
            this.PictureProfilBox.BackColor = System.Drawing.Color.SteelBlue;
            this.PictureProfilBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureProfilBox.Image")));
            this.PictureProfilBox.Location = new System.Drawing.Point(1303, 3);
            this.PictureProfilBox.Name = "PictureProfilBox";
            this.PictureProfilBox.Size = new System.Drawing.Size(29, 35);
            this.PictureProfilBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProfilBox.TabIndex = 21;
            this.PictureProfilBox.TabStop = false;
            this.PictureProfilBox.Click += new System.EventHandler(this.PictureProfilBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // SideBarGroupBox
            // 
            this.SideBarGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.SideBarGroupBox.BackColor = System.Drawing.Color.SteelBlue;
            this.SideBarGroupBox.Location = new System.Drawing.Point(32, 442);
            this.SideBarGroupBox.Name = "SideBarGroupBox";
            this.SideBarGroupBox.Size = new System.Drawing.Size(370, 55);
            this.SideBarGroupBox.TabIndex = 23;
            this.SideBarGroupBox.TabStop = false;
            // 
            // ProfilListBox
            // 
            this.ProfilListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfilListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilListBox.FormattingEnabled = true;
            this.ProfilListBox.ItemHeight = 20;
            this.ProfilListBox.Items.AddRange(new object[] {
            "Mon profil",
            "Déconnexion"});
            this.ProfilListBox.Location = new System.Drawing.Point(1215, 49);
            this.ProfilListBox.Name = "ProfilListBox";
            this.ProfilListBox.Size = new System.Drawing.Size(129, 60);
            this.ProfilListBox.TabIndex = 24;
            this.ProfilListBox.Visible = false;
            this.ProfilListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProfilListBox_MouseClick);
            this.ProfilListBox.MouseLeave += new System.EventHandler(this.ProfilListBox_MouseLeave);
            this.ProfilListBox.MouseHover += new System.EventHandler(this.ProfilListBox_MouseHover);
            // 
            // RechercheTextBox
            // 
            this.RechercheTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercheTextBox.Location = new System.Drawing.Point(870, 115);
            this.RechercheTextBox.Name = "RechercheTextBox";
            this.RechercheTextBox.Size = new System.Drawing.Size(240, 27);
            this.RechercheTextBox.TabIndex = 26;
            // 
            // RechercheLabel
            // 
            this.RechercheLabel.AutoSize = true;
            this.RechercheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercheLabel.Location = new System.Drawing.Point(939, 93);
            this.RechercheLabel.Name = "RechercheLabel";
            this.RechercheLabel.Size = new System.Drawing.Size(99, 20);
            this.RechercheLabel.TabIndex = 27;
            this.RechercheLabel.Text = "Recherche";
            // 
            // Navbarpanel
            // 
            this.Navbarpanel.BackColor = System.Drawing.Color.SteelBlue;
            this.Navbarpanel.Controls.Add(this.PictureProfilBox);
            this.Navbarpanel.Controls.Add(this.EmailtextBox);
            this.Navbarpanel.Location = new System.Drawing.Point(-2, 0);
            this.Navbarpanel.Name = "Navbarpanel";
            this.Navbarpanel.Size = new System.Drawing.Size(1355, 41);
            this.Navbarpanel.TabIndex = 28;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailtextBox.Location = new System.Drawing.Point(1020, 7);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(272, 27);
            this.EmailtextBox.TabIndex = 29;
            // 
            // ProfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.Navbarpanel);
            this.Controls.Add(this.RechercheLabel);
            this.Controls.Add(this.RechercheTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ProfilListBox);
            this.Controls.Add(this.SideBarGroupBox);
            this.Controls.Add(this.CreateProjetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScrumApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfilViewForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PictureProfilBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Navbarpanel.ResumeLayout(false);
            this.Navbarpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateProjetButton;
        private System.Windows.Forms.PictureBox PictureProfilBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox SideBarGroupBox;
        private System.Windows.Forms.ListBox ProfilListBox;
        private System.Windows.Forms.TextBox RechercheTextBox;
        private System.Windows.Forms.Label RechercheLabel;
        private System.Windows.Forms.Panel Navbarpanel;
        private System.Windows.Forms.TextBox EmailtextBox;
    }
}