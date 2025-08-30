namespace BaiTapThietKeForm
{
    partial class Formchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formchinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nguyenThangThiengToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyenThangThiengToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyenThangThiengToolStripMenuItem
            // 
            this.nguyenThangThiengToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBai1,
            this.tmsiBai2,
            this.tmsiBai3});
            this.nguyenThangThiengToolStripMenuItem.Name = "nguyenThangThiengToolStripMenuItem";
            this.nguyenThangThiengToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.nguyenThangThiengToolStripMenuItem.Text = "Nguyen Thang Thieng";
            // 
            // tsmiBai1
            // 
            this.tsmiBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai1.Image")));
            this.tsmiBai1.Name = "tsmiBai1";
            this.tsmiBai1.Size = new System.Drawing.Size(224, 26);
            this.tsmiBai1.Text = "Bai 1 ";
            this.tsmiBai1.Click += new System.EventHandler(this.tsmiBai1_Click);
            // 
            // tmsiBai2
            // 
            this.tmsiBai2.Image = ((System.Drawing.Image)(resources.GetObject("tmsiBai2.Image")));
            this.tmsiBai2.Name = "tmsiBai2";
            this.tmsiBai2.Size = new System.Drawing.Size(224, 26);
            this.tmsiBai2.Text = "Bai 2 ";
            this.tmsiBai2.Click += new System.EventHandler(this.tmsiBai2_Click);
            // 
            // tmsiBai3
            // 
            this.tmsiBai3.Image = ((System.Drawing.Image)(resources.GetObject("tmsiBai3.Image")));
            this.tmsiBai3.Name = "tmsiBai3";
            this.tmsiBai3.Size = new System.Drawing.Size(224, 26);
            this.tmsiBai3.Text = "Bai 3 ";
            this.tmsiBai3.Click += new System.EventHandler(this.tmsiBai3_Click);
            // 
            // Formchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formchinh";
            this.Text = "Chuong Trinh Chinh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguyenThangThiengToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBai1;
        private System.Windows.Forms.ToolStripMenuItem tmsiBai2;
        private System.Windows.Forms.ToolStripMenuItem tmsiBai3;
    }
}

