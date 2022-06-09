
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
            this.SigninHomebutton = new System.Windows.Forms.Button();
            this.SignUpHomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SigninHomebutton
            // 
            this.SigninHomebutton.Location = new System.Drawing.Point(513, 42);
            this.SigninHomebutton.Name = "SigninHomebutton";
            this.SigninHomebutton.Size = new System.Drawing.Size(81, 32);
            this.SigninHomebutton.TabIndex = 0;
            this.SigninHomebutton.Text = "Sign In";
            this.SigninHomebutton.UseVisualStyleBackColor = true;
            this.SigninHomebutton.Click += new System.EventHandler(this.SigninHomebutton_Click);
            // 
            // SignUpHomeButton
            // 
            this.SignUpHomeButton.Location = new System.Drawing.Point(623, 42);
            this.SignUpHomeButton.Name = "SignUpHomeButton";
            this.SignUpHomeButton.Size = new System.Drawing.Size(90, 32);
            this.SignUpHomeButton.TabIndex = 1;
            this.SignUpHomeButton.Text = "Sign Up";
            this.SignUpHomeButton.UseVisualStyleBackColor = true;
            this.SignUpHomeButton.Click += new System.EventHandler(this.SignUpHomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ouuuuu les amis, call me sexy boy -> make me great";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpHomeButton);
            this.Controls.Add(this.SigninHomebutton);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SigninHomebutton;
        private System.Windows.Forms.Button SignUpHomeButton;
        private System.Windows.Forms.Label label1;
    }
}