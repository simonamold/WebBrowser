namespace WebBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.lblViewKey = new System.Windows.Forms.ToolStripLabel();
            this.tsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddKeyword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewKeyword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(857, 611);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Navigating);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel,
            this.txtUrl,
            this.btnGo,
            this.btnBack,
            this.btnForward,
            this.btnHome,
            this.lblViewKey,
            this.tsComboBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(857, 28);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(38, 25);
            this.toolStripLabel.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(200, 28);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(29, 25);
            this.btnGo.Text = "Go";
            this.btnGo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 25);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(29, 25);
            this.btnForward.Text = "Forward";
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(29, 25);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblViewKey
            // 
            this.lblViewKey.Name = "lblViewKey";
            this.lblViewKey.Size = new System.Drawing.Size(76, 25);
            this.lblViewKey.Text = "Keywords:";
            // 
            // tsComboBox
            // 
            this.tsComboBox.Name = "tsComboBox";
            this.tsComboBox.Size = new System.Drawing.Size(150, 28);
            this.tsComboBox.Text = "Blocked Keywords";
            this.tsComboBox.Click += new System.EventHandler(this.tsComboBox_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDatabase,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(857, 28);
            this.menu.TabIndex = 2;
            this.menu.Text = "Database";
            // 
            // tsDatabase
            // 
            this.tsDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConnect,
            this.tsDisconnect,
            this.tsAddKeyword,
            this.tsViewKeyword,
            this.tsRemove});
            this.tsDatabase.Name = "tsDatabase";
            this.tsDatabase.Size = new System.Drawing.Size(86, 24);
            this.tsDatabase.Text = "Database";
            // 
            // tsConnect
            // 
            this.tsConnect.Name = "tsConnect";
            this.tsConnect.Size = new System.Drawing.Size(208, 26);
            this.tsConnect.Text = "Connect";
            this.tsConnect.Click += new System.EventHandler(this.tsConnect_Click);
            // 
            // tsDisconnect
            // 
            this.tsDisconnect.Name = "tsDisconnect";
            this.tsDisconnect.Size = new System.Drawing.Size(208, 26);
            this.tsDisconnect.Text = "Disconnect";
            this.tsDisconnect.Click += new System.EventHandler(this.tsDisconnect_Click);
            // 
            // tsAddKeyword
            // 
            this.tsAddKeyword.Name = "tsAddKeyword";
            this.tsAddKeyword.Size = new System.Drawing.Size(208, 26);
            this.tsAddKeyword.Text = "Add Keyword";
            this.tsAddKeyword.Click += new System.EventHandler(this.tsAddKeyword_Click);
            // 
            // tsViewKeyword
            // 
            this.tsViewKeyword.Name = "tsViewKeyword";
            this.tsViewKeyword.Size = new System.Drawing.Size(208, 26);
            this.tsViewKeyword.Text = "View Keyword";
            this.tsViewKeyword.Click += new System.EventHandler(this.tsViewKeyword_Click);
            // 
            // tsRemove
            // 
            this.tsRemove.Name = "tsRemove";
            this.tsRemove.Size = new System.Drawing.Size(208, 26);
            this.tsRemove.Text = "Remove Keyword";
            this.tsRemove.Click += new System.EventHandler(this.tsRemove_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(857, 611);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.webBrowser);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsConnect;
        private System.Windows.Forms.ToolStripMenuItem tsDisconnect;
        private System.Windows.Forms.ToolStripMenuItem tsAddKeyword;
        private System.Windows.Forms.ToolStripMenuItem tsViewKeyword;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsRemove;
        private System.Windows.Forms.ToolStripComboBox tsComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.ToolStripLabel lblViewKey;
    }
}

