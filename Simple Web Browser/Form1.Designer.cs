namespace Simple_Web_Browser
{
    partial class Browser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.imglist_buttons = new System.Windows.Forms.ImageList(this.components);
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.ts_btn_Back = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_Forward = new System.Windows.Forms.ToolStripButton();
            this.ts_addressbar = new System.Windows.Forms.ToolStripTextBox();
            this.ts_btn_Go = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_Stop = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_Home = new System.Windows.Forms.ToolStripButton();
            this.tsToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 35);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(794, 501);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // imglist_buttons
            // 
            this.imglist_buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist_buttons.ImageStream")));
            this.imglist_buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist_buttons.Images.SetKeyName(0, "cancel22.png");
            this.imglist_buttons.Images.SetKeyName(1, "check64.png");
            this.imglist_buttons.Images.SetKeyName(2, "favourite24.png");
            this.imglist_buttons.Images.SetKeyName(3, "home166.png");
            this.imglist_buttons.Images.SetKeyName(4, "left15.png");
            this.imglist_buttons.Images.SetKeyName(5, "repair17.png");
            this.imglist_buttons.Images.SetKeyName(6, "right11.png");
            this.imglist_buttons.Images.SetKeyName(7, "update23.png");
            // 
            // tsToolbar
            // 
            this.tsToolbar.ImageList = this.imglist_buttons;
            this.tsToolbar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_Back,
            this.ts_btn_Forward,
            this.ts_addressbar,
            this.ts_btn_Go,
            this.ts_btn_Stop,
            this.ts_btn_Refresh,
            this.ts_btn_Home});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.Size = new System.Drawing.Size(794, 35);
            this.tsToolbar.Stretch = true;
            this.tsToolbar.TabIndex = 8;
            // 
            // ts_btn_Back
            // 
            this.ts_btn_Back.AutoSize = false;
            this.ts_btn_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_Back.ImageIndex = 4;
            this.ts_btn_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_Back.Name = "ts_btn_Back";
            this.ts_btn_Back.Size = new System.Drawing.Size(32, 32);
            this.ts_btn_Back.Click += new System.EventHandler(this.ts_btn_Back_Click);
            // 
            // ts_btn_Forward
            // 
            this.ts_btn_Forward.AutoSize = false;
            this.ts_btn_Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_Forward.ImageIndex = 6;
            this.ts_btn_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_Forward.Name = "ts_btn_Forward";
            this.ts_btn_Forward.Size = new System.Drawing.Size(32, 32);
            this.ts_btn_Forward.Click += new System.EventHandler(this.ts_btn_Forward_Click);
            // 
            // ts_addressbar
            // 
            this.ts_addressbar.Name = "ts_addressbar";
            this.ts_addressbar.Size = new System.Drawing.Size(400, 35);
            this.ts_addressbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressEnter);
            // 
            // ts_btn_Go
            // 
            this.ts_btn_Go.AutoSize = false;
            this.ts_btn_Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_Go.ImageIndex = 1;
            this.ts_btn_Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_Go.Name = "ts_btn_Go";
            this.ts_btn_Go.Size = new System.Drawing.Size(32, 32);
            this.ts_btn_Go.Click += new System.EventHandler(this.ts_btn_Go_Click);
            // 
            // ts_btn_Stop
            // 
            this.ts_btn_Stop.AutoSize = false;
            this.ts_btn_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_Stop.ImageIndex = 0;
            this.ts_btn_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_Stop.Name = "ts_btn_Stop";
            this.ts_btn_Stop.Size = new System.Drawing.Size(32, 32);
            this.ts_btn_Stop.Click += new System.EventHandler(this.ts_btn_Stop_Click);
            // 
            // ts_btn_Refresh
            // 
            this.ts_btn_Refresh.AutoSize = false;
            this.ts_btn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_Refresh.ImageIndex = 7;
            this.ts_btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_Refresh.Name = "ts_btn_Refresh";
            this.ts_btn_Refresh.Size = new System.Drawing.Size(32, 32);
            this.ts_btn_Refresh.Click += new System.EventHandler(this.ts_btn_Refresh_Click);
            // 
            // ts_btn_Home
            // 
            this.ts_btn_Home.AutoSize = false;
            this.ts_btn_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_Home.ImageIndex = 3;
            this.ts_btn_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_Home.Name = "ts_btn_Home";
            this.ts_btn_Home.Size = new System.Drawing.Size(32, 32);
            this.ts_btn_Home.Click += new System.EventHandler(this.ts_btn_Home_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 536);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.tsToolbar);
            this.Name = "Browser";
            this.Text = "Simple Browser";
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ImageList imglist_buttons;
        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.ToolStripButton ts_btn_Back;
        private System.Windows.Forms.ToolStripButton ts_btn_Forward;
        private System.Windows.Forms.ToolStripButton ts_btn_Go;
        private System.Windows.Forms.ToolStripButton ts_btn_Stop;
        private System.Windows.Forms.ToolStripButton ts_btn_Refresh;
        private System.Windows.Forms.ToolStripButton ts_btn_Home;
        private System.Windows.Forms.ToolStripTextBox ts_addressbar;
    }
}

