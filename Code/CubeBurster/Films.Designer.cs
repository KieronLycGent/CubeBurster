
namespace CubeBurster
{
    partial class frmFilms
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
            this.tcFilms = new System.Windows.Forms.TabControl();
            this.tpFilms = new System.Windows.Forms.TabPage();
            this.tpAddFilms = new System.Windows.Forms.TabPage();
            this.tcFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFilms
            // 
            this.tcFilms.Controls.Add(this.tpFilms);
            this.tcFilms.Controls.Add(this.tpAddFilms);
            this.tcFilms.Location = new System.Drawing.Point(0, 0);
            this.tcFilms.Name = "tcFilms";
            this.tcFilms.SelectedIndex = 0;
            this.tcFilms.Size = new System.Drawing.Size(801, 450);
            this.tcFilms.TabIndex = 0;
            // 
            // tpFilms
            // 
            this.tpFilms.Location = new System.Drawing.Point(4, 25);
            this.tpFilms.Name = "tpFilms";
            this.tpFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tpFilms.Size = new System.Drawing.Size(793, 421);
            this.tpFilms.TabIndex = 0;
            this.tpFilms.Text = "Films";
            this.tpFilms.UseVisualStyleBackColor = true;
            // 
            // tpAddFilms
            // 
            this.tpAddFilms.Location = new System.Drawing.Point(4, 25);
            this.tpAddFilms.Name = "tpAddFilms";
            this.tpAddFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddFilms.Size = new System.Drawing.Size(793, 421);
            this.tpAddFilms.TabIndex = 1;
            this.tpAddFilms.Text = "Films Toevoegen";
            this.tpAddFilms.UseVisualStyleBackColor = true;
            // 
            // frmFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcFilms);
            this.Name = "frmFilms";
            this.Text = "Films";
            this.tcFilms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFilms;
        private System.Windows.Forms.TabPage tpFilms;
        private System.Windows.Forms.TabPage tpAddFilms;
    }
}