using System;
using System.Drawing;

namespace Fountain.WinForm.MultiMonitor
{
    /// <summary>
    /// 事件参数
    /// </summary>
    public class SyncEventArg : EventArgs
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        public string ProductNo { get; set; }
        /// <summary>
        /// 产品图片
        /// </summary>
        public Image ProductImage { get; set; }
    }
}
