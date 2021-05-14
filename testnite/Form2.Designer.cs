namespace testnite
{
    partial class Form2
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
            this.cpuPanel1 = new System.Windows.Forms.GroupBox();
            this.cpuLoad = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.Label();
            this.c3 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.coreAve = new System.Windows.Forms.Label();
            this.CpuLoadBar = new MetroFramework.Controls.MetroProgressBar();
            this.coreBar04 = new MetroFramework.Controls.MetroProgressBar();
            this.coreBar03 = new MetroFramework.Controls.MetroProgressBar();
            this.coreBar02 = new MetroFramework.Controls.MetroProgressBar();
            this.coreBar01 = new MetroFramework.Controls.MetroProgressBar();
            this.cpuBar = new MetroFramework.Controls.MetroProgressBar();
            this.cpuLoadd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPUU = new System.Windows.Forms.Label();
            this.Labellll = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gpuTempBar = new MetroFramework.Controls.MetroProgressBar();
            this.gpuLoadBar = new MetroFramework.Controls.MetroProgressBar();
            this.gpuTemp = new System.Windows.Forms.Label();
            this.gpuLoadPer = new System.Windows.Forms.Label();
            this.gpuPanel1 = new System.Windows.Forms.GroupBox();
            this.ramPanel1 = new System.Windows.Forms.GroupBox();
            this.RamByte = new System.Windows.Forms.Label();
            this.ramPerc = new MetroFramework.Controls.MetroProgressBar();
            this.Ram = new System.Windows.Forms.Label();
            this.discPanel1 = new System.Windows.Forms.GroupBox();
            this.DiskSize01 = new System.Windows.Forms.Label();
            this.DiskBar01 = new MetroFramework.Controls.MetroProgressBar();
            this.LDisk01 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cpuPanel1.SuspendLayout();
            this.gpuPanel1.SuspendLayout();
            this.ramPanel1.SuspendLayout();
            this.discPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpuPanel1
            // 
            this.cpuPanel1.Controls.Add(this.cpuLoad);
            this.cpuPanel1.Controls.Add(this.c4);
            this.cpuPanel1.Controls.Add(this.c3);
            this.cpuPanel1.Controls.Add(this.c2);
            this.cpuPanel1.Controls.Add(this.c1);
            this.cpuPanel1.Controls.Add(this.coreAve);
            this.cpuPanel1.Controls.Add(this.CpuLoadBar);
            this.cpuPanel1.Controls.Add(this.coreBar04);
            this.cpuPanel1.Controls.Add(this.coreBar03);
            this.cpuPanel1.Controls.Add(this.coreBar02);
            this.cpuPanel1.Controls.Add(this.coreBar01);
            this.cpuPanel1.Controls.Add(this.cpuBar);
            this.cpuPanel1.Controls.Add(this.cpuLoadd);
            this.cpuPanel1.Controls.Add(this.label5);
            this.cpuPanel1.Controls.Add(this.label4);
            this.cpuPanel1.Controls.Add(this.label3);
            this.cpuPanel1.Controls.Add(this.label2);
            this.cpuPanel1.Controls.Add(this.CPUU);
            this.cpuPanel1.Location = new System.Drawing.Point(23, 75);
            this.cpuPanel1.Name = "cpuPanel1";
            this.cpuPanel1.Size = new System.Drawing.Size(498, 249);
            this.cpuPanel1.TabIndex = 0;
            this.cpuPanel1.TabStop = false;
            this.cpuPanel1.Text = "groupBox1";
            this.cpuPanel1.Enter += new System.EventHandler(this.cpuPanel1_Enter);
            // 
            // cpuLoad
            // 
            this.cpuLoad.AutoSize = true;
            this.cpuLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLoad.ForeColor = System.Drawing.Color.Green;
            this.cpuLoad.Location = new System.Drawing.Point(115, 205);
            this.cpuLoad.Name = "cpuLoad";
            this.cpuLoad.Size = new System.Drawing.Size(34, 25);
            this.cpuLoad.TabIndex = 17;
            this.cpuLoad.Text = "30";
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.ForeColor = System.Drawing.Color.Green;
            this.c4.Location = new System.Drawing.Point(115, 171);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(34, 25);
            this.c4.TabIndex = 16;
            this.c4.Text = "30";
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.ForeColor = System.Drawing.Color.Green;
            this.c3.Location = new System.Drawing.Point(115, 137);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(34, 25);
            this.c3.TabIndex = 15;
            this.c3.Text = "30";
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.ForeColor = System.Drawing.Color.Green;
            this.c2.Location = new System.Drawing.Point(115, 102);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(34, 25);
            this.c2.TabIndex = 14;
            this.c2.Text = "30";
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.ForeColor = System.Drawing.Color.Green;
            this.c1.Location = new System.Drawing.Point(115, 66);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(34, 25);
            this.c1.TabIndex = 13;
            this.c1.Text = "30";
            // 
            // coreAve
            // 
            this.coreAve.AutoSize = true;
            this.coreAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coreAve.ForeColor = System.Drawing.Color.Green;
            this.coreAve.Location = new System.Drawing.Point(115, 29);
            this.coreAve.Name = "coreAve";
            this.coreAve.Size = new System.Drawing.Size(34, 25);
            this.coreAve.TabIndex = 12;
            this.coreAve.Text = "30";
            // 
            // CpuLoadBar
            // 
            this.CpuLoadBar.Location = new System.Drawing.Point(173, 207);
            this.CpuLoadBar.Name = "CpuLoadBar";
            this.CpuLoadBar.Size = new System.Drawing.Size(319, 23);
            this.CpuLoadBar.TabIndex = 11;
            // 
            // coreBar04
            // 
            this.coreBar04.Location = new System.Drawing.Point(173, 173);
            this.coreBar04.Name = "coreBar04";
            this.coreBar04.Size = new System.Drawing.Size(319, 23);
            this.coreBar04.TabIndex = 10;
            // 
            // coreBar03
            // 
            this.coreBar03.Location = new System.Drawing.Point(173, 137);
            this.coreBar03.Name = "coreBar03";
            this.coreBar03.Size = new System.Drawing.Size(319, 23);
            this.coreBar03.TabIndex = 9;
            // 
            // coreBar02
            // 
            this.coreBar02.Location = new System.Drawing.Point(173, 104);
            this.coreBar02.Name = "coreBar02";
            this.coreBar02.Size = new System.Drawing.Size(319, 23);
            this.coreBar02.TabIndex = 8;
            // 
            // coreBar01
            // 
            this.coreBar01.Location = new System.Drawing.Point(173, 68);
            this.coreBar01.Name = "coreBar01";
            this.coreBar01.Size = new System.Drawing.Size(319, 23);
            this.coreBar01.TabIndex = 7;
            // 
            // cpuBar
            // 
            this.cpuBar.Location = new System.Drawing.Point(173, 31);
            this.cpuBar.Name = "cpuBar";
            this.cpuBar.Size = new System.Drawing.Size(319, 23);
            this.cpuBar.TabIndex = 6;
            // 
            // cpuLoadd
            // 
            this.cpuLoadd.AutoSize = true;
            this.cpuLoadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLoadd.Location = new System.Drawing.Point(47, 205);
            this.cpuLoadd.Name = "cpuLoadd";
            this.cpuLoadd.Size = new System.Drawing.Size(62, 25);
            this.cpuLoadd.TabIndex = 5;
            this.cpuLoadd.Text = "Load:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Core 04:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Core 03:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Core 02:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Core 01:";
            // 
            // CPUU
            // 
            this.CPUU.AutoSize = true;
            this.CPUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUU.Location = new System.Drawing.Point(49, 29);
            this.CPUU.Name = "CPUU";
            this.CPUU.Size = new System.Drawing.Size(60, 25);
            this.CPUU.TabIndex = 0;
            this.CPUU.Text = "CPU:";
            // 
            // Labellll
            // 
            this.Labellll.AutoSize = true;
            this.Labellll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labellll.Location = new System.Drawing.Point(1, 29);
            this.Labellll.Name = "Labellll";
            this.Labellll.Size = new System.Drawing.Size(108, 25);
            this.Labellll.TabIndex = 0;
            this.Labellll.Text = "GPU Core:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 25);
            this.label23.TabIndex = 1;
            this.label23.Text = "GPU Load:";
            // 
            // gpuTempBar
            // 
            this.gpuTempBar.Location = new System.Drawing.Point(173, 31);
            this.gpuTempBar.Name = "gpuTempBar";
            this.gpuTempBar.Size = new System.Drawing.Size(319, 23);
            this.gpuTempBar.TabIndex = 6;
            // 
            // gpuLoadBar
            // 
            this.gpuLoadBar.Location = new System.Drawing.Point(173, 68);
            this.gpuLoadBar.Name = "gpuLoadBar";
            this.gpuLoadBar.Size = new System.Drawing.Size(319, 23);
            this.gpuLoadBar.TabIndex = 7;
            // 
            // gpuTemp
            // 
            this.gpuTemp.AutoSize = true;
            this.gpuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTemp.ForeColor = System.Drawing.Color.Green;
            this.gpuTemp.Location = new System.Drawing.Point(115, 29);
            this.gpuTemp.Name = "gpuTemp";
            this.gpuTemp.Size = new System.Drawing.Size(34, 25);
            this.gpuTemp.TabIndex = 12;
            this.gpuTemp.Text = "30";
            // 
            // gpuLoadPer
            // 
            this.gpuLoadPer.AutoSize = true;
            this.gpuLoadPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuLoadPer.ForeColor = System.Drawing.Color.Green;
            this.gpuLoadPer.Location = new System.Drawing.Point(115, 66);
            this.gpuLoadPer.Name = "gpuLoadPer";
            this.gpuLoadPer.Size = new System.Drawing.Size(34, 25);
            this.gpuLoadPer.TabIndex = 13;
            this.gpuLoadPer.Text = "30";
            // 
            // gpuPanel1
            // 
            this.gpuPanel1.Controls.Add(this.gpuLoadPer);
            this.gpuPanel1.Controls.Add(this.gpuTemp);
            this.gpuPanel1.Controls.Add(this.gpuLoadBar);
            this.gpuPanel1.Controls.Add(this.gpuTempBar);
            this.gpuPanel1.Controls.Add(this.label23);
            this.gpuPanel1.Controls.Add(this.Labellll);
            this.gpuPanel1.Location = new System.Drawing.Point(23, 330);
            this.gpuPanel1.Name = "gpuPanel1";
            this.gpuPanel1.Size = new System.Drawing.Size(498, 108);
            this.gpuPanel1.TabIndex = 18;
            this.gpuPanel1.TabStop = false;
            this.gpuPanel1.Text = "groupBox1";
            // 
            // ramPanel1
            // 
            this.ramPanel1.Controls.Add(this.RamByte);
            this.ramPanel1.Controls.Add(this.ramPerc);
            this.ramPanel1.Controls.Add(this.Ram);
            this.ramPanel1.Location = new System.Drawing.Point(23, 444);
            this.ramPanel1.Name = "ramPanel1";
            this.ramPanel1.Size = new System.Drawing.Size(498, 70);
            this.ramPanel1.TabIndex = 19;
            this.ramPanel1.TabStop = false;
            this.ramPanel1.Text = "groupBox2";
            // 
            // RamByte
            // 
            this.RamByte.AutoSize = true;
            this.RamByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamByte.ForeColor = System.Drawing.Color.Green;
            this.RamByte.Location = new System.Drawing.Point(115, 29);
            this.RamByte.Name = "RamByte";
            this.RamByte.Size = new System.Drawing.Size(34, 25);
            this.RamByte.TabIndex = 12;
            this.RamByte.Text = "30";
            // 
            // ramPerc
            // 
            this.ramPerc.Location = new System.Drawing.Point(173, 31);
            this.ramPerc.Name = "ramPerc";
            this.ramPerc.Size = new System.Drawing.Size(319, 23);
            this.ramPerc.TabIndex = 6;
            // 
            // Ram
            // 
            this.Ram.AutoSize = true;
            this.Ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ram.Location = new System.Drawing.Point(47, 29);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(62, 25);
            this.Ram.TabIndex = 0;
            this.Ram.Text = "RAM:";
            // 
            // discPanel1
            // 
            this.discPanel1.Controls.Add(this.DiskSize01);
            this.discPanel1.Controls.Add(this.DiskBar01);
            this.discPanel1.Controls.Add(this.LDisk01);
            this.discPanel1.Location = new System.Drawing.Point(23, 520);
            this.discPanel1.Name = "discPanel1";
            this.discPanel1.Size = new System.Drawing.Size(498, 102);
            this.discPanel1.TabIndex = 20;
            this.discPanel1.TabStop = false;
            this.discPanel1.Text = "Disk Information";
            // 
            // DiskSize01
            // 
            this.DiskSize01.AutoSize = true;
            this.DiskSize01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskSize01.Location = new System.Drawing.Point(49, 29);
            this.DiskSize01.Name = "DiskSize01";
            this.DiskSize01.Size = new System.Drawing.Size(39, 25);
            this.DiskSize01.TabIndex = 7;
            this.DiskSize01.Text = "C:\\";
            // 
            // DiskBar01
            // 
            this.DiskBar01.Location = new System.Drawing.Point(11, 57);
            this.DiskBar01.Name = "DiskBar01";
            this.DiskBar01.Size = new System.Drawing.Size(481, 23);
            this.DiskBar01.TabIndex = 6;
            // 
            // LDisk01
            // 
            this.LDisk01.AutoSize = true;
            this.LDisk01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDisk01.Location = new System.Drawing.Point(6, 29);
            this.LDisk01.Name = "LDisk01";
            this.LDisk01.Size = new System.Drawing.Size(39, 25);
            this.LDisk01.TabIndex = 0;
            this.LDisk01.Text = "C:\\";
            // 
            // timer
            // 
            this.timer.Interval = 800;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 627);
            this.Controls.Add(this.discPanel1);
            this.Controls.Add(this.ramPanel1);
            this.Controls.Add(this.gpuPanel1);
            this.Controls.Add(this.cpuPanel1);
            this.Name = "Form2";
            this.Text = "System Monitor";
            this.Activated += new System.EventHandler(this.timer_Tick);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.cpuPanel1.ResumeLayout(false);
            this.cpuPanel1.PerformLayout();
            this.gpuPanel1.ResumeLayout(false);
            this.gpuPanel1.PerformLayout();
            this.ramPanel1.ResumeLayout(false);
            this.ramPanel1.PerformLayout();
            this.discPanel1.ResumeLayout(false);
            this.discPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cpuPanel1;
        private MetroFramework.Controls.MetroProgressBar CpuLoadBar;
        private MetroFramework.Controls.MetroProgressBar coreBar04;
        private MetroFramework.Controls.MetroProgressBar coreBar03;
        private MetroFramework.Controls.MetroProgressBar coreBar02;
        private MetroFramework.Controls.MetroProgressBar coreBar01;
        private MetroFramework.Controls.MetroProgressBar cpuBar;
        private System.Windows.Forms.Label cpuLoadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CPUU;
        private System.Windows.Forms.Label cpuLoad;
        private System.Windows.Forms.Label c4;
        private System.Windows.Forms.Label c3;
        private System.Windows.Forms.Label c2;
        private System.Windows.Forms.Label c1;
        private System.Windows.Forms.Label coreAve;
        private System.Windows.Forms.Label Labellll;
        private System.Windows.Forms.Label label23;
        private MetroFramework.Controls.MetroProgressBar gpuTempBar;
        private MetroFramework.Controls.MetroProgressBar gpuLoadBar;
        private System.Windows.Forms.Label gpuTemp;
        private System.Windows.Forms.Label gpuLoadPer;
        private System.Windows.Forms.GroupBox gpuPanel1;
        private System.Windows.Forms.GroupBox ramPanel1;
        private System.Windows.Forms.Label RamByte;
        private System.Windows.Forms.Label Ram;
        private System.Windows.Forms.GroupBox discPanel1;
        private MetroFramework.Controls.MetroProgressBar DiskBar01;
        private System.Windows.Forms.Label LDisk01;
        private System.Windows.Forms.Label DiskSize01;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroProgressBar ramPerc;
    }
}