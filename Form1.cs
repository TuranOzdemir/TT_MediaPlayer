using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT_MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }

        private void loadFile_btn_Click(object sender, EventArgs e)
        {
            char[] ayrac = { '\\' };
            string[] pice;
            
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                fileList_lbx.Items.Clear();
                musicList_lbx.Items.Clear();
                string[] dosyalar = Directory.GetFiles(fbd.SelectedPath);
                
                foreach (string dosya in dosyalar)
                {
                    if (dosya.EndsWith(".m4a") || dosya.EndsWith(".mp3"))
                    {
                        pice = dosya.Split(ayrac);                        
                        string lastFolderName = Path.GetFileName(Path.GetDirectoryName(dosya));
                        for (int i = 0; i < pice.Length; i++)
                        {
                            if(pice[i] == lastFolderName)
                            {
                                fileList_lbx.Items.Add(pice[i + 1]);
                                musicList_lbx.Items.Add(dosya);
                            }
                        }                  
                    }                    
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            char[] ayrac = { '\\' };
            string[] pice;
            string item;
            foreach (string z in musicList_lbx.Items)
            {
                pice = z.Split(ayrac);
                string lastFolderName = Path.GetFileName(Path.GetDirectoryName(z));
                for (int i = 0; i < pice.Length; i++)
                {
                    if (pice[i] == lastFolderName)
                    {
                        string Name = pice[i + 1];
                        item = fileList_lbx.SelectedItem.ToString();
                        //axWindowsMediaPlayer1.URL = z;
                        
                        if (Name == item)
                        {
                            axWindowsMediaPlayer1.URL = z;
                        }
                    }
                    
                }

            }
        }
    }
}
