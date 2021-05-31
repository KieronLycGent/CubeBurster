namespace CubeBurster
{
    partial class frmHome
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
            this.registrerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beheerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werknemerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitgeleendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblnaam = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.beheerToolStripMenuItem,
            this.filmsToolStripMenuItem,
            this.boetesToolStripMenuItem,
            this.uitgeleendToolStripMenuItem});
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
            this.registrerenToolStripMenuItem,
            this.uitloggenToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // inloggenToolStripMenuItem
            // 
            this.inloggenToolStripMenuItem.Name = "inloggenToolStripMenuItem";
            this.inloggenToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.inloggenToolStripMenuItem.Text = "Inloggen";
            this.inloggenToolStripMenuItem.Click += new System.EventHandler(this.InloggenToolStripMenuItem_Click);
            // 
            // registrerenToolStripMenuItem
            // 
            this.registrerenToolStripMenuItem.Name = "registrerenToolStripMenuItem";
            this.registrerenToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.registrerenToolStripMenuItem.Text = "Registreren";
            this.registrerenToolStripMenuItem.Click += new System.EventHandler(this.registrerenToolStripMenuItem_Click);
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            // 
            // beheerToolStripMenuItem
            // 
            this.beheerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.werknemerToolStripMenuItem});
            this.beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
            this.beheerToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.beheerToolStripMenuItem.Text = "Beheer";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // werknemerToolStripMenuItem
            // 
            this.werknemerToolStripMenuItem.Name = "werknemerToolStripMenuItem";
            this.werknemerToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.werknemerToolStripMenuItem.Text = "Werknemer";
            this.werknemerToolStripMenuItem.Click += new System.EventHandler(this.werknemerToolStripMenuItem_Click);
            // 
            // filmsToolStripMenuItem
            // 
            this.filmsToolStripMenuItem.Name = "filmsToolStripMenuItem";
            this.filmsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.filmsToolStripMenuItem.Text = "Films";
            this.filmsToolStripMenuItem.Click += new System.EventHandler(this.filmsToolStripMenuItem_Click);
            // 
            // boetesToolStripMenuItem
            // 
            this.boetesToolStripMenuItem.Name = "boetesToolStripMenuItem";
            this.boetesToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.boetesToolStripMenuItem.Text = "Boetes";
            // 
            // uitgeleendToolStripMenuItem
            // 
            this.uitgeleendToolStripMenuItem.Name = "uitgeleendToolStripMenuItem";
            this.uitgeleendToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.uitgeleendToolStripMenuItem.Text = "Uitgeleend";
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Location = new System.Drawing.Point(34, 52);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(62, 17);
            this.lblnaam.TabIndex = 1;
            this.lblnaam.Text = "Welkom ";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(34, 69);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(62, 17);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "Welkom ";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblnaam);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beheerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem werknemerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitgeleendToolStripMenuItem;
        private System.Windows.Forms.Label lblnaam;
        private System.Windows.Forms.Label lbltype;
    }
}

