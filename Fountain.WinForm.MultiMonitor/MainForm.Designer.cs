namespace Fountain.WinForm.MultiMonitor
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelScanInfo = new System.Windows.Forms.Panel();
            this.DataGridViewScaned = new System.Windows.Forms.DataGridView();
            this.ColumnProductNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxProductNo = new System.Windows.Forms.TextBox();
            this.LabelProductNo = new System.Windows.Forms.Label();
            this.PanelScanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewScaned)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelScanInfo
            // 
            this.PanelScanInfo.Controls.Add(this.TextBoxProductNo);
            this.PanelScanInfo.Controls.Add(this.LabelProductNo);
            this.PanelScanInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelScanInfo.Location = new System.Drawing.Point(483, 0);
            this.PanelScanInfo.Name = "PanelScanInfo";
            this.PanelScanInfo.Size = new System.Drawing.Size(291, 547);
            this.PanelScanInfo.TabIndex = 0;
            // 
            // DataGridViewScaned
            // 
            this.DataGridViewScaned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductNo,
            this.ColumnProductName,
            this.ColumnNone});
            this.DataGridViewScaned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewScaned.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewScaned.Name = "DataGridViewScaned";
            this.DataGridViewScaned.ReadOnly = true;
            this.DataGridViewScaned.RowHeadersVisible = false;
            this.DataGridViewScaned.RowTemplate.Height = 23;
            this.DataGridViewScaned.Size = new System.Drawing.Size(483, 547);
            this.DataGridViewScaned.TabIndex = 1;
            // 
            // ColumnProductNo
            // 
            this.ColumnProductNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnProductNo.HeaderText = "产品编码";
            this.ColumnProductNo.Name = "ColumnProductNo";
            this.ColumnProductNo.ReadOnly = true;
            this.ColumnProductNo.Width = 160;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnProductName.HeaderText = "产品名称";
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            this.ColumnProductName.Width = 300;
            // 
            // ColumnNone
            // 
            this.ColumnNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNone.HeaderText = "";
            this.ColumnNone.Name = "ColumnNone";
            this.ColumnNone.ReadOnly = true;
            // 
            // TextBoxProductNo
            // 
            this.TextBoxProductNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxProductNo.Location = new System.Drawing.Point(113, 35);
            this.TextBoxProductNo.Name = "TextBoxProductNo";
            this.TextBoxProductNo.Size = new System.Drawing.Size(166, 23);
            this.TextBoxProductNo.TabIndex = 3;
            this.TextBoxProductNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxProductNo_KeyDown);
            // 
            // LabelProductNo
            // 
            this.LabelProductNo.Location = new System.Drawing.Point(4, 34);
            this.LabelProductNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelProductNo.Name = "LabelProductNo";
            this.LabelProductNo.Size = new System.Drawing.Size(102, 23);
            this.LabelProductNo.TabIndex = 2;
            this.LabelProductNo.Text = "产品编码：";
            this.LabelProductNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 547);
            this.Controls.Add(this.DataGridViewScaned);
            this.Controls.Add(this.PanelScanInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "程序主界面";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelScanInfo.ResumeLayout(false);
            this.PanelScanInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewScaned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelScanInfo;
        private System.Windows.Forms.DataGridView DataGridViewScaned;
        private System.Windows.Forms.TextBox TextBoxProductNo;
        private System.Windows.Forms.Label LabelProductNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNone;
    }
}

