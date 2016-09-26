namespace BrowserShell
{
    partial class MockBrowserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MockBrowserForm));
            this.pnlAddressBar = new System.Windows.Forms.Panel();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.pnlBrowsingArea = new System.Windows.Forms.Panel();
            this.wbSurface = new System.Windows.Forms.WebBrowser();
            this.pnlAddressBar.SuspendLayout();
            this.pnlBrowsingArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddressBar
            // 
            this.pnlAddressBar.Controls.Add(this.tbxUrl);
            this.pnlAddressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddressBar.Location = new System.Drawing.Point(0, 0);
            this.pnlAddressBar.Name = "pnlAddressBar";
            this.pnlAddressBar.Size = new System.Drawing.Size(912, 25);
            this.pnlAddressBar.TabIndex = 0;
            // 
            // tbxUrl
            // 
            this.tbxUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUrl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUrl.Location = new System.Drawing.Point(0, 0);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(912, 25);
            this.tbxUrl.TabIndex = 0;
            this.tbxUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxUrl_KeyUp);
            // 
            // pnlBrowsingArea
            // 
            this.pnlBrowsingArea.Controls.Add(this.wbSurface);
            this.pnlBrowsingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowsingArea.Location = new System.Drawing.Point(0, 25);
            this.pnlBrowsingArea.Name = "pnlBrowsingArea";
            this.pnlBrowsingArea.Size = new System.Drawing.Size(912, 448);
            this.pnlBrowsingArea.TabIndex = 1;
            // 
            // wbSurface
            // 
            this.wbSurface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbSurface.Location = new System.Drawing.Point(0, 0);
            this.wbSurface.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSurface.Name = "wbSurface";
            this.wbSurface.Size = new System.Drawing.Size(912, 448);
            this.wbSurface.TabIndex = 0;
            this.wbSurface.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbSurface_DocumentCompleted);
            // 
            // MockBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 473);
            this.Controls.Add(this.pnlBrowsingArea);
            this.Controls.Add(this.pnlAddressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MockBrowserForm";
            this.Text = "WebBrowserBrowser";
            this.Load += new System.EventHandler(this.MockBrowserForm_Load);
            this.pnlAddressBar.ResumeLayout(false);
            this.pnlAddressBar.PerformLayout();
            this.pnlBrowsingArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddressBar;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Panel pnlBrowsingArea;
        private System.Windows.Forms.WebBrowser wbSurface;
    }
}

