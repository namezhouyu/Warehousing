namespace Warehousing
{
    partial class Portal
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portalPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.storegeToolStripMenuItem,
            this.outToolStripMenuItem,
            this.productSettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.viewToolStripMenuItem.Text = "库存";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // storegeToolStripMenuItem
            // 
            this.storegeToolStripMenuItem.Name = "storegeToolStripMenuItem";
            this.storegeToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.storegeToolStripMenuItem.Text = "入库";
            this.storegeToolStripMenuItem.Click += new System.EventHandler(this.storegeToolStripMenuItem_Click);
            // 
            // outToolStripMenuItem
            // 
            this.outToolStripMenuItem.Name = "outToolStripMenuItem";
            this.outToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.outToolStripMenuItem.Text = "出库";
            this.outToolStripMenuItem.Click += new System.EventHandler(this.outToolStripMenuItem_Click);
            // 
            // productSettingToolStripMenuItem
            // 
            this.productSettingToolStripMenuItem.Name = "productSettingToolStripMenuItem";
            this.productSettingToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.productSettingToolStripMenuItem.Text = "关于";
            this.productSettingToolStripMenuItem.Click += new System.EventHandler(this.productSettingToolStripMenuItem_Click);
            // 
            // portalPanel
            // 
            this.portalPanel.Location = new System.Drawing.Point(12, 52);
            this.portalPanel.Name = "portalPanel";
            this.portalPanel.Size = new System.Drawing.Size(1314, 666);
            this.portalPanel.TabIndex = 1;
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 730);
            this.Controls.Add(this.portalPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Portal";
            this.Text = "简单仓储系统v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel portalPanel;



    }
}

