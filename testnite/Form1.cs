using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Windows;
using static System.Windows.Forms.LinkLabel;

namespace testnite
{   
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void download(string link, string name)
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile(link, name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Link = "https://ninite.com/";
                if (checkBox1.Checked)
                {
                    Link = Link + "-chrome";
                }
                if (checkBox2.Checked)
                {
                    Link = Link + "-operaChromium";
                }
                if (checkBox3.Checked)
                {
                    Link = Link + "-firefox";
                }
                if (checkBox4.Checked)
                {
                    Link = Link + "-qbittorrent";
                }
                if (checkBox5.Checked)
                {
                    Link = Link + "-7zip";
                }
                if (checkBox6.Checked)
                {
                    Link = Link + "-peazip";
                }
                if (checkBox7.Checked)
                {
                    Link = Link + "-winrar";
                }
                if (checkBox8.Checked)
                {
                    Link = Link + "-discord";
                }
                if (checkBox9.Checked)
                {
                    Link = Link + "-skype";
                }
                if (checkBox10.Checked)
                {
                    Link = Link + "-pidgin";
                }
                if (checkBox11.Checked)
                {
                    Link = Link + "-thunderbird";
                }
                if (checkBox12.Checked)
                {
                    Link = Link + "-trillian";
                }
                if (checkBox13.Checked)
                {
                    Link = Link + "-dropbox";
                }
                if (checkBox14.Checked)
                {
                    Link = Link + "-googlebackupandsync";
                }
                if (checkBox15.Checked)
                {
                    Link = Link + "-onedrive";
                }
                if (checkBox16.Checked)
                {
                    Link = Link + "-sugarsync";
                }
                if (checkBox17.Checked)
                {
                    Link = Link + "-itunes";
                }
                if (checkBox18.Checked)
                {
                    Link = Link + "-vlc";
                }
                if (checkBox19.Checked)
                {
                    Link = Link + "-aimp";
                }
                if (checkBox20.Checked)
                {
                    Link = Link + "-foobar";
                }
                if (checkBox21.Checked)
                {
                    Link = Link + "-winamp";
                }
                if (checkBox22.Checked)
                {
                    Link = Link + "-musicbee";
                }
                if (checkBox23.Checked)
                {
                    Link = Link + "-audacity";
                }
                if (checkBox24.Checked)
                {
                    Link = Link + "-klitecodecs";
                }
                if (checkBox25.Checked)
                {
                    Link = Link + "-gom";
                }
                if (checkBox26.Checked)
                {
                    Link = Link + "-spotify";
                }
                if (checkBox27.Checked)
                {
                    Link = Link + "-cccp";
                }
                if (checkBox28.Checked)
                {
                    Link = Link + "-mediamonkey";
                }
                if (checkBox29.Checked)
                {
                    Link = Link + "-handbrake";
                }
                if (checkBox31.Checked)
                {
                    Link = Link + "-adoptjava8";
                }
                if (checkBox33.Checked)
                {
                    Link = Link + "-.net-4.8";
                }
                if (checkBox34.Checked)
                {
                    Link = Link + "-silverlight";
                }
                if (checkBox35.Checked)
                {
                    Link = Link + "-air";
                }
                if (checkBox36.Checked)
                {
                    Link = Link + "-evernote";
                }
                if (checkBox37.Checked)
                {
                    Link = Link + "-googleearth";
                }
                if (checkBox38.Checked)
                {
                    Link = Link + "-steam";
                }
                if (checkBox39.Checked)
                {
                    Link = Link + "-keepass2";
                }
                if (checkBox40.Checked)
                {
                    Link = Link + "-everything";
                }
                if (checkBox41.Checked)
                {
                    Link = Link + "-nvda";
                }
                if (checkBox42.Checked)
                {
                    Link = Link + "-krita";
                }
                if (checkBox43.Checked)
                {
                    Link = Link + "-blender";
                }
                if (checkBox44.Checked)
                {
                    Link = Link + "-paint.net";
                }
                if (checkBox45.Checked)
                {
                    Link = Link + "-gimp";
                }
                if (checkBox46.Checked)
                {
                    Link = Link + "-irfanview";
                }
                if (checkBox47.Checked)
                {
                    Link = Link + "-xnview";
                }
                if (checkBox48.Checked)
                {
                    Link = Link + "-inkscape";
                }
                if (checkBox49.Checked)
                {
                    Link = Link + "-faststone";
                }
                if (checkBox50.Checked)
                {
                    Link = Link + "-greenshot";
                }
                if (checkBox51.Checked)
                {
                    Link = Link + "-sharex";
                }
                Link = Link + "/ninite.exe";
                string na = "Ninite.exe";
                download(Link, na);
                MessageBox.Show("File OK", "Downloaded");
                var p = new Process();
                p.StartInfo.FileName = na;
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error:\n" + ex.ToString());
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sendesar, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = @"ScreenTemperature\Release\ScreenTemperature.exe";
            p.StartInfo = pi;
            try
            {
                p.Start();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
            }
        }
    }
}


