namespace CubeBurster
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmAanmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inloggenToolStripMenuItem,
            this.frmAanmeldenToolStripMenuItem,
            this.afmeldenToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.AccountToolStripMenuItem_Click);
            // 
            // inloggenToolStripMenuItem
            // 
            this.inloggenToolStripMenuItem.Name = "inloggenToolStripMenuItem";
            this.inloggenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inloggenToolStripMenuItem.Text = "Inloggen";
            // 
            // frmAanmeldenToolStripMenuItem
            // 
            this.frmAanmeldenToolStripMenuItem.Name = "frmAanmeldenToolStripMenuItem";
            this.frmAanmeldenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.frmAanmeldenToolStripMenuItem.Text = "Registreren";
            this.frmAanmeldenToolStripMenuItem.Click += new System.EventHandler(this.AanmeldenToolStripMenuItem_Click);
            // 
            // afmeldenToolStripMenuItem
            // 
            this.afmeldenToolStripMenuItem.Name = "afmeldenToolStripMenuItem";
            this.afmeldenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afmeldenToolStripMenuItem.Text = "Uitloggen";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmAanmeldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afmeldenToolStripMenuItem;
    }
}

