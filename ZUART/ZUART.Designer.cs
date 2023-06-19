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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.zuartControl1 = new ZuartControl.ZuartControl();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxShowData = new System.Windows.Forms.RichTextBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.labSplit2Switch = new System.Windows.Forms.Label();
            this.labSplit1Switch = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabLeft = new System.Windows.Forms.TabControl();
            this.PageDataSendRec = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabRight = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.移动到右侧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移动到左侧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Log.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabLeft.SuspendLayout();
            this.PageDataSendRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabRight.SuspendLayout();
            this.menuTab.SuspendLayout();
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
            this.zuartControl1.RichTextBoxShowData = this.rtxShowData;
            this.zuartControl1.SendCount = ((ulong)(0ul));
            this.zuartControl1.SendFileName = null;
            this.zuartControl1.Size = new System.Drawing.Size(163, 576);
            this.zuartControl1.TabIndex = 1;
            this.zuartControl1.TextBoxSendData = this.txtSendData;
            this.zuartControl1.ComConnectState += new System.EventHandler<ZuartControl.ZuartControl.ComConnectState_EventArgs>(this.zuartControl1_ComConnectState);
            this.zuartControl1.ComDataReceivedProperties += new System.EventHandler<ZuartControl.ZuartControl.ComData_EventArgs>(this.zuartControl1_ComDataReceived);
            this.zuartControl1.ComDataSend += new System.EventHandler<ZuartControl.ZuartControl.ComData_EventArgs>(this.zuartControl1_ComDataSend);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSend.Location = new System.Drawing.Point(516, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(38, 81);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rtxShowData
            // 
            this.rtxShowData.AcceptsTab = true;
            this.rtxShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxShowData.Location = new System.Drawing.Point(0, 0);
            this.rtxShowData.Name = "rtxShowData";
            this.rtxShowData.Size = new System.Drawing.Size(557, 442);
            this.rtxShowData.TabIndex = 0;
            this.rtxShowData.Text = "";
            // 
            // txtSendData
            // 
            this.txtSendData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSendData.Location = new System.Drawing.Point(3, 16);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendData.Size = new System.Drawing.Size(513, 81);
            this.txtSendData.TabIndex = 1;
            // 
            // labSplit2Switch
            // 
            this.labSplit2Switch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSplit2Switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.labSplit2Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSplit2Switch.Location = new System.Drawing.Point(1091, 60);
            this.labSplit2Switch.Name = "labSplit2Switch";
            this.labSplit2Switch.Size = new System.Drawing.Size(5, 130);
            this.labSplit2Switch.TabIndex = 6;
            this.labSplit2Switch.Text = "label1";
            this.labSplit2Switch.Click += new System.EventHandler(this.labSplit2Switch_Click);
            // 
            // labSplit1Switch
            // 
            this.labSplit1Switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.labSplit1Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSplit1Switch.Location = new System.Drawing.Point(164, 60);
            this.labSplit1Switch.Name = "labSplit1Switch";
            this.labSplit1Switch.Size = new System.Drawing.Size(4, 130);
            this.labSplit1Switch.TabIndex = 6;
            this.labSplit1Switch.Text = "label1";
            this.labSplit1Switch.Click += new System.EventHandler(this.labSplit1Switch_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.tabLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.tabRight);
            this.splitContainer1.Size = new System.Drawing.Size(931, 576);
            this.splitContainer1.SplitterDistance = 571;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.TabStop = false;
            // 
            // tabLeft
            // 
            this.tabLeft.Controls.Add(this.PageDataSendRec);
            this.tabLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLeft.HotTrack = true;
            this.tabLeft.Location = new System.Drawing.Point(0, 0);
            this.tabLeft.Multiline = true;
            this.tabLeft.Name = "tabLeft";
            this.tabLeft.SelectedIndex = 0;
            this.tabLeft.Size = new System.Drawing.Size(571, 576);
            this.tabLeft.TabIndex = 4;
            this.tabLeft.Click += new System.EventHandler(this.TabRight_Click);
            // 
            // PageDataSendRec
            // 
            this.PageDataSendRec.Controls.Add(this.splitContainer2);
            this.PageDataSendRec.Location = new System.Drawing.Point(4, 22);
            this.PageDataSendRec.Name = "PageDataSendRec";
            this.PageDataSendRec.Padding = new System.Windows.Forms.Padding(3);
            this.PageDataSendRec.Size = new System.Drawing.Size(563, 550);
            this.PageDataSendRec.TabIndex = 0;
            this.PageDataSendRec.Tag = "";
            this.PageDataSendRec.Text = "数据收发";
            this.PageDataSendRec.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.rtxShowData);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(557, 544);
            this.splitContainer2.SplitterDistance = 442;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 3;
            this.splitContainer2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSendData);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 8F);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送区";
            // 
            // tabRight
            // 
            this.tabRight.AllowDrop = true;
            this.tabRight.Controls.Add(this.tabPage1);
            this.tabRight.Controls.Add(this.tabPage2);
            this.tabRight.Controls.Add(this.tabPage3);
            this.tabRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRight.HotTrack = true;
            this.tabRight.Location = new System.Drawing.Point(0, 0);
            this.tabRight.Multiline = true;
            this.tabRight.Name = "tabRight";
            this.tabRight.SelectedIndex = 0;
            this.tabRight.Size = new System.Drawing.Size(358, 576);
            this.tabRight.TabIndex = 4;
            this.tabRight.Click += new System.EventHandler(this.TabRight_Click);
            this.tabRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.TabRight_DragDrop);
            this.tabRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.TabRight_DragEnter);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "";
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
            this.tabPage2.Tag = "";
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
            this.tabPage3.Tag = "";
            this.tabPage3.Text = "ASCII";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuTab
            // 
            this.menuTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.toolStripSeparator1,
            this.移动到右侧ToolStripMenuItem,
            this.移动到左侧ToolStripMenuItem});
            this.menuTab.Name = "menuTab";
            this.menuTab.Size = new System.Drawing.Size(137, 98);
            this.menuTab.Opening += new System.ComponentModel.CancelEventHandler(this.menuTab_Opening);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // 移动到右侧ToolStripMenuItem
            // 
            this.移动到右侧ToolStripMenuItem.Name = "移动到右侧ToolStripMenuItem";
            this.移动到右侧ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.移动到右侧ToolStripMenuItem.Text = "移动到右侧";
            this.移动到右侧ToolStripMenuItem.Click += new System.EventHandler(this.移动到右侧ToolStripMenuItem_Click);
            // 
            // 移动到左侧ToolStripMenuItem
            // 
            this.移动到左侧ToolStripMenuItem.Name = "移动到左侧ToolStripMenuItem";
            this.移动到左侧ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.移动到左侧ToolStripMenuItem.Text = "移动到左侧";
            this.移动到左侧ToolStripMenuItem.Click += new System.EventHandler(this.移动到左侧ToolStripMenuItem_Click);
            // 
            // ZUART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 601);
            this.Controls.Add(this.labSplit2Switch);
            this.Controls.Add(this.labSplit1Switch);
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
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabLeft.ResumeLayout(false);
            this.PageDataSendRec.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabRight.ResumeLayout(false);
            this.menuTab.ResumeLayout(false);
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
        private ZuartControl.ZuartControl zuartControl1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabRight;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labSplit2Switch;
        private System.Windows.Forms.Label labSplit1Switch;
        private System.Windows.Forms.ContextMenuStrip menuTab;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabLeft;
        private System.Windows.Forms.TabPage PageDataSendRec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 移动到右侧ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移动到左侧ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxShowData;
    }
}

