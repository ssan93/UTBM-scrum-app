using System.Collections.Generic;
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
            this.ProfilListBox = new System.Windows.Forms.ListBox();
            this.RechercheTextBox = new System.Windows.Forms.TextBox();
            this.RechercheLabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PictureProfilBox = new System.Windows.Forms.PictureBox();
            this.Navbarpanel = new System.Windows.Forms.Panel();
            this.RecentProjetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectLabel1 = new System.Windows.Forms.Label();
            this.ProjectLabel2 = new System.Windows.Forms.Label();
            this.roundButton9 = new pr74_scrum_app.View.RoundButton();
            this.roundButton10 = new pr74_scrum_app.View.RoundButton();
            this.roundButton11 = new pr74_scrum_app.View.RoundButton();
            this.roundButton12 = new pr74_scrum_app.View.RoundButton();
            this.roundButton5 = new pr74_scrum_app.View.RoundButton();
            this.roundButton6 = new pr74_scrum_app.View.RoundButton();
            this.roundButton7 = new pr74_scrum_app.View.RoundButton();
            this.roundButton8 = new pr74_scrum_app.View.RoundButton();
            this.ProjectRoundButton4 = new pr74_scrum_app.View.RoundButton();
            this.ProjectRoundButton3 = new pr74_scrum_app.View.RoundButton();
            this.ProjectRoundButton2 = new pr74_scrum_app.View.RoundButton();
            this.ProjectRoundButton1 = new pr74_scrum_app.View.RoundButton();
            this.ProjectLabel3 = new System.Windows.Forms.Label();
            this.ProjectLabel4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProfilBox)).BeginInit();
            this.Navbarpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateProjetButton
            // 
            this.CreateProjetButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.CreateProjetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CreateProjetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProjetButton.Location = new System.Drawing.Point(841, 89);
            this.CreateProjetButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateProjetButton.Name = "CreateProjetButton";
            this.CreateProjetButton.Size = new System.Drawing.Size(161, 28);
            this.CreateProjetButton.TabIndex = 19;
            this.CreateProjetButton.Text = "Créer un projet";
            this.CreateProjetButton.UseVisualStyleBackColor = true;
            this.CreateProjetButton.Click += new System.EventHandler(this.CreateProjetButton_Click);
            // 
            // ProfilListBox
            // 
            this.ProfilListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfilListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilListBox.FormattingEnabled = true;
            this.ProfilListBox.ItemHeight = 17;
            this.ProfilListBox.Items.AddRange(new object[] {
            "Mon profil",
            "Déconnexion"});
            this.ProfilListBox.Location = new System.Drawing.Point(911, 40);
            this.ProfilListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProfilListBox.Name = "ProfilListBox";
            this.ProfilListBox.Size = new System.Drawing.Size(97, 34);
            this.ProfilListBox.TabIndex = 24;
            this.ProfilListBox.Visible = false;
            this.ProfilListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProfilListBox_MouseClick);
            this.ProfilListBox.MouseLeave += new System.EventHandler(this.ProfilListBox_MouseLeave);
            this.ProfilListBox.MouseHover += new System.EventHandler(this.ProfilListBox_MouseHover);
            // 
            // RechercheTextBox
            // 
            this.RechercheTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercheTextBox.Location = new System.Drawing.Point(652, 93);
            this.RechercheTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RechercheTextBox.Name = "RechercheTextBox";
            this.RechercheTextBox.Size = new System.Drawing.Size(181, 23);
            this.RechercheTextBox.TabIndex = 26;
            // 
            // RechercheLabel
            // 
            this.RechercheLabel.AutoSize = true;
            this.RechercheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercheLabel.Location = new System.Drawing.Point(704, 76);
            this.RechercheLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RechercheLabel.Name = "RechercheLabel";
            this.RechercheLabel.Size = new System.Drawing.Size(86, 17);
            this.RechercheLabel.TabIndex = 27;
            this.RechercheLabel.Text = "Recherche";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailtextBox.Location = new System.Drawing.Point(765, 6);
            this.EmailtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(205, 23);
            this.EmailtextBox.TabIndex = 29;
            // 
            // PictureProfilBox
            // 
            this.PictureProfilBox.BackColor = System.Drawing.Color.SteelBlue;
            this.PictureProfilBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureProfilBox.Image")));
            this.PictureProfilBox.Location = new System.Drawing.Point(977, 2);
            this.PictureProfilBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureProfilBox.Name = "PictureProfilBox";
            this.PictureProfilBox.Size = new System.Drawing.Size(22, 28);
            this.PictureProfilBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProfilBox.TabIndex = 21;
            this.PictureProfilBox.TabStop = false;
            this.PictureProfilBox.Click += new System.EventHandler(this.PictureProfilBox_Click);
            // 
            // Navbarpanel
            // 
            this.Navbarpanel.BackColor = System.Drawing.Color.SteelBlue;
            this.Navbarpanel.Controls.Add(this.PictureProfilBox);
            this.Navbarpanel.Controls.Add(this.EmailtextBox);
            this.Navbarpanel.Location = new System.Drawing.Point(-2, 0);
            this.Navbarpanel.Margin = new System.Windows.Forms.Padding(2);
            this.Navbarpanel.Name = "Navbarpanel";
            this.Navbarpanel.Size = new System.Drawing.Size(1016, 33);
            this.Navbarpanel.TabIndex = 28;
            // 
            // RecentProjetLabel
            // 
            this.RecentProjetLabel.AutoSize = true;
            this.RecentProjetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentProjetLabel.Location = new System.Drawing.Point(248, 119);
            this.RecentProjetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RecentProjetLabel.Name = "RecentProjetLabel";
            this.RecentProjetLabel.Size = new System.Drawing.Size(149, 24);
            this.RecentProjetLabel.TabIndex = 33;
            this.RecentProjetLabel.Text = "Projets récents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sprint récents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 422);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Dernières tâches assignées ";
            // 
            // ProjectLabel1
            // 
            this.ProjectLabel1.AutoSize = true;
            this.ProjectLabel1.Location = new System.Drawing.Point(273, 225);
            this.ProjectLabel1.Name = "ProjectLabel1";
            this.ProjectLabel1.Size = new System.Drawing.Size(72, 13);
            this.ProjectLabel1.TabIndex = 47;
            this.ProjectLabel1.Text = "ProjectLabel1";
            this.ProjectLabel1.Visible = false;
            // 
            // ProjectLabel2
            // 
            this.ProjectLabel2.AutoSize = true;
            this.ProjectLabel2.Location = new System.Drawing.Point(476, 225);
            this.ProjectLabel2.Name = "ProjectLabel2";
            this.ProjectLabel2.Size = new System.Drawing.Size(72, 13);
            this.ProjectLabel2.TabIndex = 48;
            this.ProjectLabel2.Text = "ProjectLabel2";
            this.ProjectLabel2.Visible = false;
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton9.FlatAppearance.BorderSize = 0;
            this.roundButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton9.ForeColor = System.Drawing.Color.White;
            this.roundButton9.Location = new System.Drawing.Point(841, 471);
            this.roundButton9.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(135, 79);
            this.roundButton9.TabIndex = 46;
            this.roundButton9.Text = "roundButton9";
            this.roundButton9.UseVisualStyleBackColor = false;
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton10.FlatAppearance.BorderSize = 0;
            this.roundButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton10.ForeColor = System.Drawing.Color.White;
            this.roundButton10.Location = new System.Drawing.Point(649, 472);
            this.roundButton10.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(135, 79);
            this.roundButton10.TabIndex = 45;
            this.roundButton10.Text = "roundButton10";
            this.roundButton10.UseVisualStyleBackColor = false;
            // 
            // roundButton11
            // 
            this.roundButton11.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton11.FlatAppearance.BorderSize = 0;
            this.roundButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton11.ForeColor = System.Drawing.Color.White;
            this.roundButton11.Location = new System.Drawing.Point(444, 472);
            this.roundButton11.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton11.Name = "roundButton11";
            this.roundButton11.Size = new System.Drawing.Size(135, 79);
            this.roundButton11.TabIndex = 44;
            this.roundButton11.Text = "roundButton11";
            this.roundButton11.UseVisualStyleBackColor = false;
            // 
            // roundButton12
            // 
            this.roundButton12.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton12.FlatAppearance.BorderSize = 0;
            this.roundButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton12.ForeColor = System.Drawing.Color.White;
            this.roundButton12.Location = new System.Drawing.Point(242, 471);
            this.roundButton12.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton12.Name = "roundButton12";
            this.roundButton12.Size = new System.Drawing.Size(135, 79);
            this.roundButton12.TabIndex = 42;
            this.roundButton12.Text = "roundButton12";
            this.roundButton12.UseVisualStyleBackColor = false;
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.ForeColor = System.Drawing.Color.White;
            this.roundButton5.Location = new System.Drawing.Point(841, 314);
            this.roundButton5.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(135, 79);
            this.roundButton5.TabIndex = 41;
            this.roundButton5.Text = "roundButton5";
            this.roundButton5.UseVisualStyleBackColor = false;
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.ForeColor = System.Drawing.Color.White;
            this.roundButton6.Location = new System.Drawing.Point(649, 315);
            this.roundButton6.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(135, 79);
            this.roundButton6.TabIndex = 40;
            this.roundButton6.Text = "roundButton6";
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton7.FlatAppearance.BorderSize = 0;
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.ForeColor = System.Drawing.Color.White;
            this.roundButton7.Location = new System.Drawing.Point(444, 315);
            this.roundButton7.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(135, 79);
            this.roundButton7.TabIndex = 39;
            this.roundButton7.Text = "roundButton7";
            this.roundButton7.UseVisualStyleBackColor = false;
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton8.FlatAppearance.BorderSize = 0;
            this.roundButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton8.ForeColor = System.Drawing.Color.White;
            this.roundButton8.Location = new System.Drawing.Point(242, 314);
            this.roundButton8.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(135, 79);
            this.roundButton8.TabIndex = 37;
            this.roundButton8.Text = "roundButton8";
            this.roundButton8.UseVisualStyleBackColor = false;
            // 
            // ProjectRoundButton4
            // 
            this.ProjectRoundButton4.BackColor = System.Drawing.Color.Gainsboro;
            this.ProjectRoundButton4.FlatAppearance.BorderSize = 0;
            this.ProjectRoundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectRoundButton4.ForeColor = System.Drawing.Color.Black;
            this.ProjectRoundButton4.Location = new System.Drawing.Point(841, 168);
            this.ProjectRoundButton4.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectRoundButton4.Name = "ProjectRoundButton4";
            this.ProjectRoundButton4.Size = new System.Drawing.Size(135, 79);
            this.ProjectRoundButton4.TabIndex = 36;
            this.ProjectRoundButton4.UseVisualStyleBackColor = false;
            this.ProjectRoundButton4.Visible = false;
            // 
            // ProjectRoundButton3
            // 
            this.ProjectRoundButton3.BackColor = System.Drawing.Color.Gainsboro;
            this.ProjectRoundButton3.FlatAppearance.BorderSize = 0;
            this.ProjectRoundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectRoundButton3.ForeColor = System.Drawing.Color.White;
            this.ProjectRoundButton3.Location = new System.Drawing.Point(649, 169);
            this.ProjectRoundButton3.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectRoundButton3.Name = "ProjectRoundButton3";
            this.ProjectRoundButton3.Size = new System.Drawing.Size(135, 79);
            this.ProjectRoundButton3.TabIndex = 35;
            this.ProjectRoundButton3.UseVisualStyleBackColor = false;
            this.ProjectRoundButton3.Visible = false;
            // 
            // ProjectRoundButton2
            // 
            this.ProjectRoundButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.ProjectRoundButton2.FlatAppearance.BorderSize = 0;
            this.ProjectRoundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectRoundButton2.ForeColor = System.Drawing.Color.White;
            this.ProjectRoundButton2.Location = new System.Drawing.Point(444, 169);
            this.ProjectRoundButton2.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectRoundButton2.Name = "ProjectRoundButton2";
            this.ProjectRoundButton2.Size = new System.Drawing.Size(135, 79);
            this.ProjectRoundButton2.TabIndex = 34;
            this.ProjectRoundButton2.UseVisualStyleBackColor = false;
            this.ProjectRoundButton2.Visible = false;
            // 
            // ProjectRoundButton1
            // 
            this.ProjectRoundButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.ProjectRoundButton1.FlatAppearance.BorderSize = 0;
            this.ProjectRoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectRoundButton1.ForeColor = System.Drawing.Color.White;
            this.ProjectRoundButton1.Location = new System.Drawing.Point(242, 168);
            this.ProjectRoundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectRoundButton1.Name = "ProjectRoundButton1";
            this.ProjectRoundButton1.Size = new System.Drawing.Size(135, 79);
            this.ProjectRoundButton1.TabIndex = 29;
            this.ProjectRoundButton1.UseVisualStyleBackColor = false;
            this.ProjectRoundButton1.Visible = false;
            // 
            // ProjectLabel3
            // 
            this.ProjectLabel3.AutoSize = true;
            this.ProjectLabel3.Location = new System.Drawing.Point(682, 225);
            this.ProjectLabel3.Name = "ProjectLabel3";
            this.ProjectLabel3.Size = new System.Drawing.Size(72, 13);
            this.ProjectLabel3.TabIndex = 49;
            this.ProjectLabel3.Text = "ProjectLabel3";
            this.ProjectLabel3.Visible = false;
            // 
            // ProjectLabel4
            // 
            this.ProjectLabel4.AutoSize = true;
            this.ProjectLabel4.Location = new System.Drawing.Point(878, 225);
            this.ProjectLabel4.Name = "ProjectLabel4";
            this.ProjectLabel4.Size = new System.Drawing.Size(72, 13);
            this.ProjectLabel4.TabIndex = 50;
            this.ProjectLabel4.Text = "ProjectLabel4";
            this.ProjectLabel4.Visible = false;
            // 
            // ProfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 586);
            this.Controls.Add(this.ProjectLabel4);
            this.Controls.Add(this.ProjectLabel3);
            this.Controls.Add(this.ProjectLabel2);
            this.Controls.Add(this.ProjectLabel1);
            this.Controls.Add(this.roundButton9);
            this.Controls.Add(this.roundButton10);
            this.Controls.Add(this.roundButton11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundButton12);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.roundButton7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton8);
            this.Controls.Add(this.ProjectRoundButton4);
            this.Controls.Add(this.ProjectRoundButton3);
            this.Controls.Add(this.ProjectRoundButton2);
            this.Controls.Add(this.RecentProjetLabel);
            this.Controls.Add(this.ProjectRoundButton1);
            this.Controls.Add(this.Navbarpanel);
            this.Controls.Add(this.RechercheLabel);
            this.Controls.Add(this.RechercheTextBox);
            this.Controls.Add(this.ProfilListBox);
            this.Controls.Add(this.CreateProjetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ProfilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScrumApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfilViewForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PictureProfilBox)).EndInit();
            this.Navbarpanel.ResumeLayout(false);
            this.Navbarpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button CreateProjetButton;
        private System.Windows.Forms.ListBox ProfilListBox;
        private System.Windows.Forms.TextBox RechercheTextBox;
        private System.Windows.Forms.Label RechercheLabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.PictureBox PictureProfilBox;
        private System.Windows.Forms.Panel Navbarpanel;
        private View.RoundButton ProjectRoundButton1;
        private System.Windows.Forms.Label RecentProjetLabel;
        private View.RoundButton ProjectRoundButton2;
        private View.RoundButton ProjectRoundButton3;
        private View.RoundButton ProjectRoundButton4;
        private View.RoundButton roundButton5;
        private View.RoundButton roundButton6;
        private View.RoundButton roundButton7;
        private System.Windows.Forms.Label label1;
        private View.RoundButton roundButton8;
        private View.RoundButton roundButton9;
        private View.RoundButton roundButton10;
        private View.RoundButton roundButton11;
        private System.Windows.Forms.Label label2;
        private View.RoundButton roundButton12;
        private System.Windows.Forms.Label ProjectLabel1;
        private System.Windows.Forms.Label ProjectLabel2;
        private System.Windows.Forms.Label ProjectLabel3;
        private System.Windows.Forms.Label ProjectLabel4;
        private List<System.Windows.Forms.Label> labels;
        private List<View.RoundButton> roudboutonProjet;
    }
}