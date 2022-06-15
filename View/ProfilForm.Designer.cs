
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RechercheLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProfilBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateProjetButton
            // 
            this.CreateProjetButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.CreateProjetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CreateProjetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProjetButton.Location = new System.Drawing.Point(583, 18);
            this.CreateProjetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateProjetButton.Name = "CreateProjetButton";
            this.CreateProjetButton.Size = new System.Drawing.Size(165, 42);
            this.CreateProjetButton.TabIndex = 19;
            this.CreateProjetButton.Text = "Créer un projet";
            this.CreateProjetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateProjetButton.UseVisualStyleBackColor = true;
            // 
            // PictureProfilBox
            // 
            this.PictureProfilBox.BackColor = System.Drawing.Color.SteelBlue;
            this.PictureProfilBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureProfilBox.Image")));
            this.PictureProfilBox.Location = new System.Drawing.Point(1195, 22);
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
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // SideBarGroupBox
            // 
            this.SideBarGroupBox.BackColor = System.Drawing.Color.SteelBlue;
            this.SideBarGroupBox.Location = new System.Drawing.Point(0, 237);
            this.SideBarGroupBox.Name = "SideBarGroupBox";
            this.SideBarGroupBox.Size = new System.Drawing.Size(209, 406);
            this.SideBarGroupBox.TabIndex = 23;
            this.SideBarGroupBox.TabStop = false;
            this.SideBarGroupBox.Text = "SideBarGroupBox";
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
            this.ProfilListBox.Location = new System.Drawing.Point(1097, 62);
            this.ProfilListBox.Name = "ProfilListBox";
            this.ProfilListBox.Size = new System.Drawing.Size(129, 60);
            this.ProfilListBox.TabIndex = 24;
            this.ProfilListBox.Visible = false;
            this.ProfilListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProfilListBox_MouseClick);
            this.ProfilListBox.MouseLeave += new System.EventHandler(this.ProfilListBox_MouseLeave);
            this.ProfilListBox.MouseHover += new System.EventHandler(this.ProfilListBox_MouseHover);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(1016, 29);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(54, 20);
            this.EmailLabel.TabIndex = 25;
            this.EmailLabel.Text = "email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 26;
            // 
            // RechercheLabel
            // 
            this.RechercheLabel.AutoSize = true;
            this.RechercheLabel.Location = new System.Drawing.Point(169, 9);
            this.RechercheLabel.Name = "RechercheLabel";
            this.RechercheLabel.Size = new System.Drawing.Size(77, 17);
            this.RechercheLabel.TabIndex = 27;
            this.RechercheLabel.Text = "Recherche";
            // 
            // ProfilViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 641);
            this.Controls.Add(this.RechercheLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ProfilListBox);
            this.Controls.Add(this.SideBarGroupBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PictureProfilBox);
            this.Controls.Add(this.CreateProjetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfilViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScrumApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfilViewForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PictureProfilBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateProjetButton;
        private System.Windows.Forms.PictureBox PictureProfilBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox SideBarGroupBox;
        private System.Windows.Forms.ListBox ProfilListBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RechercheLabel;
    }
}