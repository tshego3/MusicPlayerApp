using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_App
{
    public partial class Albums : UserControl
    {
        public Albums()
        {
            InitializeComponent();
        }

        public Image Thumbnail
        {
            get { return thumbnail.Image; }
            set { thumbnail.Image = value; }
        }

        ///<summary>
        ///gets or sets the song.
        /// </summary>
        /// <value>
        /// The album.
        /// </value>
        public string Song
        {
            get { return lblAlbum.Text; }
            set { lblAlbum.Text = value; }
        }

        ///<summary>
        ///gets or sets the song.
        /// </summary>
        /// <value>
        /// The artist.
        /// </value>
        public string Artist
        {
            get { return lblArtist.Text; }
            set { lblArtist.Text = value; }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
