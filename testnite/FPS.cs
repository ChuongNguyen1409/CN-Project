using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace testnite
{
    public partial class FPS : Form
    {
        public FPS()
        {
            InitializeComponent();
        }
        private void FPS_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRampRED(IntPtr hDC, ref RAMPRED lpRamp);
        public static extern bool SetDeviceGammaRampGREEN(IntPtr hDC, ref RAMPGREEN lpRamp);
        public static extern bool SetDeviceGammaRampBLUE(IntPtr hDC, ref RAMPBLUE lpRamp);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RAMPRED
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;

        }
        public struct RAMPGREEN
        {
   
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;

        }
        public struct RAMPBLUE
        {
           
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        public static void SetGammaRed(int gamma)
        {
            if (gamma <= 256 && gamma >= 1)
            {
                RAMPRED ramp = new RAMPRED();
                ramp.Red = new ushort[256];
              
                for (int i = 1; i < 256; i++)
                {
                    int iArrayValue = i * (gamma + 128);

                    if (iArrayValue > 65535)
                        iArrayValue = 65535;
                    ramp.Red[i] = (ushort)iArrayValue;
                }
                SetDeviceGammaRampRED(GetDC(IntPtr.Zero), ref ramp);
            }
        }
        public static void SetGammaGreen(int gamma)
        {
            if (gamma <= 256 && gamma >= 1)
            {
                RAMPGREEN ramp = new RAMPGREEN();
               
                ramp.Green = new ushort[256];
                
                for (int i = 1; i < 256; i++)
                {
                    int iArrayValue = i * (gamma + 128);

                    if (iArrayValue > 65535)
                        iArrayValue = 65535;
                    ramp.Green[i] = (ushort)iArrayValue;
                }
                SetDeviceGammaRampGREEN(GetDC(IntPtr.Zero), ref ramp);
            }
        }
        public static void SetGammaBlue(int gamma)
        {
            if (gamma <= 256 && gamma >= 1)
            {
                RAMPBLUE ramp = new RAMPBLUE();
              
                ramp.Blue = new ushort[256];
                for (int i = 1; i < 256; i++)
                {
                    int iArrayValue = i * (gamma + 128);

                    if (iArrayValue > 65535)
                        iArrayValue = 65535;
                   ramp.Blue[i] = (ushort)iArrayValue;
                }
                SetDeviceGammaRampBLUE(GetDC(IntPtr.Zero), ref ramp);
            }
        }
        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int r = metroTrackBar1.Value;
            label1.Text = r.ToString();
            SetGammaRed(r);
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int g = metroTrackBar1.Value;
            label2.Text = g.ToString();
            SetGammaGreen(g);
        }

        private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int b = metroTrackBar1.Value;
            label3.Text = b.ToString();
            SetGammaBlue(b);
        }
    }
}
