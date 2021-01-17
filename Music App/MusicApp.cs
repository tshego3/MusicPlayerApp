using System;
using System.Drawing;
using System.Windows.Forms;

namespace Music_App
{
    public partial class MusicApp : Form
    {
        public MusicApp()
        {
            InitializeComponent();
        }

        string[] paths, files;
        int Startindex = 0;
        string[] FileName, FilePath;
        Boolean playnext = false;

        bool _playing = false;

        public bool isplaying
        {
            get { return _playing; }
            set
            {
                _playing = value;
                if (_playing)
                { axWindowsMediaPlayer1.Ctlcontrols.pause(); btnAction.Image = btnPlay.Image; }

                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play(); btnAction.Image = btnPause.Image;
                }
            }
        }


        public Image Thumbnail
        {
            get { return thumbnail.Image; }
            set { thumbnail.Image = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            StopPlayer();

        }

        public void StopPlayer()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        public void playfile(int playlistindex)
        {
            if (listBox1.Items.Count <= 0)
            { return; }
            if (playlistindex < 0)
            { return; }

            axWindowsMediaPlayer1.settings.autoStart = true; ///false;
            axWindowsMediaPlayer1.URL = FilePath[playlistindex];
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
             
        }
        private void BunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (Startindex > 0)
            { Startindex = Startindex - 1; }
            playfile(Startindex);
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.BringToFront();
        }

        private void BunifuImageButton8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BunifuImageButton9_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BunifuImageButton10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Startindex = listBox1.SelectedIndex;
            playfile(Startindex);
            lblSongname.Text = listBox1.Text;

        }

        private void BtnArtists_Click(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            OpenFileDialog openFileDig = new OpenFileDialog();
            openFileDig.Multiselect = true;
            openFileDig.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.avi;*.mov*;.flv;*.wmv;*.mpg|all files|*.*";
            if (openFileDig.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDig.SafeFileNames;
                FilePath = openFileDig.FileNames;
                for (int i = 0; i <= FileName.Length - 1; i++)
                {
                    listBox1.Items.Add(FileName[i]);
                }
                Startindex = 0;
                playfile(0);




            }


            ///FolderBrowserDialog FBD = new FolderBrowserDialog();
            // if (FBD.ShowDialog() == DialogResult.OK)
            //{
            //  listBox1.Items.Clear();
            //      string[] files = Directory.GetFiles(FBD.SelectedPath);
            //  string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

            //  foreach (string file in files)
            //  {
            //  listBox1.Items.Add(Path.GetFileName(file));
            ///
            /// }

            //  foreach (string dir in dirs)
            ///   {
            //      listBox1.Items.Add(Path.GetFileName((dir)));

            ///   }

            // }

        }

        private void BtSongs_Click(object sender, EventArgs e)
        {
            listBox1.BringToFront();
        }

        private void Volume_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volume.Value;
            ///lblVolume.Text = volume.Value.ToString();

        }

        public EventHandler onActon = null;

        private void BtnAction_Click(object sender, EventArgs e)
        {
            isplaying = !isplaying;
            if (onActon != null)
            { onActon.Invoke(this, e); }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (Startindex == listBox1.Items.Count - 1)
            { Startindex = listBox1.Items.Count - 1; }
            else if (Startindex < listBox1.Items.Count) { Startindex = Startindex + 1; }
            playfile(Startindex);
        }

        private void BunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            lblDuration.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            if(axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
            bunifuProgressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
           
            }
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying)
        {
        bunifuProgressBar1.MaximumValue = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
        }
            else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                bunifuProgressBar1.Value = 0;
             
            }
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void BunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
