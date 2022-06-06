﻿
namespace pr74_scrum_app
{
    partial class SignInForm
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
            this.signinLabel = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signinpasswordText = new System.Windows.Forms.TextBox();
            this.signiemailText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signinLabel
            // 
            this.signinLabel.AutoSize = true;
            this.signinLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signinLabel.Location = new System.Drawing.Point(341, 239);
            this.signinLabel.Name = "signinLabel";
            this.signinLabel.Size = new System.Drawing.Size(58, 17);
            this.signinLabel.TabIndex = 20;
            this.signinLabel.TabStop = true;
            this.signinLabel.Text = "Sign Up";
            this.signinLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SigninLabel_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Don\'t have an account ?";
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(221, 187);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(99, 32);
            this.SignInButton.TabIndex = 18;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // signinpasswordText
            // 
            this.signinpasswordText.Location = new System.Drawing.Point(179, 138);
            this.signinpasswordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signinpasswordText.Name = "signinpasswordText";
            this.signinpasswordText.Size = new System.Drawing.Size(265, 22);
            this.signinpasswordText.TabIndex = 15;
            this.signinpasswordText.UseSystemPasswordChar = true;
            // 
            // signiemailText
            // 
            this.signiemailText.Location = new System.Drawing.Point(179, 94);
            this.signiemailText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signiemailText.Name = "signiemailText";
            this.signiemailText.Size = new System.Drawing.Size(265, 22);
            this.signiemailText.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sign In to ScrumApp";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 282);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.signinLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signinpasswordText);
            this.Controls.Add(this.signiemailText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel signinLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signinpasswordText;
        private System.Windows.Forms.TextBox signiemailText;
        private System.Windows.Forms.Label label6;
    }
}