
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
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.tpAddFilms = new System.Windows.Forms.TabPage();
            this.tcFilms.SuspendLayout();
            this.tpFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // tcFilms
            // 
            this.tcFilms.Controls.Add(this.tpFilms);
            this.tcFilms.Controls.Add(this.tpAddFilms);
            this.tcFilms.Location = new System.Drawing.Point(0, 0);
            this.tcFilms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcFilms.Name = "tcFilms";
            this.tcFilms.SelectedIndex = 0;
            this.tcFilms.Size = new System.Drawing.Size(977, 508);
            this.tcFilms.TabIndex = 0;
            // 
            // tpFilms
            // 
            this.tpFilms.Controls.Add(this.dgvFilms);
            this.tpFilms.Location = new System.Drawing.Point(4, 22);
            this.tpFilms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpFilms.Name = "tpFilms";
            this.tpFilms.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpFilms.Size = new System.Drawing.Size(969, 482);
            this.tpFilms.TabIndex = 0;
            this.tpFilms.Text = "Films";
            this.tpFilms.UseVisualStyleBackColor = true;
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Location = new System.Drawing.Point(0, 0);
            this.dgvFilms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.RowHeadersWidth = 51;
            this.dgvFilms.RowTemplate.Height = 24;
            this.dgvFilms.Size = new System.Drawing.Size(969, 482);
            this.dgvFilms.TabIndex = 1;
            // 
            // tpAddFilms
            // 
            this.tpAddFilms.Location = new System.Drawing.Point(4, 22);
            this.tpAddFilms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAddFilms.Name = "tpAddFilms";
            this.tpAddFilms.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAddFilms.Size = new System.Drawing.Size(593, 340);
            this.tpAddFilms.TabIndex = 1;
            this.tpAddFilms.Text = "Films Toevoegen";
            this.tpAddFilms.UseVisualStyleBackColor = true;
            // 
            // frmFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 506);
            this.Controls.Add(this.tcFilms);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmFilms";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.frmFilms_Load);
            this.tcFilms.ResumeLayout(false);
            this.tpFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFilms;
        private System.Windows.Forms.TabPage tpFilms;
        private System.Windows.Forms.TabPage tpAddFilms;
        private System.Windows.Forms.DataGridView dgvFilms;
    }
}