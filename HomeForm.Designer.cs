
namespace pr74_scrum_app
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.SigninHomebutton = new System.Windows.Forms.Button();
            this.SignUpHomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelScrum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CommencerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SigninHomebutton
            // 
            this.SigninHomebutton.BackColor = System.Drawing.Color.White;
            this.SigninHomebutton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.SigninHomebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.SigninHomebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SigninHomebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninHomebutton.Location = new System.Drawing.Point(511, 9);
            this.SigninHomebutton.Margin = new System.Windows.Forms.Padding(2);
            this.SigninHomebutton.Name = "SigninHomebutton";
            this.SigninHomebutton.Size = new System.Drawing.Size(82, 32);
            this.SigninHomebutton.TabIndex = 0;
            this.SigninHomebutton.Text = "Sign In";
            this.SigninHomebutton.UseVisualStyleBackColor = false;
            this.SigninHomebutton.Click += new System.EventHandler(this.SigninHomebutton_Click);
            // 
            // SignUpHomeButton
            // 
            this.SignUpHomeButton.BackColor = System.Drawing.Color.White;
            this.SignUpHomeButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.SignUpHomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.SignUpHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpHomeButton.Location = new System.Drawing.Point(625, 9);
            this.SignUpHomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpHomeButton.Name = "SignUpHomeButton";
            this.SignUpHomeButton.Size = new System.Drawing.Size(82, 32);
            this.SignUpHomeButton.TabIndex = 1;
            this.SignUpHomeButton.Text = "Sign Up";
            this.SignUpHomeButton.UseVisualStyleBackColor = false;
            this.SignUpHomeButton.Click += new System.EventHandler(this.SignUpHomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion de projet avec la méthode ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelScrum
            // 
            this.labelScrum.AutoSize = true;
            this.labelScrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScrum.Location = new System.Drawing.Point(498, 102);
            this.labelScrum.Name = "labelScrum";
            this.labelScrum.Size = new System.Drawing.Size(105, 29);
            this.labelScrum.TabIndex = 4;
            this.labelScrum.Text = "SCRUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Simplifier la gestion de vos projets de développements en utilisant \r\n           " +
    "             la méthode SCRUM avec notre outil ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // CommencerButton
            // 
            this.CommencerButton.BackColor = System.Drawing.Color.White;
            this.CommencerButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.CommencerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CommencerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommencerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommencerButton.Location = new System.Drawing.Point(311, 234);
            this.CommencerButton.Margin = new System.Windows.Forms.Padding(2);
            this.CommencerButton.Name = "CommencerButton";
            this.CommencerButton.Size = new System.Drawing.Size(120, 32);
            this.CommencerButton.TabIndex = 7;
            this.CommencerButton.Text = "Commencer";
            this.CommencerButton.UseVisualStyleBackColor = false;
            this.CommencerButton.Click += new System.EventHandler(this.CommencerButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 514);
            this.Controls.Add(this.CommencerButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelScrum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpHomeButton);
            this.Controls.Add(this.SigninHomebutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrumApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SigninHomebutton;
        private System.Windows.Forms.Button SignUpHomeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelScrum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CommencerButton;
    }
}