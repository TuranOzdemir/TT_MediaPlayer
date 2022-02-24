
namespace TT_MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.fileList_lbx = new DevExpress.XtraEditors.ListBoxControl();
            this.loadFile_btn = new DevExpress.XtraEditors.SimpleButton();
            this.play_btn = new DevExpress.XtraEditors.SimpleButton();
            this.musicList_lbx = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileList_lbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicList_lbx)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-3, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(355, 479);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // fileList_lbx
            // 
            this.fileList_lbx.Location = new System.Drawing.Point(371, 0);
            this.fileList_lbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileList_lbx.Name = "fileList_lbx";
            this.fileList_lbx.Size = new System.Drawing.Size(428, 479);
            this.fileList_lbx.TabIndex = 1;
            // 
            // loadFile_btn
            // 
            this.loadFile_btn.Appearance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadFile_btn.Appearance.BackColor2 = System.Drawing.SystemColors.Control;
            this.loadFile_btn.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.loadFile_btn.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadFile_btn.Appearance.Options.UseBackColor = true;
            this.loadFile_btn.Appearance.Options.UseBorderColor = true;
            this.loadFile_btn.Appearance.Options.UseFont = true;
            this.loadFile_btn.AppearancePressed.BackColor = System.Drawing.SystemColors.Control;
            this.loadFile_btn.AppearancePressed.Options.UseBackColor = true;
            this.loadFile_btn.Location = new System.Drawing.Point(825, 446);
            this.loadFile_btn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.loadFile_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadFile_btn.Name = "loadFile_btn";
            this.loadFile_btn.Size = new System.Drawing.Size(124, 33);
            this.loadFile_btn.TabIndex = 2;
            this.loadFile_btn.Text = "Load Files";
            this.loadFile_btn.Click += new System.EventHandler(this.loadFile_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.Appearance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.play_btn.Appearance.BackColor2 = System.Drawing.SystemColors.Control;
            this.play_btn.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.play_btn.Appearance.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.play_btn.Appearance.Options.UseBackColor = true;
            this.play_btn.Appearance.Options.UseBorderColor = true;
            this.play_btn.Appearance.Options.UseFont = true;
            this.play_btn.AppearancePressed.BackColor = System.Drawing.SystemColors.Control;
            this.play_btn.AppearancePressed.Options.UseBackColor = true;
            this.play_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("play_btn.ImageOptions.Image")));
            this.play_btn.Location = new System.Drawing.Point(825, 0);
            this.play_btn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.play_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(124, 72);
            this.play_btn.TabIndex = 3;
            this.play_btn.Text = "Play";
            this.play_btn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // musicList_lbx
            // 
            this.musicList_lbx.Location = new System.Drawing.Point(825, 77);
            this.musicList_lbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.musicList_lbx.Name = "musicList_lbx";
            this.musicList_lbx.Size = new System.Drawing.Size(124, 360);
            this.musicList_lbx.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(962, 500);
            this.Controls.Add(this.musicList_lbx);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.loadFile_btn);
            this.Controls.Add(this.fileList_lbx);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileList_lbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicList_lbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private DevExpress.XtraEditors.ListBoxControl fileList_lbx;
        private DevExpress.XtraEditors.SimpleButton loadFile_btn;
        private DevExpress.XtraEditors.SimpleButton play_btn;
        private DevExpress.XtraEditors.ListBoxControl musicList_lbx;
    }
}

