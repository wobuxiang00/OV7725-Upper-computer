namespace OV7670
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.gbPicture = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage1 = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbSerialConfig = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cbbDataBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.lblCheckBits = new System.Windows.Forms.Label();
            this.cbbCheckBits = new System.Windows.Forms.ComboBox();
            this.lblBundRate = new System.Windows.Forms.Label();
            this.cbbBundRate = new System.Windows.Forms.ComboBox();
            this.lblSerialID = new System.Windows.Forms.Label();
            this.cbbSerialID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usart_data_clear = new System.Windows.Forms.Button();
            this.usart_send_Button = new System.Windows.Forms.Button();
            this.usart_send_Ritchbox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usart_get_Ritchbox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbSerialConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPicture
            // 
            this.gbPicture.Controls.Add(this.label2);
            this.gbPicture.Controls.Add(this.label1);
            this.gbPicture.Controls.Add(this.pbImage1);
            this.gbPicture.Controls.Add(this.pbImage);
            this.gbPicture.Location = new System.Drawing.Point(12, 12);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(374, 552);
            this.gbPicture.TabIndex = 0;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "图像显示";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "上个图像";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "当前图像";
            // 
            // pbImage1
            // 
            this.pbImage1.Location = new System.Drawing.Point(6, 331);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(346, 240);
            this.pbImage1.TabIndex = 1;
            this.pbImage1.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(6, 57);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(346, 240);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // gbSerialConfig
            // 
            this.gbSerialConfig.Controls.Add(this.label3);
            this.gbSerialConfig.Controls.Add(this.richTextBox1);
            this.gbSerialConfig.Controls.Add(this.btnOpen);
            this.gbSerialConfig.Controls.Add(this.btnSave);
            this.gbSerialConfig.Controls.Add(this.lblDataBits);
            this.gbSerialConfig.Controls.Add(this.cbbDataBits);
            this.gbSerialConfig.Controls.Add(this.lblStopBits);
            this.gbSerialConfig.Controls.Add(this.cbbStopBits);
            this.gbSerialConfig.Controls.Add(this.lblCheckBits);
            this.gbSerialConfig.Controls.Add(this.cbbCheckBits);
            this.gbSerialConfig.Controls.Add(this.lblBundRate);
            this.gbSerialConfig.Controls.Add(this.cbbBundRate);
            this.gbSerialConfig.Controls.Add(this.lblSerialID);
            this.gbSerialConfig.Controls.Add(this.cbbSerialID);
            this.gbSerialConfig.Location = new System.Drawing.Point(392, 12);
            this.gbSerialConfig.Name = "gbSerialConfig";
            this.gbSerialConfig.Size = new System.Drawing.Size(313, 552);
            this.gbSerialConfig.TabIndex = 1;
            this.gbSerialConfig.TabStop = false;
            this.gbSerialConfig.Text = "串口配置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "运行日志";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 376);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 170);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(24, 303);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 25);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存图像";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(21, 191);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(67, 15);
            this.lblDataBits.TabIndex = 10;
            this.lblDataBits.Text = "数据位：";
            // 
            // cbbDataBits
            // 
            this.cbbDataBits.FormattingEnabled = true;
            this.cbbDataBits.Location = new System.Drawing.Point(116, 188);
            this.cbbDataBits.Name = "cbbDataBits";
            this.cbbDataBits.Size = new System.Drawing.Size(121, 23);
            this.cbbDataBits.TabIndex = 9;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(21, 149);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(67, 15);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "停止位：";
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.FormattingEnabled = true;
            this.cbbStopBits.Location = new System.Drawing.Point(116, 146);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(121, 23);
            this.cbbStopBits.TabIndex = 7;
            // 
            // lblCheckBits
            // 
            this.lblCheckBits.AutoSize = true;
            this.lblCheckBits.Location = new System.Drawing.Point(21, 108);
            this.lblCheckBits.Name = "lblCheckBits";
            this.lblCheckBits.Size = new System.Drawing.Size(82, 15);
            this.lblCheckBits.TabIndex = 6;
            this.lblCheckBits.Text = "奇偶校验：";
            // 
            // cbbCheckBits
            // 
            this.cbbCheckBits.FormattingEnabled = true;
            this.cbbCheckBits.Location = new System.Drawing.Point(116, 105);
            this.cbbCheckBits.Name = "cbbCheckBits";
            this.cbbCheckBits.Size = new System.Drawing.Size(121, 23);
            this.cbbCheckBits.TabIndex = 5;
            // 
            // lblBundRate
            // 
            this.lblBundRate.AutoSize = true;
            this.lblBundRate.Location = new System.Drawing.Point(21, 68);
            this.lblBundRate.Name = "lblBundRate";
            this.lblBundRate.Size = new System.Drawing.Size(67, 15);
            this.lblBundRate.TabIndex = 4;
            this.lblBundRate.Text = "波特率：";
            // 
            // cbbBundRate
            // 
            this.cbbBundRate.FormattingEnabled = true;
            this.cbbBundRate.Location = new System.Drawing.Point(116, 65);
            this.cbbBundRate.Name = "cbbBundRate";
            this.cbbBundRate.Size = new System.Drawing.Size(121, 23);
            this.cbbBundRate.TabIndex = 3;
            // 
            // lblSerialID
            // 
            this.lblSerialID.AutoSize = true;
            this.lblSerialID.Location = new System.Drawing.Point(21, 29);
            this.lblSerialID.Name = "lblSerialID";
            this.lblSerialID.Size = new System.Drawing.Size(67, 15);
            this.lblSerialID.TabIndex = 2;
            this.lblSerialID.Text = "串口号：";
            // 
            // cbbSerialID
            // 
            this.cbbSerialID.FormattingEnabled = true;
            this.cbbSerialID.Location = new System.Drawing.Point(116, 26);
            this.cbbSerialID.Name = "cbbSerialID";
            this.cbbSerialID.Size = new System.Drawing.Size(121, 23);
            this.cbbSerialID.TabIndex = 1;
            this.cbbSerialID.DropDown += new System.EventHandler(this.cbbSerialID_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.usart_data_clear);
            this.groupBox1.Controls.Add(this.usart_send_Button);
            this.groupBox1.Controls.Add(this.usart_send_Ritchbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.usart_get_Ritchbox);
            this.groupBox1.Location = new System.Drawing.Point(711, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 552);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口数据";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "发送内容";
            // 
            // usart_data_clear
            // 
            this.usart_data_clear.Location = new System.Drawing.Point(192, 209);
            this.usart_data_clear.Name = "usart_data_clear";
            this.usart_data_clear.Size = new System.Drawing.Size(95, 25);
            this.usart_data_clear.TabIndex = 21;
            this.usart_data_clear.Text = "清除数据";
            this.usart_data_clear.UseVisualStyleBackColor = true;
            this.usart_data_clear.Click += new System.EventHandler(this.usart_data_clear_Click);
            // 
            // usart_send_Button
            // 
            this.usart_send_Button.Location = new System.Drawing.Point(16, 149);
            this.usart_send_Button.Name = "usart_send_Button";
            this.usart_send_Button.Size = new System.Drawing.Size(95, 25);
            this.usart_send_Button.TabIndex = 19;
            this.usart_send_Button.Text = "发送数据";
            this.usart_send_Button.UseVisualStyleBackColor = true;
            this.usart_send_Button.Click += new System.EventHandler(this.usart_send_Button_Click);
            // 
            // usart_send_Ritchbox
            // 
            this.usart_send_Ritchbox.Location = new System.Drawing.Point(16, 47);
            this.usart_send_Ritchbox.Name = "usart_send_Ritchbox";
            this.usart_send_Ritchbox.Size = new System.Drawing.Size(271, 96);
            this.usart_send_Ritchbox.TabIndex = 20;
            this.usart_send_Ritchbox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "数据日志";
            // 
            // usart_get_Ritchbox
            // 
            this.usart_get_Ritchbox.Location = new System.Drawing.Point(16, 237);
            this.usart_get_Ritchbox.Name = "usart_get_Ritchbox";
            this.usart_get_Ritchbox.Size = new System.Drawing.Size(271, 309);
            this.usart_get_Ritchbox.TabIndex = 19;
            this.usart_get_Ritchbox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSerialConfig);
            this.Controls.Add(this.gbPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "OV7725图像显示上位机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.gbPicture.ResumeLayout(false);
            this.gbPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbSerialConfig.ResumeLayout(false);
            this.gbSerialConfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPicture;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox gbSerialConfig;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.Label lblCheckBits;
        private System.Windows.Forms.ComboBox cbbCheckBits;
        private System.Windows.Forms.Label lblBundRate;
        private System.Windows.Forms.ComboBox cbbBundRate;
        private System.Windows.Forms.Label lblSerialID;
        private System.Windows.Forms.ComboBox cbbSerialID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox usart_get_Ritchbox;
        private System.Windows.Forms.Button usart_send_Button;
        private System.Windows.Forms.RichTextBox usart_send_Ritchbox;
        private System.Windows.Forms.Button usart_data_clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

