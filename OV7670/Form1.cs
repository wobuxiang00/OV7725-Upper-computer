using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
/*
 * 传图协议为，先发送“H:”为高范围0-240，“W:”为宽，范围0-320
 * 发送“data:”为标记图片传输开始，发送“L”为列开始，按列输出像素值且每列以“/n”结尾
*/
namespace OV7670
{
    public partial class MainFrm : Form
    {
        SerialPort sp;   //声明一个串口类
        bool isSetProperty = false; //属性设置标志位
        bool isOpen = false;//串口是否打开标志
        bool start = false;//开始数据发送
        Bitmap OvImage;
        int pic_w=0, pic_h=0;
        int frame = 0;
        ArrayList data = new ArrayList();
        public MainFrm()
        {
            InitializeComponent();
            this.usart_send_Button.Enabled = false;
            //CheckForIllegalCrossThreadCalls = false;
            this.MaximizeBox = false;//禁用最大化
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//关闭跨线程检查

            //****************填充下拉菜单********************
            //1.检测可用串口
            foreach (string s in SerialPort.GetPortNames())
            {
                cbbSerialID.Items.Add(s);
                cbbSerialID.Text = s;
            }
            //2.列出常用的波特率
            cbbBundRate.Items.Add("1200");
            cbbBundRate.Items.Add("2400");
            cbbBundRate.Items.Add("4800");
            cbbBundRate.Items.Add("9600");
            cbbBundRate.Items.Add("19200");
            cbbBundRate.Items.Add("115200");
            cbbBundRate.Items.Add("256000");
            cbbBundRate.SelectedIndex = 6;//默认选中最后一个

            //3.列出常用的停止位
            cbbStopBits.Items.Add("1");
            cbbStopBits.Items.Add("1.5");
            cbbStopBits.Items.Add("2");
            cbbStopBits.SelectedIndex = 0;

            //4.列出常用的数据位
            cbbDataBits.Items.Add("8");
            cbbDataBits.Items.Add("7");
            cbbDataBits.Items.Add("6");
            cbbDataBits.Items.Add("5");
            cbbDataBits.SelectedIndex = 0;

            //5.列出常用的奇偶校验位
            cbbCheckBits.Items.Add("无");
            cbbCheckBits.Items.Add("奇检验");
            cbbCheckBits.Items.Add("偶检验");
            cbbCheckBits.SelectedIndex = 0;

            //禁用发送数据按钮
            btnSave.Enabled = false;
        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //没有设置串口信息后才会设置串口信息
            if (!isSetProperty)
            {
                //设置当前串口信息
                SetPortProperty();
                isSetProperty = true;
            }

            //设置端口名称
            try
            {
                //根据串口状态打开或关闭
                if (!isOpen)
                {
                    //打开串口
                    sp.Open();
                    this.btnOpen.Text = "关闭串口";
                    this.usart_send_Button.Enabled = true;
                    this.cbbBundRate.Enabled = false;
                    this.cbbCheckBits.Enabled = false;
                    this.cbbDataBits.Enabled = false;
                    this.cbbSerialID.Enabled = false;
                    this.cbbStopBits.Enabled = false;
                    this.btnSave.Enabled = true;
                    this.timer1.Enabled = true;
                    isOpen = true;
                }
                else
                {
                    //关闭串口
                    btnOpen.Text = "打开串口";
                    isOpen = false;
                    this.usart_send_Button.Enabled = false;
                    this.cbbBundRate.Enabled = true;
                    this.cbbCheckBits.Enabled = true;
                    this.cbbDataBits.Enabled = true;
                    this.cbbSerialID.Enabled = true;
                    this.cbbStopBits.Enabled = true;
                    this.timer1.Enabled = false;
                    //重设标志,重设串口的信息
                    isSetProperty = false;
                    Thread.Sleep(100);
                    sp.Close();
                }
            }
            catch (Exception ex)
            {
                //关闭串口
                sp.Close();
                this.btnOpen.Text = "打开串口";
                MessageBox.Show("串口操作失败：" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OvImage.Save("OV7725.bmp");
            MessageBox.Show("图片保存成功", "信息");
        }

        /// <summary>
        /// 设置串口的属性
        /// </summary>
        private void SetPortProperty()
        {
            sp = new SerialPort();
            sp.PortName = cbbSerialID.Text.Trim();//设置串口名 
            sp.BaudRate = Convert.ToInt32(cbbBundRate.Text.Trim());//设置串口波特率  
            float f = Convert.ToSingle(cbbStopBits.Text.Trim());   //设置停止位  
            if (1.5 == f)
            {
                sp.StopBits = StopBits.OnePointFive;
            }
            else if (1 == f)
            {
                sp.StopBits = StopBits.One;
            }
            else if (2 == f)
            {
                sp.StopBits = StopBits.Two;
            }
            else
            {
                sp.StopBits = StopBits.One;
            }
            sp.DataBits = Convert.ToInt16(cbbDataBits.Text.Trim());//设置数据位  
            string s = cbbCheckBits.Text.Trim();//设置奇偶校验位  
            if (0 == s.CompareTo("无"))
            {
                sp.Parity = Parity.None;
            }
            else if (0 == s.CompareTo("奇校验"))
            {
                sp.Parity = Parity.Odd;
            }
            else if (0 == s.CompareTo("偶校验"))
            {
                sp.Parity = Parity.Even;
            }
            else
            {
                sp.Parity = Parity.None;
            }
            //设置串口数据到达执行的函数
            sp.DataReceived += Sp_DataReceived;
            //串口检测
            sp.PinChanged += Sp_PinChanged;
        }

        private void Sp_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            MessageBox.Show("串口拔出！");
        }

        /// <summary>
        /// 串口数据到达事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data,size;
            Color[] colors;
            //检测串口是否打开
            if (isOpen)
            {
                //可能会出现意想不到错误的代码区域
                try
                {
                    //从串口获取图片尺寸并创建图片
                    size = sp.ReadLine();
                    /*
                    if (start != true)
                    {
                        this.usart_get_Ritchbox.Text += (size + "\n");
                    }
                    */
                    if (size.StartsWith("H"))
                    {
                        pic_h = Convert.ToInt32(size.Substring(2));
                        show_log("图片高" + size.Substring(2) + "\n");
                    }
                    if (size.StartsWith("W"))
                    {
                        pic_w = Convert.ToInt32(size.Substring(2));
                        show_log("图片宽" + size.Substring(2) + "\n");
                    }
                    if (!start)
                    {
                        this.data.Add(size + "\n");
                    }
                    if (pic_h == 0 || pic_w == 0) return;
                    else
                    {
                        if (pic_w > 320 | pic_h > 240)
                        {
                            MessageBox.Show("图片宽不超过320且高不超过240");
                            return;
                        }
                        OvImage = new Bitmap(pic_h, pic_w);//新建一个位图
                    }
                    //检测是否开始发送数据
                    if (start != true && size.Equals("data:"))
                    {
                        show_log("检测到data\n");
                        start = true;
                    }
                    //开始读取数据
                    if (start)
                    {
                        show_log("开始读取数据\n");
                        //绘制图像(一列一列地绘制)
                        for (int Xcount = 0; Xcount < pic_h; Xcount++)
                        {
                            if (isOpen)
                            {
                                //读一列
                                //this.richTextBox1.Text += "\n读一列";
                                data = sp.ReadLine();
                                if (data.StartsWith("L"))//列有效
                                {
                                    colors = RGBToBitmap(data.Substring(1));
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                return;
                            }
                            //this.richTextBox1.AppendText("\n绘制,"+ Convert.ToInt32(Xcount));
                            for (int Ycount = 0; Ycount < pic_w; Ycount++)
                            {
                                OvImage.SetPixel(Xcount, Ycount, colors[Ycount]);
                            }
                            this.pbImage.Image = OvImage;
                        }
                        start = false;//接收数据结束
                        save_pic(OvImage, "pic" + frame + ".bmp");
                        this.pbImage1.Image = OvImage;
                        show_log("图片保存为" + "pic" + frame + ".bmp\n");
                        frame++;
                        if (frame > 20) frame = 0;
                    }
                }
                catch (Exception ex)
                {
                    show_log("\n"+ex);
                    return;
                }
            }
        }

        /// <summary>
        /// 退出之前关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sp != null)
            {
                if (sp.IsOpen)
                {
                    sp.DiscardInBuffer();
                    sp.Close();
                }
                sp.Dispose(); //释放sp使用的资源
                sp = null; //销毁sp
            }
        }

        /// <summary>
        /// 图像数据显示
        /// </summary>
        /// <param name="data">字符串数据</param>
        /// <returns></returns>
        private Color[] RGBToBitmap(string data)
        {
            Color[] colors;
            //将十六进制字符串转换为字节数组
            byte[] hexData = hexStringToByte(data);
            //将RGB565转换为RGB三色数值
            colors = RGB565ToColor(hexData);
            return colors;
        }

        /// <summary>
        /// 将RGB565的值转换为颜色数组
        /// </summary>
        /// <param name="hexArray"></param>
        /// <returns></returns>
        private static Color[] RGB565ToColor(byte[] hexArray)
        {
            //两字节代表一个像素，故长度为一半
            Color[] colors = new Color[hexArray.Length / 2];
            //生成Color值
            for (int i = 0; i < hexArray.Length; i += 2)
            {
                //U16(565) to RGB:
                //byte bg_r_color = ((bg_color >> 11) & 0xff) << 3;
                //byte bg_g_color = ((bg_color >> 5) & 0x3f) << 2;
                //byte bg_b_color = (bg_color & 0x1f) << 2;
                byte rr = (byte)(hexArray[i] & 0xf8);//byte和byte相与运算后，结果变为int
                byte gg = (byte)((hexArray[i] << 5) | ((hexArray[i+1] & 0xe0) >> 3));
                byte bb = (byte)(hexArray[i+1] << 3);

                // 补偿  
                rr = (byte)(rr | ((rr & 0x38) >> 3));
                gg = (byte)(gg | ((gg & 0x0c) >> 2));
                bb = (byte)(bb | ((bb & 0x38) >> 3));

                //设置Color值
                colors[i / 2] = Color.FromArgb(rr, gg, bb);
            }
            return colors;
        }

        /// <summary>
        /// 把16进制字符串转换成字节数组
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] hexStringToByte(String hex)
        {
            int len = (hex.Length / 2);
            byte[] result = new byte[len];
            char[] achar = hex.ToCharArray();
            for (int i = 0; i < len; i++)
            {
                int pos = i * 2;
                result[i] = (byte)(toByte(achar[pos]) << 4 | toByte(achar[pos + 1]));
            }
            return result;
        }

        /// <summary>
        /// 将十六进制的字符转换为字节
        /// </summary>
        /// <param name="c">字符</param>
        /// <returns></returns>
        private static byte toByte(char c)
        {
            byte b = (byte)"0123456789ABCDEF".IndexOf(c);
            return b;
        }

        void show_log(string log)
        {
            if (InvokeRequired)
            {
                Action ac = new Action(() => { richTextBox1.AppendText(log); });
                this.Invoke(ac); //这里执行后。则InvokeRequired就为false。因为此时已经是主线程访问当前创建的控件
            }
        }

        void send_usart(string log)
        {
            if (InvokeRequired)
            {
                Action ac = new Action(() => { usart_get_Ritchbox.AppendText(log); });
                this.Invoke(ac); //这里执行后。则InvokeRequired就为false。因为此时已经是主线程访问当前创建的控件
            }
        }

        private void cbbSerialID_DropDown(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                cbbSerialID.Items.Add(s);
                cbbSerialID.Text = s;
            }
        }

        private void usart_send_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string sendContent = this.usart_send_Ritchbox.Text.ToString();
                sp.Write(sendContent);
                show_log("已发送数据！");
            }
            catch (IOException eio)
            {
                MessageBox.Show("串口发送异常：" + eio);
            }
        }

        private void usart_data_clear_Click(object sender, EventArgs e)
        {
            this.usart_get_Ritchbox.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (string da in data)
                {
                    this.usart_get_Ritchbox.Text += da;
                }
                data.Clear();
            }
            catch (Exception ex)
            {
                show_log("\n" + ex);
                return;
            }
        }

        void save_pic(Bitmap bitmap,string name)
        {
            if (InvokeRequired)
            {
                Action ac = new Action(() => { bitmap.Save("C:\\Users\\Administrator\\Desktop\\文档\\毕业设计\\手势识别\\digital_gesture_recognition\\picture\\" + name); });
                this.Invoke(ac); //这里执行后。则InvokeRequired就为false。因为此时已经是主线程访问当前创建的控件
            }
        }

    }
}

