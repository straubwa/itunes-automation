namespace iTunesCOMSample
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.missingAlbum = new System.Windows.Forms.Button();
            this.updateLocation = new System.Windows.Forms.Button();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.removeUnchecked = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.TextBox();
            this.testOnly = new System.Windows.Forms.CheckBox();
            this.listMusicInItunes = new System.Windows.Forms.Button();
            this.listFilesNotInItunes = new System.Windows.Forms.Button();
            this.deleteImageFiles = new System.Windows.Forms.Button();
            this.albumRenameReset = new System.Windows.Forms.Button();
            this.updateMp3Metadata = new System.Windows.Forms.Button();
            this.listMusicWithoutArtwork = new System.Windows.Forms.Button();
            this.listItunesControlledSongs = new System.Windows.Forms.Button();
            this.newRootPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteEmptyFolders = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.legacyRootPath = new System.Windows.Forms.TextBox();
            this.clearStatus = new System.Windows.Forms.Button();
            this.loadItunesTracks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedAlbumImageExist = new System.Windows.Forms.Label();
            this.selectedArtist = new System.Windows.Forms.TextBox();
            this.selectedTrack = new System.Windows.Forms.TextBox();
            this.selectedAlbum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedArtwork = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectedYear = new System.Windows.Forms.TextBox();
            this.saveSelected = new System.Windows.Forms.Button();
            this.selectedTrackNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.starredArtists = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // missingAlbum
            // 
            this.missingAlbum.BackColor = System.Drawing.Color.Firebrick;
            this.missingAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missingAlbum.Font = new System.Drawing.Font("Calibri", 12F);
            this.missingAlbum.ForeColor = System.Drawing.Color.White;
            this.missingAlbum.Location = new System.Drawing.Point(16, 87);
            this.missingAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.missingAlbum.Name = "missingAlbum";
            this.missingAlbum.Size = new System.Drawing.Size(160, 64);
            this.missingAlbum.TabIndex = 0;
            this.missingAlbum.Text = "Find Missing Album.jpg";
            this.missingAlbum.UseVisualStyleBackColor = false;
            this.missingAlbum.Click += new System.EventHandler(this.missingAlbum_Click);
            // 
            // updateLocation
            // 
            this.updateLocation.BackColor = System.Drawing.Color.Firebrick;
            this.updateLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateLocation.Font = new System.Drawing.Font("Calibri", 12F);
            this.updateLocation.ForeColor = System.Drawing.Color.White;
            this.updateLocation.Location = new System.Drawing.Point(16, 16);
            this.updateLocation.Margin = new System.Windows.Forms.Padding(4);
            this.updateLocation.Name = "updateLocation";
            this.updateLocation.Size = new System.Drawing.Size(160, 64);
            this.updateLocation.TabIndex = 2;
            this.updateLocation.Text = "Update Song Location";
            this.updateLocation.UseVisualStyleBackColor = false;
            this.updateLocation.Click += new System.EventHandler(this.updateLocation_Click);
            // 
            // resultsGrid
            // 
            this.resultsGrid.AllowUserToAddRows = false;
            this.resultsGrid.AllowUserToDeleteRows = false;
            this.resultsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.resultsGrid.Location = new System.Drawing.Point(17, 176);
            this.resultsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.ReadOnly = true;
            this.resultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsGrid.Size = new System.Drawing.Size(1317, 471);
            this.resultsGrid.TabIndex = 3;
            this.resultsGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resultsGrid_MouseClick);
            this.resultsGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultsGrid_MouseDoubleClick);
            // 
            // removeUnchecked
            // 
            this.removeUnchecked.BackColor = System.Drawing.Color.Firebrick;
            this.removeUnchecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUnchecked.Font = new System.Drawing.Font("Calibri", 12F);
            this.removeUnchecked.ForeColor = System.Drawing.Color.White;
            this.removeUnchecked.Location = new System.Drawing.Point(184, 16);
            this.removeUnchecked.Margin = new System.Windows.Forms.Padding(4);
            this.removeUnchecked.Name = "removeUnchecked";
            this.removeUnchecked.Size = new System.Drawing.Size(160, 64);
            this.removeUnchecked.TabIndex = 4;
            this.removeUnchecked.Text = "Remove Unchecked";
            this.removeUnchecked.UseVisualStyleBackColor = false;
            this.removeUnchecked.Click += new System.EventHandler(this.removeUnchecked_Click);
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.status.Location = new System.Drawing.Point(17, 655);
            this.status.Margin = new System.Windows.Forms.Padding(4);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.status.Size = new System.Drawing.Size(703, 158);
            this.status.TabIndex = 5;
            // 
            // testOnly
            // 
            this.testOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testOnly.AutoSize = true;
            this.testOnly.Checked = true;
            this.testOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.testOnly.Location = new System.Drawing.Point(1244, 16);
            this.testOnly.Margin = new System.Windows.Forms.Padding(4);
            this.testOnly.Name = "testOnly";
            this.testOnly.Size = new System.Drawing.Size(91, 21);
            this.testOnly.TabIndex = 6;
            this.testOnly.Text = "Test Only";
            this.testOnly.UseVisualStyleBackColor = true;
            // 
            // listMusicInItunes
            // 
            this.listMusicInItunes.BackColor = System.Drawing.Color.Firebrick;
            this.listMusicInItunes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listMusicInItunes.Font = new System.Drawing.Font("Calibri", 12F);
            this.listMusicInItunes.ForeColor = System.Drawing.Color.White;
            this.listMusicInItunes.Location = new System.Drawing.Point(184, 87);
            this.listMusicInItunes.Margin = new System.Windows.Forms.Padding(4);
            this.listMusicInItunes.Name = "listMusicInItunes";
            this.listMusicInItunes.Size = new System.Drawing.Size(160, 64);
            this.listMusicInItunes.TabIndex = 7;
            this.listMusicInItunes.Text = "List Music in iTunes";
            this.listMusicInItunes.UseVisualStyleBackColor = false;
            this.listMusicInItunes.Click += new System.EventHandler(this.listMusicInItunes_Click);
            // 
            // listFilesNotInItunes
            // 
            this.listFilesNotInItunes.BackColor = System.Drawing.Color.Firebrick;
            this.listFilesNotInItunes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listFilesNotInItunes.Font = new System.Drawing.Font("Calibri", 12F);
            this.listFilesNotInItunes.ForeColor = System.Drawing.Color.White;
            this.listFilesNotInItunes.Location = new System.Drawing.Point(352, 87);
            this.listFilesNotInItunes.Margin = new System.Windows.Forms.Padding(4);
            this.listFilesNotInItunes.Name = "listFilesNotInItunes";
            this.listFilesNotInItunes.Size = new System.Drawing.Size(160, 64);
            this.listFilesNotInItunes.TabIndex = 8;
            this.listFilesNotInItunes.Text = "List Files not in iTunes";
            this.listFilesNotInItunes.UseVisualStyleBackColor = false;
            this.listFilesNotInItunes.Click += new System.EventHandler(this.listFilesNotInItunes_Click);
            // 
            // deleteImageFiles
            // 
            this.deleteImageFiles.BackColor = System.Drawing.Color.Firebrick;
            this.deleteImageFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteImageFiles.Font = new System.Drawing.Font("Calibri", 12F);
            this.deleteImageFiles.ForeColor = System.Drawing.Color.White;
            this.deleteImageFiles.Location = new System.Drawing.Point(352, 16);
            this.deleteImageFiles.Margin = new System.Windows.Forms.Padding(4);
            this.deleteImageFiles.Name = "deleteImageFiles";
            this.deleteImageFiles.Size = new System.Drawing.Size(160, 64);
            this.deleteImageFiles.TabIndex = 9;
            this.deleteImageFiles.Text = "Delete Image Files";
            this.deleteImageFiles.UseVisualStyleBackColor = false;
            this.deleteImageFiles.Click += new System.EventHandler(this.deleteImageFiles_Click);
            // 
            // albumRenameReset
            // 
            this.albumRenameReset.BackColor = System.Drawing.Color.Firebrick;
            this.albumRenameReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumRenameReset.Font = new System.Drawing.Font("Calibri", 12F);
            this.albumRenameReset.ForeColor = System.Drawing.Color.White;
            this.albumRenameReset.Location = new System.Drawing.Point(520, 16);
            this.albumRenameReset.Margin = new System.Windows.Forms.Padding(4);
            this.albumRenameReset.Name = "albumRenameReset";
            this.albumRenameReset.Size = new System.Drawing.Size(160, 64);
            this.albumRenameReset.TabIndex = 10;
            this.albumRenameReset.Text = "Album Rename Reset";
            this.albumRenameReset.UseVisualStyleBackColor = false;
            this.albumRenameReset.Click += new System.EventHandler(this.albumRenameReset_Click);
            // 
            // updateMp3Metadata
            // 
            this.updateMp3Metadata.BackColor = System.Drawing.Color.Firebrick;
            this.updateMp3Metadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMp3Metadata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMp3Metadata.ForeColor = System.Drawing.Color.White;
            this.updateMp3Metadata.Location = new System.Drawing.Point(688, 16);
            this.updateMp3Metadata.Margin = new System.Windows.Forms.Padding(4);
            this.updateMp3Metadata.Name = "updateMp3Metadata";
            this.updateMp3Metadata.Size = new System.Drawing.Size(160, 64);
            this.updateMp3Metadata.TabIndex = 11;
            this.updateMp3Metadata.Text = "Update MP3 Meta-Data";
            this.updateMp3Metadata.UseVisualStyleBackColor = false;
            this.updateMp3Metadata.Click += new System.EventHandler(this.updateMp3Metadata_Click);
            // 
            // listMusicWithoutArtwork
            // 
            this.listMusicWithoutArtwork.BackColor = System.Drawing.Color.Firebrick;
            this.listMusicWithoutArtwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listMusicWithoutArtwork.Font = new System.Drawing.Font("Calibri", 12F);
            this.listMusicWithoutArtwork.ForeColor = System.Drawing.Color.White;
            this.listMusicWithoutArtwork.Location = new System.Drawing.Point(520, 87);
            this.listMusicWithoutArtwork.Margin = new System.Windows.Forms.Padding(4);
            this.listMusicWithoutArtwork.Name = "listMusicWithoutArtwork";
            this.listMusicWithoutArtwork.Size = new System.Drawing.Size(160, 64);
            this.listMusicWithoutArtwork.TabIndex = 12;
            this.listMusicWithoutArtwork.Text = "List Music w/o Artwork";
            this.listMusicWithoutArtwork.UseVisualStyleBackColor = false;
            this.listMusicWithoutArtwork.Click += new System.EventHandler(this.listMusicWithoutArtwork_Click);
            // 
            // listItunesControlledSongs
            // 
            this.listItunesControlledSongs.BackColor = System.Drawing.Color.Firebrick;
            this.listItunesControlledSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listItunesControlledSongs.Font = new System.Drawing.Font("Calibri", 12F);
            this.listItunesControlledSongs.ForeColor = System.Drawing.Color.White;
            this.listItunesControlledSongs.Location = new System.Drawing.Point(688, 87);
            this.listItunesControlledSongs.Margin = new System.Windows.Forms.Padding(4);
            this.listItunesControlledSongs.Name = "listItunesControlledSongs";
            this.listItunesControlledSongs.Size = new System.Drawing.Size(160, 64);
            this.listItunesControlledSongs.TabIndex = 13;
            this.listItunesControlledSongs.Text = "List iTunes Legacy Root";
            this.listItunesControlledSongs.UseVisualStyleBackColor = false;
            this.listItunesControlledSongs.Click += new System.EventHandler(this.listItunesControlledSongs_Click);
            // 
            // newRootPath
            // 
            this.newRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newRootPath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRootPath.Location = new System.Drawing.Point(819, 827);
            this.newRootPath.Margin = new System.Windows.Forms.Padding(4);
            this.newRootPath.Name = "newRootPath";
            this.newRootPath.Size = new System.Drawing.Size(296, 27);
            this.newRootPath.TabIndex = 14;
            this.newRootPath.Text = "D:\\Music\\Artists";
            this.newRootPath.TextChanged += new System.EventHandler(this.newRootPath_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 831);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Preferred Root Path";
            // 
            // deleteEmptyFolders
            // 
            this.deleteEmptyFolders.BackColor = System.Drawing.Color.Firebrick;
            this.deleteEmptyFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmptyFolders.Font = new System.Drawing.Font("Calibri", 12F);
            this.deleteEmptyFolders.ForeColor = System.Drawing.Color.White;
            this.deleteEmptyFolders.Location = new System.Drawing.Point(856, 15);
            this.deleteEmptyFolders.Margin = new System.Windows.Forms.Padding(4);
            this.deleteEmptyFolders.Name = "deleteEmptyFolders";
            this.deleteEmptyFolders.Size = new System.Drawing.Size(160, 64);
            this.deleteEmptyFolders.TabIndex = 16;
            this.deleteEmptyFolders.Text = "Delete Empty Folders";
            this.deleteEmptyFolders.UseVisualStyleBackColor = false;
            this.deleteEmptyFolders.Click += new System.EventHandler(this.deleteEmptyFolders_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 831);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Legacy Root Path";
            // 
            // legacyRootPath
            // 
            this.legacyRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.legacyRootPath.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.legacyRootPath.Location = new System.Drawing.Point(145, 827);
            this.legacyRootPath.Margin = new System.Windows.Forms.Padding(4);
            this.legacyRootPath.Name = "legacyRootPath";
            this.legacyRootPath.Size = new System.Drawing.Size(340, 27);
            this.legacyRootPath.TabIndex = 18;
            this.legacyRootPath.Text = "D:\\Music\\iTunes\\iTunes Media\\Music\\";
            this.legacyRootPath.TextChanged += new System.EventHandler(this.legacyRootPath_TextChanged);
            // 
            // clearStatus
            // 
            this.clearStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.clearStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearStatus.Font = new System.Drawing.Font("Calibri", 10F);
            this.clearStatus.ForeColor = System.Drawing.Color.Black;
            this.clearStatus.Location = new System.Drawing.Point(495, 821);
            this.clearStatus.Margin = new System.Windows.Forms.Padding(4);
            this.clearStatus.Name = "clearStatus";
            this.clearStatus.Size = new System.Drawing.Size(163, 37);
            this.clearStatus.TabIndex = 19;
            this.clearStatus.Text = "Clear Status";
            this.clearStatus.UseVisualStyleBackColor = false;
            this.clearStatus.Click += new System.EventHandler(this.clearStatus_Click);
            // 
            // loadItunesTracks
            // 
            this.loadItunesTracks.BackColor = System.Drawing.Color.Firebrick;
            this.loadItunesTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadItunesTracks.Font = new System.Drawing.Font("Calibri", 12F);
            this.loadItunesTracks.ForeColor = System.Drawing.Color.White;
            this.loadItunesTracks.Location = new System.Drawing.Point(856, 86);
            this.loadItunesTracks.Margin = new System.Windows.Forms.Padding(4);
            this.loadItunesTracks.Name = "loadItunesTracks";
            this.loadItunesTracks.Size = new System.Drawing.Size(160, 64);
            this.loadItunesTracks.TabIndex = 20;
            this.loadItunesTracks.Text = "Reload ItunesTracks";
            this.loadItunesTracks.UseVisualStyleBackColor = false;
            this.loadItunesTracks.Click += new System.EventHandler(this.loadItunesTracks_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label3.Location = new System.Drawing.Point(732, 658);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Artist";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label4.Location = new System.Drawing.Point(732, 692);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Track";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label5.Location = new System.Drawing.Point(732, 725);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Album";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label6.Location = new System.Drawing.Point(969, 789);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Album.jpg Exist?";
            // 
            // selectedAlbumImageExist
            // 
            this.selectedAlbumImageExist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedAlbumImageExist.AutoSize = true;
            this.selectedAlbumImageExist.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.selectedAlbumImageExist.Location = new System.Drawing.Point(1112, 789);
            this.selectedAlbumImageExist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedAlbumImageExist.Name = "selectedAlbumImageExist";
            this.selectedAlbumImageExist.Size = new System.Drawing.Size(34, 21);
            this.selectedAlbumImageExist.TabIndex = 25;
            this.selectedAlbumImageExist.Text = "n/a";
            // 
            // selectedArtist
            // 
            this.selectedArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedArtist.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedArtist.Location = new System.Drawing.Point(873, 655);
            this.selectedArtist.Margin = new System.Windows.Forms.Padding(4);
            this.selectedArtist.Name = "selectedArtist";
            this.selectedArtist.Size = new System.Drawing.Size(385, 27);
            this.selectedArtist.TabIndex = 26;
            // 
            // selectedTrack
            // 
            this.selectedTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTrack.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTrack.Location = new System.Drawing.Point(873, 688);
            this.selectedTrack.Margin = new System.Windows.Forms.Padding(4);
            this.selectedTrack.Name = "selectedTrack";
            this.selectedTrack.Size = new System.Drawing.Size(385, 27);
            this.selectedTrack.TabIndex = 27;
            // 
            // selectedAlbum
            // 
            this.selectedAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedAlbum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedAlbum.Location = new System.Drawing.Point(873, 721);
            this.selectedAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.selectedAlbum.Name = "selectedAlbum";
            this.selectedAlbum.Size = new System.Drawing.Size(385, 27);
            this.selectedAlbum.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label7.Location = new System.Drawing.Point(732, 789);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Artwork";
            // 
            // selectedArtwork
            // 
            this.selectedArtwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedArtwork.AutoSize = true;
            this.selectedArtwork.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.selectedArtwork.Location = new System.Drawing.Point(869, 789);
            this.selectedArtwork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedArtwork.Name = "selectedArtwork";
            this.selectedArtwork.Size = new System.Drawing.Size(34, 21);
            this.selectedArtwork.TabIndex = 30;
            this.selectedArtwork.Text = "n/a";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label8.Location = new System.Drawing.Point(732, 757);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Year";
            // 
            // selectedYear
            // 
            this.selectedYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedYear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedYear.Location = new System.Drawing.Point(873, 753);
            this.selectedYear.Margin = new System.Windows.Forms.Padding(4);
            this.selectedYear.Name = "selectedYear";
            this.selectedYear.Size = new System.Drawing.Size(79, 27);
            this.selectedYear.TabIndex = 32;
            // 
            // saveSelected
            // 
            this.saveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSelected.BackColor = System.Drawing.Color.Gainsboro;
            this.saveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSelected.Font = new System.Drawing.Font("Calibri", 10F);
            this.saveSelected.ForeColor = System.Drawing.Color.Black;
            this.saveSelected.Location = new System.Drawing.Point(1151, 821);
            this.saveSelected.Margin = new System.Windows.Forms.Padding(4);
            this.saveSelected.Name = "saveSelected";
            this.saveSelected.Size = new System.Drawing.Size(184, 37);
            this.saveSelected.TabIndex = 33;
            this.saveSelected.Text = "Save Changes";
            this.saveSelected.UseVisualStyleBackColor = false;
            this.saveSelected.Click += new System.EventHandler(this.saveSelected_Click);
            // 
            // selectedTrackNumber
            // 
            this.selectedTrackNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTrackNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTrackNumber.Location = new System.Drawing.Point(1116, 753);
            this.selectedTrackNumber.Margin = new System.Windows.Forms.Padding(4);
            this.selectedTrackNumber.Name = "selectedTrackNumber";
            this.selectedTrackNumber.Size = new System.Drawing.Size(79, 27);
            this.selectedTrackNumber.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label9.Location = new System.Drawing.Point(969, 757);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Track Number";
            // 
            // starredArtists
            // 
            this.starredArtists.BackColor = System.Drawing.Color.Firebrick;
            this.starredArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.starredArtists.Font = new System.Drawing.Font("Calibri", 12F);
            this.starredArtists.ForeColor = System.Drawing.Color.White;
            this.starredArtists.Location = new System.Drawing.Point(1024, 86);
            this.starredArtists.Margin = new System.Windows.Forms.Padding(4);
            this.starredArtists.Name = "starredArtists";
            this.starredArtists.Size = new System.Drawing.Size(160, 64);
            this.starredArtists.TabIndex = 36;
            this.starredArtists.Text = "5 star artists";
            this.starredArtists.UseVisualStyleBackColor = false;
            this.starredArtists.Click += new System.EventHandler(this.starredArtists_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 860);
            this.Controls.Add(this.starredArtists);
            this.Controls.Add(this.selectedTrackNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.saveSelected);
            this.Controls.Add(this.selectedYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectedArtwork);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedAlbum);
            this.Controls.Add(this.selectedTrack);
            this.Controls.Add(this.selectedArtist);
            this.Controls.Add(this.selectedAlbumImageExist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadItunesTracks);
            this.Controls.Add(this.clearStatus);
            this.Controls.Add(this.legacyRootPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteEmptyFolders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newRootPath);
            this.Controls.Add(this.listItunesControlledSongs);
            this.Controls.Add(this.listMusicWithoutArtwork);
            this.Controls.Add(this.updateMp3Metadata);
            this.Controls.Add(this.albumRenameReset);
            this.Controls.Add(this.deleteImageFiles);
            this.Controls.Add(this.listFilesNotInItunes);
            this.Controls.Add(this.listMusicInItunes);
            this.Controls.Add(this.testOnly);
            this.Controls.Add(this.status);
            this.Controls.Add(this.removeUnchecked);
            this.Controls.Add(this.resultsGrid);
            this.Controls.Add(this.updateLocation);
            this.Controls.Add(this.missingAlbum);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Music Admin";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button missingAlbum;
        private System.Windows.Forms.Button updateLocation;
        private System.Windows.Forms.DataGridView resultsGrid;
        private System.Windows.Forms.Button removeUnchecked;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.CheckBox testOnly;
        private System.Windows.Forms.Button listMusicInItunes;
        private System.Windows.Forms.Button listFilesNotInItunes;
        private System.Windows.Forms.Button deleteImageFiles;
        private System.Windows.Forms.Button albumRenameReset;
        private System.Windows.Forms.Button updateMp3Metadata;
        private System.Windows.Forms.Button listMusicWithoutArtwork;
        private System.Windows.Forms.Button listItunesControlledSongs;
        private System.Windows.Forms.TextBox newRootPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteEmptyFolders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox legacyRootPath;
        private System.Windows.Forms.Button clearStatus;
        private System.Windows.Forms.Button loadItunesTracks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label selectedAlbumImageExist;
        private System.Windows.Forms.TextBox selectedArtist;
        private System.Windows.Forms.TextBox selectedTrack;
        private System.Windows.Forms.TextBox selectedAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label selectedArtwork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox selectedYear;
        private System.Windows.Forms.Button saveSelected;
        private System.Windows.Forms.TextBox selectedTrackNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button starredArtists;
    }
}