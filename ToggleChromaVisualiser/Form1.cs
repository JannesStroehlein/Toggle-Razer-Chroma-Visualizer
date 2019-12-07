using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToggleChromaVisualiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool isrunning = false;
            string pathtorun = @"C:\Program Files (x86)\Razer\Synapse3\AudioVisualizer\ChromaVisualizer.exe";

            Process[] allprocesses = Process.GetProcesses();
            for (int i = 0; i < allprocesses.Length; i++)
            {
                if (allprocesses[i].ProcessName.Contains("ChromaVisualizer"))
                {
                    isrunning = true;
                    allprocesses[i].Kill();
                    break;
                }
            }
            if (isrunning == false)
            {
                Process startit = new Process();
                startit.StartInfo.FileName = pathtorun;
                startit.Start();
            }
            this.Close();
        }
    }
}
