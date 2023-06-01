namespace ZUART
{
    partial class ZUART
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZUART));
            this.panel_Log = new System.Windows.Forms.Panel();
            this.btnabout = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Label();
            this.btnCleanCount = new System.Windows.Forms.Button();
            this.lblRevCount = new System.Windows.Forms.Label();
            this.lblSendCount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerIcon = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtShowData = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.zuartControl1 = new ZuartControl.ZuartControl();
            this.labSplitSwitch = new System.Windows.Forms.Label();
            this.panel_Log.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Log
            // 
            this.panel_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Log.Controls.Add(this.btnabout);
            this.panel_Log.Controls.Add(this.Log);
            this.panel_Log.Controls.Add(this.btnCleanCount);
            this.panel_Log.Controls.Add(this.lblRevCount);
            this.panel_Log.Controls.Add(this.lblSendCount);
            this.panel_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Log.Location = new System.Drawing.Point(0, 576);
            this.panel_Log.Name = "panel_Log";
            this.panel_Log.Size = new System.Drawing.Size(1096, 25);
            this.panel_Log.TabIndex = 4;
            // 
            // btnabout
            // 
            this.btnabout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnabout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnabout.Location = new System.Drawing.Point(1040, 1);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(51, 20);
            this.btnabout.TabIndex = 16;
            this.btnabout.Text = "关于";
            this.btnabout.UseVisualStyleBackColor = true;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(6, 3);
            this.Log.MinimumSize = new System.Drawing.Size(100, 0);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(2);
            this.Log.Size = new System.Drawing.Size(100, 16);
            this.Log.TabIndex = 15;
            this.Log.Text = "串口关闭";
            this.Log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCleanCount
            // 
            this.btnCleanCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCleanCount.Location = new System.Drawing.Point(968, 1);
            this.btnCleanCount.Name = "btnCleanCount";
            this.btnCleanCount.Size = new System.Drawing.Size(66, 20);
            this.btnCleanCount.TabIndex = 14;
            this.btnCleanCount.Text = "复位计数";
            this.btnCleanCount.UseVisualStyleBackColor = true;
            this.btnCleanCount.Click += new System.EventHandler(this.btnCleanCount_Click);
            // 
            // lblRevCount
            // 
            this.lblRevCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRevCount.AutoSize = true;
            this.lblRevCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRevCount.Location = new System.Drawing.Point(762, 2);
            this.lblRevCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblRevCount.Name = "lblRevCount";
            this.lblRevCount.Padding = new System.Windows.Forms.Padding(2);
            this.lblRevCount.Size = new System.Drawing.Size(100, 18);
            this.lblRevCount.TabIndex = 13;
            this.lblRevCount.Text = "接收:0";
            this.lblRevCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSendCount
            // 
            this.lblSendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSendCount.AutoSize = true;
            this.lblSendCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSendCount.Location = new System.Drawing.Point(865, 2);
            this.lblSendCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblSendCount.Name = "lblSendCount";
            this.lblSendCount.Padding = new System.Windows.Forms.Padding(2);
            this.lblSendCount.Size = new System.Drawing.Size(100, 18);
            this.lblSendCount.TabIndex = 11;
            this.lblSendCount.Text = "发送:0";
            this.lblSendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerIcon
            // 
            this.timerIcon.Interval = 300;
            this.timerIcon.Tick += new System.EventHandler(this.timerIcon_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSendData);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送区";
            // 
            // txtSendData
            // 
            this.txtSendData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSendData.Location = new System.Drawing.Point(3, 19);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendData.Size = new System.Drawing.Size(527, 84);
            this.txtSendData.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSend.Location = new System.Drawing.Point(530, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(38, 84);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtShowData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 468);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收区";
            // 
            // txtShowData
            // 
            this.txtShowData.AcceptsTab = true;
            this.txtShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShowData.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtShowData.Location = new System.Drawing.Point(3, 19);
            this.txtShowData.Multiline = true;
            this.txtShowData.Name = "txtShowData";
            this.txtShowData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowData.Size = new System.Drawing.Size(565, 446);
            this.txtShowData.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Location = new System.Drawing.Point(165, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(931, 576);
            this.splitContainer1.SplitterDistance = 571;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(571, 576);
            this.splitContainer2.SplitterDistance = 468;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 3;
            this.splitContainer2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 576);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "快捷发送";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 550);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "批量发送";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(350, 550);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "ASCII";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.zuartControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 576);
            this.panel1.TabIndex = 5;
            // 
            // zuartControl1
            // 
            this.zuartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.zuartControl1.AutoLine = false;
            this.zuartControl1.ButtonSend = this.btnSend;
            this.zuartControl1.Labellog = this.Log;
            this.zuartControl1.Location = new System.Drawing.Point(0, 0);
            this.zuartControl1.Margin = new System.Windows.Forms.Padding(0);
            this.zuartControl1.Name = "zuartControl1";
            this.zuartControl1.RevCount = ((ulong)(0ul));
            this.zuartControl1.SendCount = ((ulong)(0ul));
            this.zuartControl1.SendFileName = null;
            this.zuartControl1.Size = new System.Drawing.Size(163, 576);
            this.zuartControl1.TabIndex = 1;
            this.zuartControl1.TextBoxSendData = this.txtSendData;
            this.zuartControl1.TextBoxShowData = this.txtShowData;
            this.zuartControl1.ComConnectState += new System.EventHandler<ZuartControl.ZuartControl.ComConnectState_EventArgs>(this.zuartControl1_ComConnectState);
            this.zuartControl1.ComDataReceivedProperties += new System.EventHandler<ZuartControl.ZuartControl.ComData_EventArgs>(this.zuartControl1_ComDataReceived);
            this.zuartControl1.ComDataSend += new System.EventHandler<ZuartControl.ZuartControl.ComData_EventArgs>(this.zuartControl1_ComDataSend);
            // 
            // labSplitSwitch
            // 
            this.labSplitSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSplitSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.labSplitSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSplitSwitch.Location = new System.Drawing.Point(1091, 60);
            this.labSplitSwitch.Name = "labSplitSwitch";
            this.labSplitSwitch.Size = new System.Drawing.Size(5, 130);
            this.labSplitSwitch.TabIndex = 6;
            this.labSplitSwitch.Text = "label1";
            this.labSplitSwitch.Click += new System.EventHandler(this.labSplitSwitch_Click);
            // 
            // ZUART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 601);
            this.Controls.Add(this.labSplitSwitch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_Log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ZUART";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Z串口调试助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZUART_FormClosing);
            this.panel_Log.ResumeLayout(false);
            this.panel_Log.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Log;
        private System.Windows.Forms.Label lblRevCount;
        private System.Windows.Forms.Label lblSendCount;
        private System.Windows.Forms.Button btnCleanCount;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Timer timerIcon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtShowData;
        private ZuartControl.ZuartControl zuartControl1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labSplitSwitch;
    }
}

