using System;
using System.Windows.Forms;

namespace Fountain.WinForm.MultiMonitor
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 响应事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void SysncTextChaned(object sender, EventArgs e)
        {
            try
            {
                //取到主窗体的传来的文本
                SyncEventArg arg = e as SyncEventArg;
                this.LabelTrackingNo.Text = arg.ProductNo;
                this.PictureBoxProduct.Image = arg.ProductImage;
            }
            catch
            {
            }
        }
    }
}
