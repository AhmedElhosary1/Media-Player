using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] paths, files;             //FOR BROWSE BUTTON

        //MINIMIZE BUTTON CODE
        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //CLOSE BUTTON CODE
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //MAXMIZE BUTTON CODE
        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //CODE FOR PLAYING SELECTED ITEM IN LISTBOX
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[listBox1.SelectedIndex];
            player.Ctlcontrols.play();
            label3.Text = "Playing";
            timer1.Start();
            trackBar1.Value = 15;
            volume.Text = trackBar1.Value.ToString() + "%";
        }

        //PLAY BUTTON CODE
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            label3.Text = "Playing";
        }

        //PAUSE BUTTON CODE
        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            label3.Text = "Pause";
        }

        //STOP BUTTON CODE
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            label3.Text = "Stop";
        }

        //PREVIOUS BUTTON CODE
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
        }

        //NEXT BUTTON CODE
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
        }

        //TIMER FOR PROGRESS BAR
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
            }

            //FOR PROGRESS BAR LABELS
            trackStart.Text = player.Ctlcontrols.currentPositionString;
            trackEnd.Text = player.Ctlcontrols.currentItem.durationString.ToString();
        }

        //FORWARD QUICKLY PLAY
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastForward();
        }

        //BACKWARD QUICKLY PLAY
        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastReverse();
        }

        //VOLUME BUTTON CODE
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            volume.Text = trackBar1.Value.ToString() + "%";
        }



        //BROWSE BUTTON CODE
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter= "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int x=0; x<files.Length; x++)
                {
                    listBox1.Items.Add(files[x]);
                }
            }
        }
    }
}
