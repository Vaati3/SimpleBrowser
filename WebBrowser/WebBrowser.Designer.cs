namespace WebBrowser
{
    partial class WebBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.CheckBulk = new System.Windows.Forms.CheckBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnReload = new System.Windows.Forms.Button();
            this.BtnFavor = new System.Windows.Forms.Button();
            this.BtnFavorites = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnSetHome = new System.Windows.Forms.Button();
            this.PanelBrowserBtn = new System.Windows.Forms.Panel();
            this.FavoritesName = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.TextBox();
            this.ListFavorites = new System.Windows.Forms.ListBox();
            this.ListHistory = new System.Windows.Forms.ListBox();
            this.PanelBrowserBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.BtnSearch.Location = new System.Drawing.Point(497, 18);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(93, 32);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(727, 419);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 23);
            this.textBox2.TabIndex = 2;
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBar.Location = new System.Drawing.Point(8, 18);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(483, 31);
            this.SearchBar.TabIndex = 2;
            this.SearchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyUp);
            // 
            // CheckBulk
            // 
            this.CheckBulk.AutoSize = true;
            this.CheckBulk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBulk.ForeColor = System.Drawing.SystemColors.Info;
            this.CheckBulk.Location = new System.Drawing.Point(596, 26);
            this.CheckBulk.Name = "CheckBulk";
            this.CheckBulk.Size = new System.Drawing.Size(49, 19);
            this.CheckBulk.TabIndex = 11;
            this.CheckBulk.Text = "Bulk";
            this.CheckBulk.UseVisualStyleBackColor = true;
            this.CheckBulk.CheckedChanged += new System.EventHandler(this.CheckBulk_CheckedChanged);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelStatus.Location = new System.Drawing.Point(33, 52);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(39, 15);
            this.LabelStatus.TabIndex = 13;
            this.LabelStatus.Text = "Status";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelTitle.Location = new System.Drawing.Point(123, 52);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(29, 15);
            this.LabelTitle.TabIndex = 14;
            this.LabelTitle.Text = "Title";
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.Location = new System.Drawing.Point(9, 6);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(45, 38);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReload.FlatAppearance.BorderSize = 0;
            this.BtnReload.Location = new System.Drawing.Point(53, 6);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(44, 38);
            this.BtnReload.TabIndex = 5;
            this.BtnReload.UseVisualStyleBackColor = false;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnFavor
            // 
            this.BtnFavor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.BtnFavor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFavor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFavor.FlatAppearance.BorderSize = 0;
            this.BtnFavor.Location = new System.Drawing.Point(95, 6);
            this.BtnFavor.Name = "BtnFavor";
            this.BtnFavor.Size = new System.Drawing.Size(45, 39);
            this.BtnFavor.TabIndex = 6;
            this.BtnFavor.UseVisualStyleBackColor = false;
            this.BtnFavor.Click += new System.EventHandler(this.BtnFavor_Click);
            // 
            // BtnFavorites
            // 
            this.BtnFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.BtnFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFavorites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.BtnFavorites.Location = new System.Drawing.Point(463, 2);
            this.BtnFavorites.Name = "BtnFavorites";
            this.BtnFavorites.Size = new System.Drawing.Size(93, 46);
            this.BtnFavorites.TabIndex = 8;
            this.BtnFavorites.Text = "Favorites";
            this.BtnFavorites.UseVisualStyleBackColor = false;
            this.BtnFavorites.Click += new System.EventHandler(this.BtnFavorites_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.BtnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.BtnHistory.Location = new System.Drawing.Point(370, 2);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(93, 46);
            this.BtnHistory.TabIndex = 10;
            this.BtnHistory.Text = "History";
            this.BtnHistory.UseVisualStyleBackColor = false;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // BtnSetHome
            // 
            this.BtnSetHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.BtnSetHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.BtnSetHome.Location = new System.Drawing.Point(277, 2);
            this.BtnSetHome.Name = "BtnSetHome";
            this.BtnSetHome.Size = new System.Drawing.Size(93, 46);
            this.BtnSetHome.TabIndex = 12;
            this.BtnSetHome.Text = "Set Home";
            this.BtnSetHome.UseVisualStyleBackColor = false;
            this.BtnSetHome.Click += new System.EventHandler(this.BtnSetHome_Click);
            // 
            // PanelBrowserBtn
            // 
            this.PanelBrowserBtn.Controls.Add(this.FavoritesName);
            this.PanelBrowserBtn.Controls.Add(this.BtnFavorites);
            this.PanelBrowserBtn.Controls.Add(this.BtnHistory);
            this.PanelBrowserBtn.Controls.Add(this.BtnSetHome);
            this.PanelBrowserBtn.Controls.Add(this.BtnFavor);
            this.PanelBrowserBtn.Controls.Add(this.BtnReload);
            this.PanelBrowserBtn.Controls.Add(this.BtnHome);
            this.PanelBrowserBtn.Location = new System.Drawing.Point(664, 10);
            this.PanelBrowserBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelBrowserBtn.Name = "PanelBrowserBtn";
            this.PanelBrowserBtn.Size = new System.Drawing.Size(565, 49);
            this.PanelBrowserBtn.TabIndex = 15;
            // 
            // FavoritesName
            // 
            this.FavoritesName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FavoritesName.Location = new System.Drawing.Point(145, 12);
            this.FavoritesName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FavoritesName.Name = "FavoritesName";
            this.FavoritesName.Size = new System.Drawing.Size(122, 31);
            this.FavoritesName.TabIndex = 13;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.Body.ForeColor = System.Drawing.SystemColors.Info;
            this.Body.Location = new System.Drawing.Point(5, 77);
            this.Body.Multiline = true;
            this.Body.Name = "Body";
            this.Body.ReadOnly = true;
            this.Body.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Body.Size = new System.Drawing.Size(1228, 426);
            this.Body.TabIndex = 3;
            // 
            // ListFavorites
            // 
            this.ListFavorites.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ListFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListFavorites.ForeColor = System.Drawing.SystemColors.Info;
            this.ListFavorites.FormattingEnabled = true;
            this.ListFavorites.ItemHeight = 15;
            this.ListFavorites.Location = new System.Drawing.Point(829, 79);
            this.ListFavorites.Name = "ListFavorites";
            this.ListFavorites.Size = new System.Drawing.Size(405, 424);
            this.ListFavorites.TabIndex = 7;
            this.ListFavorites.Visible = false;
            this.ListFavorites.Click += new System.EventHandler(this.ListFavorites_Click);
            // 
            // ListHistory
            // 
            this.ListHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ListHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListHistory.ForeColor = System.Drawing.SystemColors.Info;
            this.ListHistory.FormattingEnabled = true;
            this.ListHistory.ItemHeight = 15;
            this.ListHistory.Location = new System.Drawing.Point(829, 77);
            this.ListHistory.Name = "ListHistory";
            this.ListHistory.Size = new System.Drawing.Size(405, 424);
            this.ListHistory.TabIndex = 9;
            this.ListHistory.Visible = false;
            this.ListHistory.Click += new System.EventHandler(this.ListHistory_Click);
            this.ListHistory.SelectedIndexChanged += new System.EventHandler(this.ListHistory_SelectedIndexChanged);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1240, 504);
            this.Controls.Add(this.PanelBrowserBtn);
            this.Controls.Add(this.ListHistory);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.CheckBulk);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.ListFavorites);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.SearchBar);
            this.Name = "WebBrowser";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.WebBrowser_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WebBrowser_KeyUp);
            this.PanelBrowserBtn.ResumeLayout(false);
            this.PanelBrowserBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.CheckBox CheckBulk;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.Button BtnFavor;
        private System.Windows.Forms.Button BtnFavorites;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button BtnSetHome;
        private System.Windows.Forms.Panel PanelBrowserBtn;
        private System.Windows.Forms.TextBox FavoritesName;
        private System.Windows.Forms.TextBox Body;
        private System.Windows.Forms.ListBox ListFavorites;
        private System.Windows.Forms.ListBox ListHistory;
    }
}

