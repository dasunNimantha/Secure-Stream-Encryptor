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
        public string filePath = "";
        public string userPasss = null;
       

        
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
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Password is required");
                
            } else
            {

                SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.loginDBConnectionString);
                string query = "Select * from mainDB where id=1";
                SqlDataAdapter sda = new SqlDataAdapter(query,sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string hash = dt.Rows[0][1].ToString();
                
                
                var checkpass = BCrypt.Net.BCrypt.Verify(txtPass.Text, hash );
                if (!checkpass)
                {
                    MessageBox.Show("Invalid Password");

                } else

                {
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
                        startInfo.Arguments = $@"/k cd {path} && mkdir output && cd output && openssl rand 16 > enc.key && echo enc.key > enc.keyinfo && echo enc.key >> enc.keyinfo && ffmpeg.exe -i {filePath} -hls_time 100 -hls_key_info_file enc.keyinfo  -hls_playlist_type vod -hls_segment_filename {output} {m3uout} && exit";

                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();

                        }

                        string startPath = $@"{path}\\output\\";
                        string destPath = $@"{path}\\info.zip";

                        using (ZipFile zip = new ZipFile())
                        {

                            zip.Password = "123";
                            zip.AddDirectory(startPath);
                            zip.Save(destPath);
                        }


                        startInfo.Arguments = $@"/k cd {path} && del /Q output && move info.zip output && exit";
                        startInfo.CreateNoWindow = true;
                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();

                        }

                        string sessionName = "Maths Lecutre 2021.06.07";

                        startInfo.Arguments = $@"/k cd {path} && cd output && echo {sessionName} > hash.md5 && exit  ";
                        startInfo.CreateNoWindow = true;

                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();
                        }


                        string finalDestPath = $@"{path}\\{sessionName}.zip";

                        using (ZipFile zip = new ZipFile())
                        {

                            zip.Password = "test2";
                            zip.AddDirectory(startPath);
                            zip.Save(finalDestPath);
                        }

                        startInfo.Arguments = $@"/k cd {path} && del /Q output && rmdir output && exit";


                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();
                        }


                    }
                    catch (Exception fileEx)
                    {
                        Console.WriteLine(fileEx.ToString());
                    }
                }
                

            }

            
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
