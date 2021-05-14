using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace testnite
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Windows\System32\drivers\etc\host.txt";         
            string[] lines;
            string str;

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    
                }
        Console.WriteLine();

                str = System.IO.File.ReadAllText(filePath);
                Console.WriteLine("String: {0}", str);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                w.WriteLine("127.0.0.1 " + comboBox1.Text);
                comboBox1.Items.Add(comboBox1.Text);
                listBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "";
                MessageBox.Show("Done");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                w.Write("Copyright (c) 1993-2009 Microsoft Corp.\n\nThis is a sample HOSTS file used by Microsoft TCP/IP for Windows.\n\nThis file contains the mappings of IP addresses to host names. Each entry should be kept on an individual line. The IP address should  be placed in the first column followed by the corresponding host name.  The IP address and the host name should be separated by at least one space.\n\nAdditionally, comments (such as these) may be inserted on individual lines or following the machine name denoted by a ‘#’ symbol.\nFor example:\n\n102.54.94.97 rhino.acme.com # source server\n38.25.63.10 x.acme.com # x client host\nlocalhost name resolution is handled within DNS itself.\n127.0.0.1 localhost\n::1 localhost\n");
                comboBox1.Text = "";
                listBox1.Items.Clear();
                MessageBox.Show("Done");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {         
            string line = null;
            string line_to_delete = "127.0.0.1 " + comboBox1.Text;
            using (StreamReader reader = new StreamReader(@"C:\Windows\System32\drivers\etc\hosts"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Windows\System32\drivers\etc\newhosts"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, line_to_delete) == 0)
                            continue;
                        writer.WriteLine(line);
                        listBox1.Items.Remove(comboBox1.Text);
                        comboBox1.Items.Remove(comboBox1.Text);
                        
                    }
                    writer.Close();
                }
                reader.Close();
            }
            File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            System.IO.File.Move(@"C:\Windows\System32\drivers\etc\newhosts", @"C:\Windows\System32\drivers\etc\hosts");                   
            comboBox1.Text = "";      
            MessageBox.Show("Done");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            comboBox1.Text = listBox1.SelectedItem.ToString();

        }
    }
}
