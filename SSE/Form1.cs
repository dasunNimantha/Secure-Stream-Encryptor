using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace SSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        string filePath = "";
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Videos|*.mp4;*.mkv;*.m4v";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                btnEncrypt.Enabled = true;
                filePath = "\"" + ofd.FileName + "\"";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string m3uout = path + "\\index.m3u8";
            string output = "output\\fileSequence%d.ts";
            Process process = Process.Start("cmd.exe",$@"/k cd {path} && mkdir output && ffmpeg.exe -i {filePath} -hls_time 9  -hls_playlist_type vod -hls_segment_filename {output} {m3uout} &&  del /Q output  && rmdir output");       
        }
    }
}
