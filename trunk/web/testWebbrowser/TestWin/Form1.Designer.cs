namespace TestWin
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wb_browser = new System.Windows.Forms.WebBrowser();
            this.btn_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wb_browser
            // 
            this.wb_browser.Dock = System.Windows.Forms.DockStyle.Top;
            this.wb_browser.Location = new System.Drawing.Point(0, 0);
            this.wb_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_browser.Name = "wb_browser";
            this.wb_browser.Size = new System.Drawing.Size(800, 359);
            this.wb_browser.TabIndex = 0;
            this.wb_browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_browser_DocumentCompleted);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(12, 386);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 1;
            this.btn_test.Text = "测试";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.wb_browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_browser;
        private System.Windows.Forms.Button btn_test;
    }
}

