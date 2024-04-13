using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fountain.WinForm.MultiMonitor
{
    public partial class MainForm : Form
    {
        //使用默认的事件处理委托，定义消息发布者事件
        public event EventHandler SendMsgEvent;
        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                SecondForm secondForm = new SecondForm();
                // 事件的订阅 
                SendMsgEvent += secondForm.SysncTextChaned;

                // 获取系统上所有显示器
                Screen[] screens = Screen.AllScreens;
                // 判断多屏
                if (screens.Length >1 ) 
                {
                    // 获取第二个屏幕
                    Screen screen = screens[1];
                    secondForm.StartPosition = FormStartPosition.Manual;
                    // 在 第二个屏幕 显示第二个窗体
                    secondForm.Location = screen.Bounds.Location;
                }
                // 显示辅助界面
                secondForm.Show();
            }
            catch 
            {
            }   
        }
        /// <summary>
        /// 文本输入框回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxProductNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter)
                {
                    return;
                }
                if (string.IsNullOrEmpty(this.TextBoxProductNo.Text))
                {
                    return;
                }
                Image image = Image.FromFile("P000001.png");
                // 事件触发通知
                SendMsgEvent(this, new SyncEventArg() { ProductNo = this.TextBoxProductNo.Text, ProductImage = image });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
