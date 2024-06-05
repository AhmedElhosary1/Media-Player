namespace Media_Player2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackStart = new System.Windows.Forms.Label();
            this.trackEnd = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnheader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MinBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.pnheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.player);
            this.panel2.Controls.Add(this.pnheader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 698);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.bunifuImageButton7);
            this.panel4.Controls.Add(this.bunifuImageButton6);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.trackStart);
            this.panel4.Controls.Add(this.trackEnd);
            this.panel4.Controls.Add(this.volume);
            this.panel4.Controls.Add(this.bunifuImageButton4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.bunifuImageButton5);
            this.panel4.Controls.Add(this.bunifuImageButton3);
            this.panel4.Controls.Add(this.bunifuImageButton2);
            this.panel4.Controls.Add(this.bunifuImageButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 599);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1006, 99);
            this.panel4.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(620, 48);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(223, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuImageButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton7.Image = global::Media_Player2.Properties.Resources.skip_to_start_30px;
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(145, 48);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton7.TabIndex = 21;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.Click += new System.EventHandler(this.bunifuImageButton7_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton6.Image = global::Media_Player2.Properties.Resources.end_30px;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(373, 48);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton6.TabIndex = 20;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(114, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(774, 10);
            this.progressBar1.TabIndex = 19;
            // 
            // trackStart
            // 
            this.trackStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackStart.AutoSize = true;
            this.trackStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.trackStart.Location = new System.Drawing.Point(64, 6);
            this.trackStart.Name = "trackStart";
            this.trackStart.Size = new System.Drawing.Size(44, 20);
            this.trackStart.TabIndex = 18;
            this.trackStart.Text = "00:00";
            // 
            // trackEnd
            // 
            this.trackEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackEnd.AutoSize = true;
            this.trackEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.trackEnd.Location = new System.Drawing.Point(895, 6);
            this.trackEnd.Name = "trackEnd";
            this.trackEnd.Size = new System.Drawing.Size(44, 20);
            this.trackEnd.TabIndex = 17;
            this.trackEnd.Text = "00:00";
            // 
            // volume
            // 
            this.volume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.volume.Location = new System.Drawing.Point(849, 59);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(29, 20);
            this.volume.TabIndex = 7;
            this.volume.Text = "0%";
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton4.Image = global::Media_Player2.Properties.Resources.chevron_right_30px;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(430, 48);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton4.TabIndex = 15;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.Image = global::Media_Player2.Properties.Resources.audio_30px;
            this.pictureBox3.Location = new System.Drawing.Point(884, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = global::Media_Player2.Properties.Resources.no_audio_30px;
            this.pictureBox2.Location = new System.Drawing.Point(579, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton5.Image = global::Media_Player2.Properties.Resources.pause_button_30px;
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(316, 48);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton5.TabIndex = 10;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton3.Image = global::Media_Player2.Properties.Resources.play_30px;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(259, 48);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 8;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::Media_Player2.Properties.Resources.rounded_square_30px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(202, 48);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::Media_Player2.Properties.Resources.chevron_left_30px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(88, 48);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 48);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1006, 650);
            this.player.TabIndex = 2;
            // 
            // pnheader
            // 
            this.pnheader.Controls.Add(this.label3);
            this.pnheader.Controls.Add(this.MinBtn);
            this.pnheader.Controls.Add(this.MaxBtn);
            this.pnheader.Controls.Add(this.CloseBtn);
            this.pnheader.Controls.Add(this.label1);
            this.pnheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnheader.Location = new System.Drawing.Point(0, 0);
            this.pnheader.Name = "pnheader";
            this.pnheader.Size = new System.Drawing.Size(1006, 48);
            this.pnheader.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(456, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Media Player";
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinBtn.Image = global::Media_Player2.Properties.Resources.minimize_window_30px;
            this.MinBtn.ImageActive = null;
            this.MinBtn.Location = new System.Drawing.Point(877, 7);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(35, 35);
            this.MinBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinBtn.TabIndex = 5;
            this.MinBtn.TabStop = false;
            this.MinBtn.Zoom = 10;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MaxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxBtn.Image = global::Media_Player2.Properties.Resources.maximize_window_30px;
            this.MaxBtn.ImageActive = null;
            this.MaxBtn.Location = new System.Drawing.Point(918, 7);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(35, 35);
            this.MaxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaxBtn.TabIndex = 4;
            this.MaxBtn.TabStop = false;
            this.MaxBtn.Zoom = 10;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::Media_Player2.Properties.Resources.cancel_30px;
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(959, 7);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 10;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "HO Media Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 698);
            this.panel1.TabIndex = 2;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Browse";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Media_Player2.Properties.Resources.browse_folder_20px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(46, 207);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(116, 37);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Browse";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(10, 258);
            this.listBox1.Margin = new System.Windows.Forms.Padding(10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 420);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(128, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "HO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Media_Player2.Properties.Resources.google_play_music_125px;
            this.pictureBox1.Location = new System.Drawing.Point(24, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnheader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1208, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1208, 698);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.pnheader.ResumeLayout(false);
            this.pnheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private Bunifu.Framework.UI.BunifuImageButton MinBtn;
        private Bunifu.Framework.UI.BunifuImageButton MaxBtn;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label trackStart;
        private System.Windows.Forms.Label trackEnd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

