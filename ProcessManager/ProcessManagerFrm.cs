using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMinimizer
{
    public partial class ProcessManagerFrm : Form
    {
        public const int SW_HIDE = 0;
        public const int SW_SHOWNORMAL = 1;

        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        public ProcessManagerFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProcess();
        }

        private void LoadProcess()
        {
            ProcessList.Items.Clear();
            foreach (var process in Process.GetProcesses())
            {
                ProcessList.Items.Add(process.ProcessName);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadProcess();
        }


        private void HideBtn_Click(object sender, EventArgs e)
        {
            string selectedProcess = ProcessList.SelectedItem.ToString();
            foreach (var process in Process.GetProcessesByName(selectedProcess))
            {
                ShowWindow(process.MainWindowHandle, SW_HIDE);
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string selectedProcess = ProcessList.SelectedItem.ToString();
            foreach (var process in Process.GetProcessesByName(selectedProcess))
            {
                ShowWindow(process.MainWindowHandle, SW_SHOWNORMAL);
            }
        }

        private void KillBtn_Click(object sender, EventArgs e)
        {
            string selectedProcess = ProcessList.SelectedItem.ToString();
            foreach (var process in Process.GetProcessesByName(selectedProcess))
            {
                process.Kill();
            }
            LoadProcess();
        }

        private void ShowProcessInfoBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ProcessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProcess = ProcessList.SelectedItem.ToString();
            foreach (var process in Process.GetProcessesByName(selectedProcess))
            {
                try
                {
                    string fileName = process.MainModule.FileName;
                    FileLocationTxt.Text = fileName;
                    ErrorTxt.Text = "-";
                }
                catch (Exception ex)
                {
                    FileLocationTxt.Text = "Error~";
                    ErrorTxt.Text = ex.ToString();
                }
            }
        }
    }
}
