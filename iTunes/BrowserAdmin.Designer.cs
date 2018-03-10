namespace iTunesCOMSample
{
    partial class BrowserAdmin
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
            this.explorerBrowser = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser();
            this.startMissingAlbum = new System.Windows.Forms.Button();
            this.nextMissingAlbum = new System.Windows.Forms.Button();
            this.renameDraggedFile = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.TextBox();
            this.updateFileMetadata = new System.Windows.Forms.Button();
            this.updateItunes = new System.Windows.Forms.CheckBox();
            this.startMissingFiveStar = new System.Windows.Forms.Button();
            this.startRecent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // explorerBrowser
            // 
            this.explorerBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explorerBrowser.Location = new System.Drawing.Point(12, 67);
            this.explorerBrowser.Name = "explorerBrowser";
            this.explorerBrowser.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            this.explorerBrowser.Size = new System.Drawing.Size(746, 521);
            this.explorerBrowser.TabIndex = 0;
            this.explorerBrowser.SelectionChanged += new System.EventHandler(this.explorerBrowser_SelectionChanged);
            // 
            // startMissingAlbum
            // 
            this.startMissingAlbum.BackColor = System.Drawing.Color.Firebrick;
            this.startMissingAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMissingAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.startMissingAlbum.ForeColor = System.Drawing.Color.White;
            this.startMissingAlbum.Location = new System.Drawing.Point(13, 12);
            this.startMissingAlbum.Name = "startMissingAlbum";
            this.startMissingAlbum.Size = new System.Drawing.Size(110, 48);
            this.startMissingAlbum.TabIndex = 1;
            this.startMissingAlbum.Text = "All Missing Album.jpg";
            this.startMissingAlbum.UseVisualStyleBackColor = false;
            this.startMissingAlbum.Click += new System.EventHandler(this.startMissingAlbum_Click);
            // 
            // nextMissingAlbum
            // 
            this.nextMissingAlbum.BackColor = System.Drawing.Color.Firebrick;
            this.nextMissingAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextMissingAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nextMissingAlbum.ForeColor = System.Drawing.Color.White;
            this.nextMissingAlbum.Location = new System.Drawing.Point(393, 12);
            this.nextMissingAlbum.Name = "nextMissingAlbum";
            this.nextMissingAlbum.Size = new System.Drawing.Size(112, 48);
            this.nextMissingAlbum.TabIndex = 2;
            this.nextMissingAlbum.Text = "Next Missing Album.jpg";
            this.nextMissingAlbum.UseVisualStyleBackColor = false;
            this.nextMissingAlbum.Click += new System.EventHandler(this.nextMissingAlbum_Click);
            // 
            // renameDraggedFile
            // 
            this.renameDraggedFile.AutoSize = true;
            this.renameDraggedFile.Location = new System.Drawing.Point(629, 44);
            this.renameDraggedFile.Name = "renameDraggedFile";
            this.renameDraggedFile.Size = new System.Drawing.Size(129, 17);
            this.renameDraggedFile.TabIndex = 3;
            this.renameDraggedFile.Text = "Rename Dragged File";
            this.renameDraggedFile.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Location = new System.Drawing.Point(13, 596);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(745, 20);
            this.status.TabIndex = 4;
            // 
            // updateFileMetadata
            // 
            this.updateFileMetadata.BackColor = System.Drawing.Color.Firebrick;
            this.updateFileMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateFileMetadata.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updateFileMetadata.ForeColor = System.Drawing.Color.White;
            this.updateFileMetadata.Location = new System.Drawing.Point(511, 12);
            this.updateFileMetadata.Name = "updateFileMetadata";
            this.updateFileMetadata.Size = new System.Drawing.Size(112, 48);
            this.updateFileMetadata.TabIndex = 5;
            this.updateFileMetadata.Text = "Update File(s) Metadata";
            this.updateFileMetadata.UseVisualStyleBackColor = false;
            this.updateFileMetadata.Click += new System.EventHandler(this.updateFileMetadata_Click);
            // 
            // updateItunes
            // 
            this.updateItunes.AutoSize = true;
            this.updateItunes.Location = new System.Drawing.Point(629, 12);
            this.updateItunes.Name = "updateItunes";
            this.updateItunes.Size = new System.Drawing.Size(96, 17);
            this.updateItunes.TabIndex = 6;
            this.updateItunes.Text = "Update iTunes";
            this.updateItunes.UseVisualStyleBackColor = true;
            // 
            // startMissingFiveStar
            // 
            this.startMissingFiveStar.BackColor = System.Drawing.Color.Firebrick;
            this.startMissingFiveStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMissingFiveStar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.startMissingFiveStar.ForeColor = System.Drawing.Color.White;
            this.startMissingFiveStar.Location = new System.Drawing.Point(129, 12);
            this.startMissingFiveStar.Name = "startMissingFiveStar";
            this.startMissingFiveStar.Size = new System.Drawing.Size(120, 48);
            this.startMissingFiveStar.TabIndex = 7;
            this.startMissingFiveStar.Text = "Missing 3+ Star Album.jpg";
            this.startMissingFiveStar.UseVisualStyleBackColor = false;
            this.startMissingFiveStar.Click += new System.EventHandler(this.startMissingFiveStar_Click);
            // 
            // startRecent
            // 
            this.startRecent.BackColor = System.Drawing.Color.Firebrick;
            this.startRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startRecent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.startRecent.ForeColor = System.Drawing.Color.White;
            this.startRecent.Location = new System.Drawing.Point(255, 12);
            this.startRecent.Name = "startRecent";
            this.startRecent.Size = new System.Drawing.Size(132, 48);
            this.startRecent.TabIndex = 8;
            this.startRecent.Text = "Recently Added Missing Album.jpg";
            this.startRecent.UseVisualStyleBackColor = false;
            this.startRecent.Click += new System.EventHandler(this.startRecent_Click);
            // 
            // BrowserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 628);
            this.Controls.Add(this.startRecent);
            this.Controls.Add(this.startMissingFiveStar);
            this.Controls.Add(this.updateItunes);
            this.Controls.Add(this.updateFileMetadata);
            this.Controls.Add(this.status);
            this.Controls.Add(this.renameDraggedFile);
            this.Controls.Add(this.nextMissingAlbum);
            this.Controls.Add(this.startMissingAlbum);
            this.Controls.Add(this.explorerBrowser);
            this.Name = "BrowserAdmin";
            this.Text = "BrowserAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser explorerBrowser;
        private System.Windows.Forms.Button startMissingAlbum;
        private System.Windows.Forms.Button nextMissingAlbum;
        private System.Windows.Forms.CheckBox renameDraggedFile;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button updateFileMetadata;
        private System.Windows.Forms.CheckBox updateItunes;
        private System.Windows.Forms.Button startMissingFiveStar;
        private System.Windows.Forms.Button startRecent;
    }
}