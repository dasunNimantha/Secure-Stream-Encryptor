using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Ionic.Zip;
using BCrypt;

namespace SSE
{

   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public string filePath = "";
        public string outputPath = "";
        public string hash = null;
        public string userPasss = null;
       

        
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.loginDBConnectionString);
            string query = "Select * from mainDB where id=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            hash = dt.Rows[0][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                filePath = "\"" + ofd.FileName + "\"";
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = fbd.SelectedPath;
                outputPath = fbd.SelectedPath;
                btnEncrypt.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSessionName.Text))
            {  
                MessageBox.Show("Session Name is required");

            } else if(String.IsNullOrEmpty(txtPass.Text)){
                MessageBox.Show("Password is required");
            } else 

            {

                var checkpass = BCrypt.Net.BCrypt.Verify(txtPass.Text, hash );
                if (!checkpass)
                {
                    MessageBox.Show("Invalid Password");

                } else

                {
                    btnEncrypt.Enabled = false;
                    lblStat.ForeColor = Color.DarkOrange;
                    lblStat.Text = "Encrpyting... ";
                   
                    string path = Directory.GetCurrentDirectory();
                    string m3uout = "index.m3u8";
                    string output = "fileSequence%d.ts";

                    try
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.CreateNoWindow = false;
                        startInfo.UseShellExecute = false;
                        startInfo.FileName = "cmd.exe";
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        if (checkLow.Checked)
                        {
                            startInfo.Arguments = $@"/k cd {path} && mkdir output && cd output && openssl rand 16 > enc.key && echo enc.key > enc.keyinfo && echo enc.key >> enc.keyinfo && cd .. && ffmpeg.exe -vcodec h264_qsv  -i {filePath} -hls_time 100 -hls_key_info_file enc.keyinfo  -hls_playlist_type vod -hls_segment_filename {output} {m3uout} && exit";
                        } else if (checkNvidia.Checked)
                        {
                            startInfo.Arguments = $@"/k cd {path} && mkdir output && cd output && openssl rand 16 > enc.key && echo enc.key > enc.keyinfo && echo enc.key >> enc.keyinfo && cd .. && ffmpeg.exe -hwaccel cuda  -i {filePath} -hls_time 100 -hls_key_info_file enc.keyinfo  -hls_playlist_type vod -hls_segment_filename {output} {m3uout} && exit";
                        } else
                        {
                            startInfo.Arguments = $@"/k cd {path} && mkdir output && cd output && openssl rand 16 > enc.key && echo enc.key > enc.keyinfo && echo enc.key >> enc.keyinfo && cd .. && ffmpeg.exe -i {filePath} -hls_time 100 -hls_key_info_file enc.keyinfo  -hls_playlist_type vod -hls_segment_filename {output} {m3uout} && exit";
                        }
                      

                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();

                        }

                        lblStat.ForeColor = Color.Blue;
                        lblStat.Text = "Copying Files... ";
                        string startPath = $@"{path}\\output\\";
                        string destPath = $@"{path}\\info.zip";

                        using (ZipFile zip = new ZipFile())
                        {

                            zip.Password = "pass1";
                            zip.AddDirectory(startPath);
                            zip.Save(destPath);
                        }


                        startInfo.Arguments = $@"/k cd {path} && del /Q output && move info.zip output && exit";
                        startInfo.CreateNoWindow = true;
                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();

                        }

                        string sessionName = txtSessionName.Text;

                        startInfo.Arguments = $@"/k cd {path} && cd output && echo {sessionName} > hash.md5 && exit  ";
                        startInfo.CreateNoWindow = true;

                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();
                        }


                        string finalDestPath = $@"{outputPath}\\{sessionName}.zip";

                        using (ZipFile zip = new ZipFile())
                        {

                            zip.Password = "pass2";
                            zip.AddDirectory(startPath);
                            zip.Save(finalDestPath);
                        }

                        startInfo.Arguments = $@"/k cd {path} && del /Q output && rmdir output && exit";


                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();
                        }

                        lblStat.ForeColor = Color.Green;
                        lblStat.Text = "Done";



                    }
                    catch (Exception fileEx)
                    {
                        lblStat.ForeColor = Color.Red;
                        lblStat.Text = "Error"; 
                        Console.WriteLine(fileEx.ToString());
                    }

                    btnEncrypt.Enabled = true;
                }
                

            }

            
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkNvidia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLow.Checked)
            {
                checkLow.CheckState= CheckState.Unchecked;
               
            }
        }

        private void checkLow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNvidia.Checked)
            {
                checkNvidia.CheckState= CheckState.Unchecked;
                
            }
        }
    }
}
