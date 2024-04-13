namespace Fountain.WinForm.MultiMonitor
{
    partial class SecondForm
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
            this.LabelTrackingNo = new System.Windows.Forms.Label();
            this.PictureBoxProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTrackingNo
            // 
            this.LabelTrackingNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTrackingNo.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTrackingNo.ForeColor = System.Drawing.Color.Red;
            this.LabelTrackingNo.Location = new System.Drawing.Point(0, 0);
            this.LabelTrackingNo.Name = "LabelTrackingNo";
            this.LabelTrackingNo.Size = new System.Drawing.Size(596, 132);
            this.LabelTrackingNo.TabIndex = 1;
            this.LabelTrackingNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxProduct
            // 
            this.PictureBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxProduct.Location = new System.Drawing.Point(0, 132);
            this.PictureBoxProduct.Name = "PictureBoxProduct";
            this.PictureBoxProduct.Size = new System.Drawing.Size(596, 358);
            this.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProduct.TabIndex = 2;
            this.PictureBoxProduct.TabStop = false;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 490);
            this.Controls.Add(this.PictureBoxProduct);
            this.Controls.Add(this.LabelTrackingNo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SecondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "辅助显示界面";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTrackingNo;
        private System.Windows.Forms.PictureBox PictureBoxProduct;
    }
}