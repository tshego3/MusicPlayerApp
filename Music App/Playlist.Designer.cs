namespace Music_App
{
    partial class Playlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSongname = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnPaused = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaused)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(15, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lblSongname
            // 
            this.lblSongname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSongname.Location = new System.Drawing.Point(80, 16);
            this.lblSongname.Name = "lblSongname";
            this.lblSongname.Size = new System.Drawing.Size(164, 23);
            this.lblSongname.TabIndex = 1;
            this.lblSongname.Text = "Song Name";
            // 
            // lblArtist
            // 
            this.lblArtist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArtist.Location = new System.Drawing.Point(250, 16);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(177, 23);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "Artist";
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDuration.Location = new System.Drawing.Point(433, 16);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(64, 23);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "00:00";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPaused
            // 
            this.btnPaused.Image = ((System.Drawing.Image)(resources.GetObject("btnPaused.Image")));
            this.btnPaused.ImageActive = null;
            this.btnPaused.Location = new System.Drawing.Point(15, 7);
            this.btnPaused.Name = "btnPaused";
            this.btnPaused.Size = new System.Drawing.Size(32, 32);
            this.btnPaused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPaused.TabIndex = 4;
            this.btnPaused.TabStop = false;
            this.btnPaused.Zoom = 10;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblSongname);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPaused);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(500, 50);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaused)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private System.Windows.Forms.Label lblSongname;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblDuration;
        private Bunifu.Framework.UI.BunifuImageButton btnPaused;
    }
}
