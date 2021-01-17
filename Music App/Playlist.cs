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
    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }

       
        bool _playing = false;
        ///<summary>
        ///Gets or sets a value indicating this instance is playing.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is playing; otherwise, <c>false</c>
        /// </value>
        public bool isPlaying
        { get { return _playing; }


            set { _playing = value;

                if(_playing)
                { btnPlay.Image = btnPlay.Image; }
                else
                { btnPlay.Image = btnPaused.Image; }

            }


        }
        ///<summary>
        ///gets or sets the song.
        /// </summary>
        /// <value>
        /// The song.
        /// </value>
        public string Song
        {
            get { return lblSongname.Text; }
            set { lblSongname.Text = value; }
        }

        ///<summary>
        ///gets or sets the artist.
        /// </summary>
        /// <value>
        /// The artist.
        /// </value>
        public string Artist
        {
            get { return lblArtist.Text; }
            set { lblArtist.Text = value; }
        }

        ///<summary>
        ///gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public string Duration
        {
            get { return lblDuration.Text; }
            set { lblDuration.Text = value; }
        }
        /// <summary>
        /// Occurs when [on action].
        /// </summary>
        public event EventHandler onAction = null;

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            isPlaying = isPlaying;
            if (onAction!=null)
            { onAction.Invoke(this, e); }
        }
    }

   
   
}
