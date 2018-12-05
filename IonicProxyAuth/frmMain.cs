using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IonicProxyAuth
{
    public partial class frmMain : Form
    {
        private string cmdOutput = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdModuleCkeck_Click(object sender, EventArgs e)
        {
            runCommand("cmd", "/c proxy-login-automator", true);

            bool found = cmdOutput.IndexOf("-local_host host") != -1 && cmdOutput.IndexOf("-remote_host host") != -1;

            log("proxy-login-automator " + (found ? "installed" : "not installed") + "!!");
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            try
            {
                string proxy = proxyServer.Text;
                if (proxy.IndexOf(":") == -1)
                {
                    log("Inform the Corporate proxy with a port. e.i: host:port!!");
                    return;
                }

                Properties.Settings.Default.proxyServer = proxy;
                Properties.Settings.Default.proxyPort = proxyPort.Text;
                Properties.Settings.Default.proxyUser = proxyUser.Text;
                Properties.Settings.Default.proxyPass = proxyPass.Text;
                Properties.Settings.Default.Save();
                log("Information saved!!");
            }
            catch (Exception ex)
            {
                log(ex.ToString());
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;

            proxyPort.Text = string.IsNullOrWhiteSpace(Properties.Settings.Default.proxyPort) ? "3128" : Properties.Settings.Default.proxyPort;
            proxyServer.Text = Properties.Settings.Default.proxyServer;
            proxyUser.Text = Properties.Settings.Default.proxyUser;
            proxyPass.Text = Properties.Settings.Default.proxyPass;

            log("proxy-login-automator in: " + Properties.Settings.Default.automator + "!!");

            checkProxyState();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (cmdStart.Text == "Stop Proxy")
            {
                try
                {
                    log("Searching for proxy-login-automator...");

                    Process currentProcess = Process.GetCurrentProcess();
                    Process[] localAll = Process.GetProcesses();
                    Process[] localByName = Process.GetProcessesByName("node");
                    for (int i = 0; i < localByName.Length; i++)
                    {
                        string processId = localByName[i].Id.ToString();
                        string query = "Select CommandLine From Win32_Process Where ProcessID = " + processId;
                        ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                        ManagementObjectCollection processList = searcher.Get();

                        foreach (ManagementObject obj in processList)
                        {
                            string arg = obj["CommandLine"].ToString();
                            if (arg.IndexOf("proxy-login-automator") != -1)
                            {
                                localByName[i].Kill();
                                log("Proxy PID " + localByName[i].Id + " stoped!!");
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    log(ex.ToString());
                }

                return;
            }

            string proxy = proxyServer.Text;

            runCommand("cmd", @"/c proxy-login-automator -local_port " + proxyPort.Text +
                " -remote_host " + proxy.Split(':')[0] + " -remote_port " + proxy.Split(':')[1] +
                " -usr " + proxyUser.Text + " -pwd " + proxyPass.Text, false);

            log("Proxy started!!");

            log(env);
        }

        private string runCommand(string cmd, string parms, bool getOutput)
        {
            cmdOutput = "";

            Process process = new Process();
            process.StartInfo.FileName = cmd;
            process.StartInfo.Arguments = parms;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);

            //* Start process and handlers
            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            if (getOutput)
                process.WaitForExit();

            Properties.Settings.Default.pid = process.Id.ToString();
            Properties.Settings.Default.Save();

            return cmdOutput;
        }

        void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            try
            {
                cmdOutput += outLine.Data + "\r\n";
                if (outLine.Data.IndexOf("\"pwd\":") == -1)
                    log(outLine.Data);
            }
            catch (Exception ex)
            {
                log(ex.Message);
            }
        }

        private void cmdClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(checkProxyState));
            th.Start();
        }

        private void checkProxyState()
        {
            try
            {
                string proxy = proxyServer.Text;
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect("localhost", int.Parse(proxyPort.Text));

                lblStatus.Text = tcpClient.Connected ? "Proxy is active!!" : "Proxy is inative!!";
                lblStatus.ForeColor = tcpClient.Connected ? Color.Green : Color.Red;
                cmdStart.Text = tcpClient.Connected ? "Stop Proxy" : "Start Proxy";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Proxy is inative!!";
                lblStatus.ForeColor = Color.Red;
                cmdStart.Text = "Start Proxy";
            }
        }

        string env = @"
npm config set proxy http://localhost:3128
npm config set https-proxy http://localhost:3128
npm config set strict-ssl false

set HTTP_PROXY=http://localhost:3128
set HTTPS_PROXY=http://localhost:3128
set IONIC_HTTP_PROXY=http://localhost:3128
set PROXY=http
";
        private void cmdShowEnv_Click(object sender, EventArgs e)
        {
            try
            {      
                log(env);

                Clipboard.SetText(env);

                ProcessStartInfo pro = new ProcessStartInfo();
                pro.FileName = "cmd.exe";
                //pro.RedirectStandardInput = true;
                //pro.UseShellExecute = false;
                Process proStart = new Process();
                proStart.StartInfo = pro;
                proStart.Start();

                //string[] cmds = env.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                //for (int i = 0; i < cmds.Length; i++)
                //{
                //    proStart.StandardInput.WriteLine(cmds[i] + "\r\n");
                //}
            }
            catch (Exception ex)
            {
                log(ex.ToString());
            }
        }

        private void log(string env)
        {
            txtLog.AppendText(env + "\r\n");
        }
    }
}
