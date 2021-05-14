using OpenHardwareMonitor.Hardware;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.Linq;



namespace testnite
{
    public partial class Monito : Form
    {
        public Monito()
        {
            InitializeComponent();
            computer.Open();
        }

        private void Monito_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        /// <summary>
        /// Add CPU and GPU and as hardware
        /// Note that, CPU temperature data requires 'highestAvailable' permission.
        /// </summary>
        private Computer computer = new Computer() { CPUEnabled = true, GPUEnabled = true, RAMEnabled = true };
        /// <summary>
        /// These objects are used to access performance Monitor of the operating system.
        /// </summary>
        private PerformanceCounter perfCpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        private PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");

        /// <summary>
        /// These variables store source and destination 
        /// of the NVIDIA files needed for readings
        /// </summary>

        private string path = @"c:\NVSMI";
        private string SourcePath = @"C:\Program Files\NVIDIA Corporation\NVSMI\";
        private string DestinationPath = @"c:\NVSMI";

        /// <summary>
        /// These variables are used to extract NVIDA gpu readings
        /// </summary>
        private Char delimiter = '-';
        private Char delimiter2 = 'W';
        private int GPUCount = 0;
        private string output;
        /// <summary>
        /// This syntax instantiate an array for the possible drive on your pc
        /// </summary>
        private DriveInfo[] allDrives = DriveInfo.GetDrives();

        /// <summary>
        /// Temporary hods data
        /// </summary>
        private string buffer;
        private string buffer2;
        /// <summary>
        /// for-each counter variables
        /// </summary>
        private int counter = 0;
        private int counter2 = 0;
        private int counter3 = 0;

        /// <summary>
        /// CPU core temperature variables
        /// More can be added depending on the amount of core present
        /// </summary>
        private int cpu1;
        private int cpu2;
        private int cpu3;
        private int cpu4;
        private int cpuTotal;
        private int _cpuLoad;

        /// <summary>
        /// Disk drives usage variables
        /// more can be added based on the amount of drive present
        /// </summary>
        private double _Disk01;
        private double _Disk02;
        private double _Disk03;
        private double _Disk04;
        private int byteConvert = 1073741824;

        /// <summary>
        /// Variables for the RAM.
        /// Total ram is in MB and is the total thats in your system
        /// </summary>
        private double tRam;
        private double tRamTotal = 32000;
        private double tRamBar;

        /// <summary>
        /// These variables stores GPU temp and load data
        /// </summary>
        private int _gpuTemp;
        private int _gpuLoad;
     

        private void Form2_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cpu_gpu_temp();

            systemInfo();

            diskSize();

            gpuInfo();

            progress();

        }
        private void cpu_gpu_temp()
        {
            counter = 0;
            counter2 = 0;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (counter2 == 0)
                {
                    cpuPanel1.Text = hardware.Name.ToString();
                }
                if (counter2 == 2)
                {
                    gpuPanel1.Text = hardware.Name.ToString();
                }
                if (counter2 == 1)
                {
                    RAM.Text = hardware.Name.ToString();
                }
                if (counter2 == 3)
                {
                    disk.Text = hardware.Name.ToString();
                }

                counter2++;

                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        if (counter == 0)
                        {
                            circularProgressBar2.Text = sensor.Value.ToString() ;
                            cpu1 = (int)sensor.Value;
                        }
                        if (counter == 1)
                        {
                            circularProgressBar3.Text = sensor.Value.ToString() ;
                            cpu2 = (int)sensor.Value;
                        }
                        if (counter == 2)
                        {
                            circularProgressBar4.Text = sensor.Value.ToString() ;
                            cpu3 = (int)sensor.Value;
                        }
                        if (counter == 3)
                        {
                            circularProgressBar5.Text = sensor.Value.ToString() ;
                            cpu4 = (int)sensor.Value;
                        }
                        if (counter == 4)
                        {
                            buffer = sensor.Value.ToString();
                        }
                        if (counter == 5)
                        {
                            circularProgressBar7.Text = sensor.Value.ToString() ;
                            _gpuTemp = (int)sensor.Value;
                        }

                        counter++;
                    }

                    cpuTotal = (cpu1 + cpu2 + cpu3 + cpu4) / 4;

                    circularProgressBar1.Text = cpuTotal.ToString() ;
                }
            }
        }

        /// <summary>
        /// This method is used to get cpu and memory load
        /// from the Performance Monitor
        /// </summary>
        private void systemInfo()
        {
            _cpuLoad = (int)perfCpuCounter.NextValue();

            tRam = (int)perfMemCounter.NextValue();

            tRamBar = tRam / tRamTotal;

            tRamBar = tRamBar * 100;

            tRamBar = 100 - tRamBar;

            circularProgressBar9.Text = tRam.ToString();

            circularProgressBar6.Text = _cpuLoad.ToString();
        }

        /// <summary>
        /// This method use gathered data and
        /// display them in a progress bar
        /// </summary>
        private void progress()
        {
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            if (cpuTotal < circularProgressBar1.Maximum)
            {
                if (cpuTotal < 49)
                {
                    circularProgressBar1.ForeColor = Color.Green;
                }

                if (cpuTotal > 50)
                {
                    circularProgressBar1.ForeColor = Color.Orange;
                }

                if (cpuTotal > 75)
                {
                    circularProgressBar1.ForeColor = Color.Red;
                }

                circularProgressBar1.Value = cpuTotal;
            }

            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;

            if (cpu1 < circularProgressBar2.Maximum)
            {
                if (cpu1 < 49)
                {
                    circularProgressBar2.ForeColor = Color.Green;
                }
                if (cpu1 > 50)
                {
                    circularProgressBar2.ForeColor = Color.Orange;
                }

                if (cpu1 > 75)
                {
                    circularProgressBar2.ForeColor = Color.Red;
                }

                circularProgressBar2.Value = cpu1;
            }

            circularProgressBar3.Minimum = 0;
            circularProgressBar3.Maximum = 100;

            if (cpu2 < circularProgressBar3.Maximum)
            {
                if (cpu2 < 49)
                {
                    circularProgressBar3.ForeColor = Color.Green;
                }
                if (cpu2 > 50)
                {
                    circularProgressBar3.ForeColor = Color.Orange;
                }

                if (cpu2 > 75)
                {
                    circularProgressBar3.ForeColor = Color.Red;
                }
                circularProgressBar3.Value = cpu2;
            }

            circularProgressBar3.Minimum = 0;
            circularProgressBar3.Maximum = 100;

            if (cpu3 < circularProgressBar4.Maximum)
            {
                if (cpu3 < 49)
                {
                    circularProgressBar4.ForeColor = Color.Green;
                }
                if (cpu3 > 50)
                {
                    circularProgressBar4.ForeColor = Color.Orange;
                }

                if (cpu3 > 75)
                {
                    circularProgressBar4.ForeColor = Color.Red;
                }

                circularProgressBar4.Value = cpu3;
            }

            circularProgressBar5.Minimum = 0;
            circularProgressBar5.Maximum = 100;

            if (cpu4 < circularProgressBar5.Maximum)
            {
                if (cpu4 < 49)
                {
                    circularProgressBar5.ForeColor = Color.Green;
                }
                if (cpu4 > 50)
                {
                    circularProgressBar5.ForeColor = Color.Orange;
                }

                if (cpu4 > 75)
                {
                    circularProgressBar5.ForeColor = Color.Red;
                }

                circularProgressBar5.Value = cpu4;
            }

            circularProgressBar6.Minimum = 0;
            circularProgressBar6.Maximum = 100;

            if (_cpuLoad < circularProgressBar6.Maximum)
            {
                if (_cpuLoad < 49)
                {
                    circularProgressBar6.ForeColor = Color.Green;
                }
                if (_cpuLoad > 50)
                {
                    circularProgressBar6.ForeColor = Color.Orange;
                }

                if (_cpuLoad > 75)
                {
                    circularProgressBar6.ForeColor = Color.Red;
                }

                circularProgressBar6.Value = _cpuLoad;
            }

            circularProgressBar7.Minimum = 0;
            circularProgressBar7.Maximum = 100;

            if (_gpuTemp < circularProgressBar7.Maximum)
            {
                if (_gpuTemp < 49)
                {
                    circularProgressBar7.ForeColor = Color.Green;
                }
                if (_gpuTemp > 50)
                {
                    circularProgressBar7.ForeColor = Color.Orange;
                }

                if (_gpuTemp > 75)
                {
                    circularProgressBar7.ForeColor = Color.Red;
                }

                circularProgressBar7.Value = _gpuTemp;
            }
            circularProgressBar10.Minimum = 0;
            circularProgressBar10.Maximum = 100;

            if (_Disk01 < circularProgressBar10.Maximum)
            {
                if (_Disk01 < 49)
                {
                    circularProgressBar10.ForeColor = Color.Green;
                }
                if (_Disk01 > 50)
                {
                    circularProgressBar10.ForeColor = Color.Orange;
                }

                if (_Disk01 > 75)
                {
                    circularProgressBar10.ForeColor = Color.Red;
                }

                circularProgressBar10.Value = (int)_Disk01;
            }

            circularProgressBar9.Minimum = 0;
            circularProgressBar9.Maximum = 100;

            if (tRamBar < circularProgressBar9.Maximum)
            {
                if (tRamBar < 49)
                {
                    circularProgressBar9.ForeColor = Color.Green;
                }
                if (tRamBar > 50)
                {
                    circularProgressBar9.ForeColor = Color.Orange;
                }

                if (tRamBar > 75)
                {
                    circularProgressBar9.ForeColor = Color.Red;
                }

                circularProgressBar9.Value = (int)tRamBar;
            }

            circularProgressBar8.Minimum = 0;
            circularProgressBar8.Maximum = 100;

            if (_gpuLoad < circularProgressBar8.Maximum)
            {
                if (_gpuLoad < 49)
                {
                    circularProgressBar8.ForeColor = Color.Green;
                }
                if (_gpuLoad > 50)
                {
                    circularProgressBar8.ForeColor = Color.Orange;
                }

                if (_gpuLoad > 75)
                {
                    circularProgressBar8.ForeColor = Color.Red;
                }

                circularProgressBar8.Value = _cpuLoad + 9;
            }
        }

        /// <summary>
        /// This method is used to get all
        /// local disk information from the OS
        /// </summary>
        private void diskSize()
        {
            counter3 = 0;
            foreach (DriveInfo d in allDrives)
            {
                //Console.WriteLine("Drive {0}", d.Name);

                if (counter3 == 0)
                {
                    disk.Text = d.Name;
                }

                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);
                    //DataBox.Items.Add(d.TotalFreeSpace / byteConvert);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} bytes ",
                        d.TotalSize);

                    if (counter3 == 0)
                    {
                        diskinfo.Text = Convert.ToString((d.AvailableFreeSpace / byteConvert)) + " GB Free of " + Convert.ToString((d.TotalSize / byteConvert)) + " GB";
                        _Disk01 = (d.AvailableFreeSpace / byteConvert);
                        _Disk01 = _Disk01 / (d.TotalSize / byteConvert);
                        _Disk01 = _Disk01 * 100;
                        _Disk01 = 100 - _Disk01;
                    }

                }
                counter3++;
            }
        }

        /// <summary>
        /// This method gets gpu info.
        /// Note that this only supports NVIDA GPUs at the moment
        /// </summary>
        private void gpuInfo()
        {
            try
            {
                // Determine whether the directory exists.
                if (!Directory.Exists(path))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                    // try to copy to the new director
                    NVIDIAGPU();
                }
            }
            catch { MessageBox.Show("Unable to access NVIDIA files"); return; }

            try
            {
                GPUCount = 0;
                /// Process command line string ///

                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", @"/C cd c:\NVSMI&nvidia-smi --query-gpu=utilization.memory --format=csv");
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.CreateNoWindow = true;

                /// Creating a stream reader that will pass the output of the command line ///
                Process process = Process.Start(processStartInfo);
                using (StreamReader streamReader = process.StandardOutput)
                {
                    output = streamReader.ReadToEnd();
                }

                /// remove unit from value
                String[] substrings = output.Split(delimiter2);
                foreach (var substring in substrings)
                {
                    if (GPUCount == 0)
                    {

                        circularProgressBar8.Text = (_cpuLoad +9).ToString();

                        _gpuLoad = Convert.ToInt16(String.Join("", substring.Where(Char.IsDigit)));

                    }
                    GPUCount++;
                }
            }
            catch
            {
                MessageBox.Show("Unable to access NVIDIA files"); return;
            }
        }

        /// <summary>
        /// Copy Nvida files to C:\
        /// </summary>
        private void NVIDIAGPU()
        {
            SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
            DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

            try
            {
                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                    {
                        Directory.CreateDirectory(DestinationPath);
                    }

                    foreach (string files in Directory.GetFiles(SourcePath))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        fileInfo.CopyTo(string.Format(@"{0}\{1}", DestinationPath, fileInfo.Name), true);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NVIDIA File Access Error");
                this.Close();
            }
        }

        private void cpuPanel1_Enter(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar7_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar8_Click(object sender, EventArgs e)
        {

        }

        private void disk_Click(object sender, EventArgs e)
        {

        }
  

        private void Monito_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
