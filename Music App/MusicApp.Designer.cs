namespace Music_App
{
    partial class MusicApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAction = new Bunifu.Framework.UI.BunifuImageButton();
            this.volume = new MetroFramework.Controls.MetroTrackBar();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.lblDuration = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTimer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblArtist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSongname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblVolume = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnActionPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNowPlaying = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrowseSongs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSongs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnmax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnexit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActionPause)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.volume);
            this.panel1.Controls.Add(this.thumbnail);
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblArtist);
            this.panel1.Controls.Add(this.lblSongname);
            this.panel1.Controls.Add(this.btnRepeat);
            this.panel1.Controls.Add(this.btnShuffle);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.bunifuProgressBar1);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnActionPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 73);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAction.Image = ((System.Drawing.Image)(resources.GetObject("btnAction.Image")));
            this.btnAction.ImageActive = null;
            this.btnAction.Location = new System.Drawing.Point(465, 16);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(32, 32);
            this.btnAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAction.TabIndex = 15;
            this.btnAction.TabStop = false;
            this.btnAction.Zoom = 10;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.CustomBackground = true;
            this.volume.Location = new System.Drawing.Point(760, 19);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(182, 23);
            this.volume.TabIndex = 0;
            this.volume.Text = "metroTrackBar1";
            this.volume.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volume.Value = 100;
            this.volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Volume_Scroll);
            // 
            // thumbnail
            // 
            this.thumbnail.Location = new System.Drawing.Point(12, 6);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(32, 32);
            this.thumbnail.TabIndex = 9;
            this.thumbnail.TabStop = false;
            this.thumbnail.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDuration.Location = new System.Drawing.Point(902, 45);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(40, 17);
            this.lblDuration.TabIndex = 13;
            this.lblDuration.Text = "00:00";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimer.Location = new System.Drawing.Point(9, 45);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(40, 17);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "00:00";
            this.lblTimer.Click += new System.EventHandler(this.BunifuCustomLabel4_Click);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.White;
            this.lblArtist.Location = new System.Drawing.Point(50, 30);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(41, 16);
            this.lblArtist.TabIndex = 10;
            this.lblArtist.Text = "Artist";
            // 
            // lblSongname
            // 
            this.lblSongname.AutoSize = true;
            this.lblSongname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongname.ForeColor = System.Drawing.Color.White;
            this.lblSongname.Location = new System.Drawing.Point(50, 6);
            this.lblSongname.Name = "lblSongname";
            this.lblSongname.Size = new System.Drawing.Size(84, 17);
            this.lblSongname.TabIndex = 9;
            this.lblSongname.Text = "Song Name";
            // 
            // btnRepeat
            // 
            this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRepeat.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeat.Image")));
            this.btnRepeat.ImageActive = null;
            this.btnRepeat.Location = new System.Drawing.Point(550, 20);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(24, 24);
            this.btnRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnRepeat.TabIndex = 5;
            this.btnRepeat.TabStop = false;
            this.btnRepeat.Zoom = 10;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.ImageActive = null;
            this.btnShuffle.Location = new System.Drawing.Point(388, 20);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(24, 24);
            this.btnShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnShuffle.TabIndex = 8;
            this.btnShuffle.TabStop = false;
            this.btnShuffle.Zoom = 10;
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolume.Image = ((System.Drawing.Image)(resources.GetObject("lblVolume.Image")));
            this.lblVolume.ImageActive = null;
            this.lblVolume.Location = new System.Drawing.Point(730, 20);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(24, 24);
            this.lblVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblVolume.TabIndex = 6;
            this.lblVolume.TabStop = false;
            this.lblVolume.Zoom = 10;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.Location = new System.Drawing.Point(427, 16);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(32, 32);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Zoom = 10;
            this.btnPrevious.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(503, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 32);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnNext.TabIndex = 5;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 10;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(0, 65);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.OrangeRed;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(965, 5);
            this.bunifuProgressBar1.TabIndex = 2;
            this.bunifuProgressBar1.Value = 0;
            this.bunifuProgressBar1.progressChanged += new System.EventHandler(this.BunifuProgressBar1_progressChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(503, 16);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPlay.TabIndex = 3;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageActive = null;
            this.btnPause.Location = new System.Drawing.Point(427, 16);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(32, 32);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPause.TabIndex = 14;
            this.btnPause.TabStop = false;
            this.btnPause.Zoom = 10;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnActionPause
            // 
            this.btnActionPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnActionPause.Image = ((System.Drawing.Image)(resources.GetObject("btnActionPause.Image")));
            this.btnActionPause.ImageActive = null;
            this.btnActionPause.Location = new System.Drawing.Point(465, 16);
            this.btnActionPause.Name = "btnActionPause";
            this.btnActionPause.Size = new System.Drawing.Size(32, 32);
            this.btnActionPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnActionPause.TabIndex = 15;
            this.btnActionPause.TabStop = false;
            this.btnActionPause.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnNowPlaying);
            this.panel2.Controls.Add(this.btnBrowseSongs);
            this.panel2.Controls.Add(this.btnSongs);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 508);
            this.panel2.TabIndex = 1;
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.Active = false;
            this.btnNowPlaying.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNowPlaying.BackColor = System.Drawing.Color.Black;
            this.btnNowPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNowPlaying.BorderRadius = 0;
            this.btnNowPlaying.ButtonText = "  Now Playing";
            this.btnNowPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNowPlaying.DisabledColor = System.Drawing.Color.Gray;
            this.btnNowPlaying.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNowPlaying.Iconimage")));
            this.btnNowPlaying.Iconimage_right = null;
            this.btnNowPlaying.Iconimage_right_Selected = null;
            this.btnNowPlaying.Iconimage_Selected = null;
            this.btnNowPlaying.IconMarginLeft = 0;
            this.btnNowPlaying.IconMarginRight = 0;
            this.btnNowPlaying.IconRightVisible = true;
            this.btnNowPlaying.IconRightZoom = 0D;
            this.btnNowPlaying.IconVisible = true;
            this.btnNowPlaying.IconZoom = 60D;
            this.btnNowPlaying.IsTab = false;
            this.btnNowPlaying.Location = new System.Drawing.Point(0, 138);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.Normalcolor = System.Drawing.Color.Black;
            this.btnNowPlaying.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNowPlaying.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNowPlaying.selected = false;
            this.btnNowPlaying.Size = new System.Drawing.Size(239, 48);
            this.btnNowPlaying.TabIndex = 8;
            this.btnNowPlaying.Text = "  Now Playing";
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowPlaying.Textcolor = System.Drawing.Color.White;
            this.btnNowPlaying.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNowPlaying.Click += new System.EventHandler(this.BunifuFlatButton3_Click);
            // 
            // btnBrowseSongs
            // 
            this.btnBrowseSongs.Active = false;
            this.btnBrowseSongs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBrowseSongs.BackColor = System.Drawing.Color.Black;
            this.btnBrowseSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseSongs.BorderRadius = 0;
            this.btnBrowseSongs.ButtonText = "  Browse Songs";
            this.btnBrowseSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseSongs.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseSongs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowseSongs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBrowseSongs.Iconimage")));
            this.btnBrowseSongs.Iconimage_right = null;
            this.btnBrowseSongs.Iconimage_right_Selected = null;
            this.btnBrowseSongs.Iconimage_Selected = null;
            this.btnBrowseSongs.IconMarginLeft = 0;
            this.btnBrowseSongs.IconMarginRight = 0;
            this.btnBrowseSongs.IconRightVisible = true;
            this.btnBrowseSongs.IconRightZoom = 0D;
            this.btnBrowseSongs.IconVisible = true;
            this.btnBrowseSongs.IconZoom = 60D;
            this.btnBrowseSongs.IsTab = false;
            this.btnBrowseSongs.Location = new System.Drawing.Point(0, 246);
            this.btnBrowseSongs.Name = "btnBrowseSongs";
            this.btnBrowseSongs.Normalcolor = System.Drawing.Color.Black;
            this.btnBrowseSongs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowseSongs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseSongs.selected = false;
            this.btnBrowseSongs.Size = new System.Drawing.Size(239, 48);
            this.btnBrowseSongs.TabIndex = 7;
            this.btnBrowseSongs.Text = "  Browse Songs";
            this.btnBrowseSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseSongs.Textcolor = System.Drawing.Color.White;
            this.btnBrowseSongs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSongs.Click += new System.EventHandler(this.BtnArtists_Click);
            // 
            // btnSongs
            // 
            this.btnSongs.Active = false;
            this.btnSongs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSongs.BackColor = System.Drawing.Color.Black;
            this.btnSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSongs.BorderRadius = 0;
            this.btnSongs.ButtonText = "  My Songs";
            this.btnSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSongs.DisabledColor = System.Drawing.Color.Gray;
            this.btnSongs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSongs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSongs.Iconimage")));
            this.btnSongs.Iconimage_right = null;
            this.btnSongs.Iconimage_right_Selected = null;
            this.btnSongs.Iconimage_Selected = null;
            this.btnSongs.IconMarginLeft = 0;
            this.btnSongs.IconMarginRight = 0;
            this.btnSongs.IconRightVisible = true;
            this.btnSongs.IconRightZoom = 0D;
            this.btnSongs.IconVisible = true;
            this.btnSongs.IconZoom = 60D;
            this.btnSongs.IsTab = false;
            this.btnSongs.Location = new System.Drawing.Point(0, 192);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Normalcolor = System.Drawing.Color.Black;
            this.btnSongs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSongs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSongs.selected = false;
            this.btnSongs.Size = new System.Drawing.Size(239, 48);
            this.btnSongs.TabIndex = 6;
            this.btnSongs.Text = "  My Songs";
            this.btnSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.Textcolor = System.Drawing.Color.White;
            this.btnSongs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.Click += new System.EventHandler(this.BtSongs_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 30);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Music";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(40, 50);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(116, 35);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BackColor = System.Drawing.Color.Transparent;
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.ImageActive = null;
            this.btnmax.Location = new System.Drawing.Point(883, 3);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(32, 32);
            this.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnmax.TabIndex = 0;
            this.btnmax.TabStop = false;
            this.btnmax.Zoom = 10;
            this.btnmax.Click += new System.EventHandler(this.BunifuImageButton9_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.ImageActive = null;
            this.btnmin.Location = new System.Drawing.Point(845, 3);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(32, 32);
            this.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnmin.TabIndex = 1;
            this.btnmin.TabStop = false;
            this.btnmin.Zoom = 10;
            this.btnmin.Click += new System.EventHandler(this.BunifuImageButton10_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageActive = null;
            this.btnexit.Location = new System.Drawing.Point(921, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(32, 32);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnexit.TabIndex = 2;
            this.btnexit.TabStop = false;
            this.btnexit.Zoom = 10;
            this.btnexit.Click += new System.EventHandler(this.BunifuImageButton8_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel4;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.btnmin);
            this.panel4.Controls.Add(this.btnexit);
            this.panel4.Controls.Add(this.btnmax);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 42);
            this.panel4.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.DarkGray;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(236, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(726, 517);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(236, 40);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(729, 510);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.AxWindowsMediaPlayer1_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MusicApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(965, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActionPause)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPrevious;
        private Bunifu.Framework.UI.BunifuImageButton btnRepeat;
        private Bunifu.Framework.UI.BunifuImageButton btnShuffle;
        private Bunifu.Framework.UI.BunifuImageButton lblVolume;
        private Bunifu.Framework.UI.BunifuFlatButton btnSongs;
        private Bunifu.Framework.UI.BunifuFlatButton btnNowPlaying;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseSongs;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArtist;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSongname;
        private Bunifu.Framework.UI.BunifuImageButton btnexit;
        private Bunifu.Framework.UI.BunifuImageButton btnmin;
        private Bunifu.Framework.UI.BunifuImageButton btnmax;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDuration;
        private Bunifu.Framework.UI.BunifuImageButton btnPause;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroTrackBar volume;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuImageButton btnAction;
        private Bunifu.Framework.UI.BunifuImageButton btnActionPause;
        private System.Windows.Forms.Timer timer1;
    }
}

