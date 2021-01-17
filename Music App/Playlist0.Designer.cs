namespace Music_App
{
    partial class Playlist0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist0));
            this.lblsongname = new System.Windows.Forms.Label();
            this.lblartist = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.btnplay = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsongname
            // 
            this.lblsongname.AutoSize = true;
            this.lblsongname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsongname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsongname.Location = new System.Drawing.Point(82, 18);
            this.lblsongname.Name = "lblsongname";
            this.lblsongname.Size = new System.Drawing.Size(106, 18);
            this.lblsongname.TabIndex = 1;
            this.lblsongname.Text = "1.Song Name";
            this.lblsongname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblsongname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblartist
            // 
            this.lblartist.AutoEllipsis = true;
            this.lblartist.AutoSize = true;
            this.lblartist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblartist.ForeColor = System.Drawing.SystemColors.Control;
            this.lblartist.Location = new System.Drawing.Point(270, 18);
            this.lblartist.Name = "lblartist";
            this.lblartist.Size = new System.Drawing.Size(44, 20);
            this.lblartist.TabIndex = 2;
            this.lblartist.Text = "Artist";
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration.ForeColor = System.Drawing.SystemColors.Control;
            this.lblduration.Location = new System.Drawing.Point(450, 18);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(45, 20);
            this.lblduration.TabIndex = 3;
            this.lblduration.Text = "00:00";
            this.lblduration.Click += new System.EventHandler(this.Lblduration_Click_1);
            // 
            // btnplay
            // 
            this.btnplay.Image = ((System.Drawing.Image)(resources.GetObject("btnplay.Image")));
            this.btnplay.ImageActive = null;
            this.btnplay.Location = new System.Drawing.Point(17, 11);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(32, 32);
            this.btnplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnplay.TabIndex = 4;
            this.btnplay.TabStop = false;
            this.btnplay.Zoom = 10;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblartist);
            this.Controls.Add(this.lblsongname);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(530, 55);
            this.Load += new System.EventHandler(this.Playlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsongname;
        private System.Windows.Forms.Label lblartist;
        private System.Windows.Forms.Label lblduration;
        private Bunifu.Framework.UI.BunifuImageButton btnplay;
    }
}
