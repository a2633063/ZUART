﻿namespace ZUART
{
    partial class FormShortcutSend
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.上移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(430, 472);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "数据";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 10F;
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.新增ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.toolStripSeparator1,
            this.删除ToolStripMenuItem,
            this.清空ToolStripMenuItem,
            this.toolStripSeparator2,
            this.上移ToolStripMenuItem,
            this.下移ToolStripMenuItem,
            this.toolStripSeparator3,
            this.备份ToolStripMenuItem,
            this.还原ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 286);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.修改ToolStripMenuItem.Text = "修改(&M)";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.新增ToolStripMenuItem.Text = "新增(&N)";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.复制ToolStripMenuItem.Text = "复制(&C)";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.删除ToolStripMenuItem.Text = "删除(&D)";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.清空ToolStripMenuItem.Text = "清空(&E)";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // 上移ToolStripMenuItem
            // 
            this.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem";
            this.上移ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up)));
            this.上移ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.上移ToolStripMenuItem.Text = "上移";
            this.上移ToolStripMenuItem.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // 下移ToolStripMenuItem
            // 
            this.下移ToolStripMenuItem.Name = "下移ToolStripMenuItem";
            this.下移ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.下移ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.下移ToolStripMenuItem.Text = "下移";
            this.下移ToolStripMenuItem.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.导入ToolStripMenuItem.Text = "导入(&I)";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.导出ToolStripMenuItem.Text = "导出(&E)";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // 备份ToolStripMenuItem
            // 
            this.备份ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.备份1ToolStripMenuItem,
            this.备份2ToolStripMenuItem,
            this.备份3ToolStripMenuItem,
            this.备份4ToolStripMenuItem,
            this.备份5ToolStripMenuItem,
            this.备份6ToolStripMenuItem,
            this.备份7ToolStripMenuItem,
            this.备份8ToolStripMenuItem,
            this.备份9ToolStripMenuItem});
            this.备份ToolStripMenuItem.Name = "备份ToolStripMenuItem";
            this.备份ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.备份ToolStripMenuItem.Text = "备份";
            // 
            // 还原ToolStripMenuItem
            // 
            this.还原ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.还原1ToolStripMenuItem,
            this.还原2ToolStripMenuItem,
            this.还原3ToolStripMenuItem,
            this.还原4ToolStripMenuItem,
            this.还原5ToolStripMenuItem,
            this.还原6ToolStripMenuItem,
            this.还原7ToolStripMenuItem,
            this.还原8ToolStripMenuItem,
            this.还原9ToolStripMenuItem});
            this.还原ToolStripMenuItem.Name = "还原ToolStripMenuItem";
            this.还原ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.还原ToolStripMenuItem.Text = "还原";
            // 
            // 备份1ToolStripMenuItem
            // 
            this.备份1ToolStripMenuItem.Name = "备份1ToolStripMenuItem";
            this.备份1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份1ToolStripMenuItem.Text = "备份1";
            this.备份1ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 备份2ToolStripMenuItem
            // 
            this.备份2ToolStripMenuItem.Name = "备份2ToolStripMenuItem";
            this.备份2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份2ToolStripMenuItem.Text = "备份2";
            this.备份2ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 备份3ToolStripMenuItem
            // 
            this.备份3ToolStripMenuItem.Name = "备份3ToolStripMenuItem";
            this.备份3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份3ToolStripMenuItem.Text = "备份3";
            this.备份3ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 备份4ToolStripMenuItem
            // 
            this.备份4ToolStripMenuItem.Name = "备份4ToolStripMenuItem";
            this.备份4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份4ToolStripMenuItem.Text = "备份4";
            this.备份4ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 备份5ToolStripMenuItem
            // 
            this.备份5ToolStripMenuItem.Name = "备份5ToolStripMenuItem";
            this.备份5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份5ToolStripMenuItem.Text = "备份5";
            this.备份5ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 备份6ToolStripMenuItem
            // 
            this.备份6ToolStripMenuItem.Name = "备份6ToolStripMenuItem";
            this.备份6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份6ToolStripMenuItem.Text = "备份6";
            this.备份6ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 备份7ToolStripMenuItem
            // 
            this.备份7ToolStripMenuItem.Name = "备份7ToolStripMenuItem";
            this.备份7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份7ToolStripMenuItem.Text = "备份7";
            this.备份7ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 备份8ToolStripMenuItem
            // 
            this.备份8ToolStripMenuItem.Name = "备份8ToolStripMenuItem";
            this.备份8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份8ToolStripMenuItem.Text = "备份8";
            this.备份8ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 备份9ToolStripMenuItem
            // 
            this.备份9ToolStripMenuItem.Name = "备份9ToolStripMenuItem";
            this.备份9ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份9ToolStripMenuItem.Text = "备份9";
            this.备份9ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 还原1ToolStripMenuItem
            // 
            this.还原1ToolStripMenuItem.Name = "还原1ToolStripMenuItem";
            this.还原1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原1ToolStripMenuItem.Text = "还原1";
            this.还原1ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 还原2ToolStripMenuItem
            // 
            this.还原2ToolStripMenuItem.Name = "还原2ToolStripMenuItem";
            this.还原2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原2ToolStripMenuItem.Text = "还原2";
            this.还原2ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 还原3ToolStripMenuItem
            // 
            this.还原3ToolStripMenuItem.Name = "还原3ToolStripMenuItem";
            this.还原3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原3ToolStripMenuItem.Text = "还原3";
            this.还原3ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 还原4ToolStripMenuItem
            // 
            this.还原4ToolStripMenuItem.Name = "还原4ToolStripMenuItem";
            this.还原4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原4ToolStripMenuItem.Text = "还原4";
            this.还原4ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 还原5ToolStripMenuItem
            // 
            this.还原5ToolStripMenuItem.Name = "还原5ToolStripMenuItem";
            this.还原5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原5ToolStripMenuItem.Text = "还原5";
            this.还原5ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 还原6ToolStripMenuItem
            // 
            this.还原6ToolStripMenuItem.Name = "还原6ToolStripMenuItem";
            this.还原6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原6ToolStripMenuItem.Text = "还原6";
            this.还原6ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 还原7ToolStripMenuItem
            // 
            this.还原7ToolStripMenuItem.Name = "还原7ToolStripMenuItem";
            this.还原7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原7ToolStripMenuItem.Text = "还原7";
            this.还原7ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 还原8ToolStripMenuItem
            // 
            this.还原8ToolStripMenuItem.Name = "还原8ToolStripMenuItem";
            this.还原8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原8ToolStripMenuItem.Text = "还原8";
            this.还原8ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 还原9ToolStripMenuItem
            // 
            this.还原9ToolStripMenuItem.Name = "还原9ToolStripMenuItem";
            this.还原9ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还原9ToolStripMenuItem.Text = "还原9";
            this.还原9ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // FormShortcutSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 472);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormShortcutSend";
            this.Text = "FormShortcutSend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShortcutSend_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 上移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原9ToolStripMenuItem;
    }
}