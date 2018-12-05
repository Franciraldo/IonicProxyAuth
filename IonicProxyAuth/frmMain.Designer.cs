namespace IonicProxyAuth
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.proxyPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proxyUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proxyPass = new System.Windows.Forms.TextBox();
            this.cmdApply = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cmdModuleCkeck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdClearLog = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.proxyServer = new System.Windows.Forms.TextBox();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.cmdShowEnv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Proxy Port:";
            // 
            // proxyPort
            // 
            this.proxyPort.Location = new System.Drawing.Point(103, 85);
            this.proxyPort.Name = "proxyPort";
            this.proxyPort.Size = new System.Drawing.Size(71, 20);
            this.proxyPort.TabIndex = 3;
            this.proxyPort.Text = "3128";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proxy User:";
            // 
            // proxyUser
            // 
            this.proxyUser.Location = new System.Drawing.Point(103, 33);
            this.proxyUser.Name = "proxyUser";
            this.proxyUser.Size = new System.Drawing.Size(212, 20);
            this.proxyUser.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Proxy Password:";
            // 
            // proxyPass
            // 
            this.proxyPass.Location = new System.Drawing.Point(103, 59);
            this.proxyPass.Name = "proxyPass";
            this.proxyPass.PasswordChar = '*';
            this.proxyPass.Size = new System.Drawing.Size(212, 20);
            this.proxyPass.TabIndex = 2;
            // 
            // cmdApply
            // 
            this.cmdApply.Location = new System.Drawing.Point(321, 5);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(97, 23);
            this.cmdApply.TabIndex = 4;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(12, 136);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(406, 153);
            this.txtLog.TabIndex = 9;
            // 
            // cmdModuleCkeck
            // 
            this.cmdModuleCkeck.Location = new System.Drawing.Point(321, 31);
            this.cmdModuleCkeck.Name = "cmdModuleCkeck";
            this.cmdModuleCkeck.Size = new System.Drawing.Size(97, 23);
            this.cmdModuleCkeck.TabIndex = 5;
            this.cmdModuleCkeck.Text = "Check module";
            this.cmdModuleCkeck.UseVisualStyleBackColor = true;
            this.cmdModuleCkeck.Click += new System.EventHandler(this.cmdModuleCkeck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(100, 117);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(30, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "N/A";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(321, 57);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(97, 23);
            this.cmdStart.TabIndex = 6;
            this.cmdStart.Text = "Start Local Proxy";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdClearLog
            // 
            this.cmdClearLog.Location = new System.Drawing.Point(321, 83);
            this.cmdClearLog.Name = "cmdClearLog";
            this.cmdClearLog.Size = new System.Drawing.Size(97, 23);
            this.cmdClearLog.TabIndex = 7;
            this.cmdClearLog.Text = "Clear Log";
            this.cmdClearLog.UseVisualStyleBackColor = true;
            this.cmdClearLog.Click += new System.EventHandler(this.cmdClearLog_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Corporate Proxy:";
            // 
            // proxyServer
            // 
            this.proxyServer.Location = new System.Drawing.Point(103, 7);
            this.proxyServer.Name = "proxyServer";
            this.proxyServer.Size = new System.Drawing.Size(212, 20);
            this.proxyServer.TabIndex = 0;
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Interval = 1000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // cmdShowEnv
            // 
            this.cmdShowEnv.Location = new System.Drawing.Point(321, 107);
            this.cmdShowEnv.Name = "cmdShowEnv";
            this.cmdShowEnv.Size = new System.Drawing.Size(97, 23);
            this.cmdShowEnv.TabIndex = 8;
            this.cmdShowEnv.Text = "Show Env/cmd";
            this.cmdShowEnv.UseVisualStyleBackColor = true;
            this.cmdShowEnv.Click += new System.EventHandler(this.cmdShowEnv_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 301);
            this.Controls.Add(this.cmdShowEnv);
            this.Controls.Add(this.cmdClearLog);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdModuleCkeck);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.proxyPass);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proxyUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proxyServer);
            this.Controls.Add(this.proxyPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ionic Proxy Auth - Version BETA 1.0.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proxyPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proxyUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proxyPass;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button cmdModuleCkeck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdClearLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox proxyServer;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Button cmdShowEnv;
    }
}

