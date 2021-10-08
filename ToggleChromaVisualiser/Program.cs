using System.IO;
using System.Diagnostics;
using System.Windows;

namespace ToggleChromaVisualiser
{
    class Program
    {
        static string ChromaVisualizerExec = @"C:\Program Files (x86)\Razer\Synapse3\AudioVisualizer\ChromaVisualizer.exe";
        static void Main(string[] args)
        {
            if (!File.Exists(ChromaVisualizerExec))
                MessageBox.Show("The Razer Chroma Visualizer executable cannot be found.");
            else
            {
                bool isrunning = false;

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
                    startit.StartInfo.FileName = ChromaVisualizerExec;
                    startit.Start();
                }
            }
        }
    }
}
