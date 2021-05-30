
namespace CubeBurster
{
    partial class frmInloggen
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInloggen = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPaswoord = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPaswoord = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(38, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 33);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Sluit";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblInloggen
            // 
            this.lblInloggen.AutoSize = true;
            this.lblInloggen.Location = new System.Drawing.Point(133, 9);
            this.lblInloggen.Name = "lblInloggen";
            this.lblInloggen.Size = new System.Drawing.Size(97, 17);
            this.lblInloggen.TabIndex = 43;
            this.lblInloggen.Text = "Inlog formulier";
            this.lblInloggen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(178, 117);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 33);
            this.btnLogin.TabIndex = 42;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPaswoord
            // 
            this.txtPaswoord.Location = new System.Drawing.Point(178, 76);
            this.txtPaswoord.Name = "txtPaswoord";
            this.txtPaswoord.Size = new System.Drawing.Size(200, 22);
            this.txtPaswoord.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(178, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 36;
            // 
            // lblPaswoord
            // 
            this.lblPaswoord.AutoSize = true;
            this.lblPaswoord.Location = new System.Drawing.Point(35, 79);
            this.lblPaswoord.Name = "lblPaswoord";
            this.lblPaswoord.Size = new System.Drawing.Size(74, 17);
            this.lblPaswoord.TabIndex = 28;
            this.lblPaswoord.Text = "Paswoord:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email:";
            // 
            // frmInloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 163);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInloggen);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPaswoord);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPaswoord);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmInloggen";
            this.Text = "Inloggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInloggen;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPaswoord;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPaswoord;
        private System.Windows.Forms.Label lblEmail;
    }
}