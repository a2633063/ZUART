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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel_ListSend = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerIcon = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtShowData = new System.Windows.Forms.TextBox();
            this.zuartControl1 = new ZUARTControl.ZuartControl();
            this.panel_Log.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel_Log.Location = new System.Drawing.Point(0, 594);
            this.panel_Log.Name = "panel_Log";
            this.panel_Log.Size = new System.Drawing.Size(1006, 25);
            this.panel_Log.TabIndex = 3;
            // 
            // btnabout
            // 
            this.btnabout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnabout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnabout.Location = new System.Drawing.Point(950, 1);
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
            this.btnCleanCount.Location = new System.Drawing.Point(878, 1);
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
            this.lblRevCount.Location = new System.Drawing.Point(672, 2);
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
            this.lblSendCount.Location = new System.Drawing.Point(775, 2);
            this.lblSendCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblSendCount.Name = "lblSendCount";
            this.lblSendCount.Padding = new System.Windows.Forms.Padding(2);
            this.lblSendCount.Size = new System.Drawing.Size(100, 18);
            this.lblSendCount.TabIndex = 11;
            this.lblSendCount.Text = "发送:0";
            this.lblSendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel_ListSend);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox6.Location = new System.Drawing.Point(813, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(193, 594);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "多字符串发送";
            // 
            // panel_ListSend
            // 
            this.panel_ListSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ListSend.AutoScroll = true;
            this.panel_ListSend.BackColor = System.Drawing.Color.Transparent;
            this.panel_ListSend.Location = new System.Drawing.Point(4, 32);
            this.panel_ListSend.Name = "panel_ListSend";
            this.panel_ListSend.Size = new System.Drawing.Size(189, 562);
            this.panel_ListSend.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "HEX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "发送";
            // 
            // timerIcon
            // 
            this.timerIcon.Interval = 300;
            this.timerIcon.Tick += new System.EventHandler(this.timerIcon_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.txtSendData);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox3.Location = new System.Drawing.Point(180, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 106);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送区";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSend.Location = new System.Drawing.Point(545, 22);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 76);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(3, 22);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendData.Size = new System.Drawing.Size(536, 76);
            this.txtSendData.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtShowData);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(180, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 476);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收区";
            // 
            // txtShowData
            // 
            this.txtShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShowData.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtShowData.Location = new System.Drawing.Point(3, 19);
            this.txtShowData.Multiline = true;
            this.txtShowData.Name = "txtShowData";
            this.txtShowData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowData.Size = new System.Drawing.Size(621, 454);
            this.txtShowData.TabIndex = 2;
            // 
            // zuartControl1
            // 
            this.zuartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zuartControl1.AutoLine = true;
            this.zuartControl1.ButtonSend = this.btnSend;
            this.zuartControl1.Labellog = this.Log;
            this.zuartControl1.Location = new System.Drawing.Point(0, 0);
            this.zuartControl1.Name = "zuartControl1";
            this.zuartControl1.PanelListSend = this.panel_ListSend;
            this.zuartControl1.Size = new System.Drawing.Size(180, 591);
            this.zuartControl1.TabIndex = 3;
            this.zuartControl1.TextBoxSendData = this.txtSendData;
            this.zuartControl1.TextBoxShowData = this.txtShowData;
            this.zuartControl1.ComConnectState += new System.EventHandler<ZUARTControl.ZuartControl.ComConnectState_EventArgs>(this.zuartControl1_ComConnectState);
            this.zuartControl1.ComDataReceived += new System.EventHandler<ZUARTControl.ZuartControl.ComDataReceived_EventArgs>(this.zuartControl1_ComDataReceived);
            // 
            // ZUART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 619);
            this.Controls.Add(this.zuartControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.panel_Log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZUART";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Z串口调试助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZUART_FormClosing);
            this.panel_Log.ResumeLayout(false);
            this.panel_Log.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Log;
        private System.Windows.Forms.Label lblRevCount;
        private System.Windows.Forms.Label lblSendCount;
        private System.Windows.Forms.Button btnCleanCount;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel_ListSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Timer timerIcon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtShowData;
        private ZUARTControl.ZuartControl zuartControl1;
        private System.Windows.Forms.Button btnSend;
    }
}

