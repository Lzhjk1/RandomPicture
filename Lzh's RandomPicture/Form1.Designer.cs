namespace Lzh_s_RandomPicture
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxMsg = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMainServer = new System.Windows.Forms.TextBox();
            this.comboBoxServerList = new System.Windows.Forms.ComboBox();
            this.textBoxSelectedServerUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPictureQuantity = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownloadNewClient = new System.Windows.Forms.Button();
            this.panelNotification = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHideNotification = new System.Windows.Forms.Button();
            this.textBoxNotification = new System.Windows.Forms.RichTextBox();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerRefreshNumberRecord = new System.Windows.Forms.Timer(this.components);
            this.comboBoxChangeBG = new System.Windows.Forms.ComboBox();
            this.panelRandomMode = new System.Windows.Forms.Panel();
            this.panelSelectedMode = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFileList = new System.Windows.Forms.ComboBox();
            this.btnSwitchToRandomMode = new System.Windows.Forms.Button();
            this.btnSwitchToSelectedMode = new System.Windows.Forms.Button();
            this.panelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRandomMode.SuspendLayout();
            this.panelSelectedMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMsg.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.textBoxMsg.Location = new System.Drawing.Point(29, 17);
            this.textBoxMsg.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.ReadOnly = true;
            this.textBoxMsg.Size = new System.Drawing.Size(1739, 514);
            this.textBoxMsg.TabIndex = 10;
            this.textBoxMsg.Text = "";
            this.textBoxMsg.TextChanged += new System.EventHandler(this.textBoxMsg_TextChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.Enabled = false;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpen.FlatAppearance.BorderSize = 3;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold);
            this.btnOpen.Location = new System.Drawing.Point(29, 878);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(1739, 108);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 601);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片服务器：";
            // 
            // textBoxMainServer
            // 
            this.textBoxMainServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.textBoxMainServer.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textBoxMainServer.Location = new System.Drawing.Point(322, 544);
            this.textBoxMainServer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxMainServer.Name = "textBoxMainServer";
            this.textBoxMainServer.Size = new System.Drawing.Size(627, 47);
            this.textBoxMainServer.TabIndex = 4;
            this.textBoxMainServer.Text = "http://cn-zj-bgp-3.sakurafrp.com:18750/";
            // 
            // comboBoxServerList
            // 
            this.comboBoxServerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.comboBoxServerList.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBoxServerList.FormattingEnabled = true;
            this.comboBoxServerList.Location = new System.Drawing.Point(322, 601);
            this.comboBoxServerList.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxServerList.Name = "comboBoxServerList";
            this.comboBoxServerList.Size = new System.Drawing.Size(267, 47);
            this.comboBoxServerList.TabIndex = 5;
            this.comboBoxServerList.Text = "选择一个服务器";
            this.comboBoxServerList.TextChanged += new System.EventHandler(this.ServerSelected);
            // 
            // textBoxSelectedServerUrl
            // 
            this.textBoxSelectedServerUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.textBoxSelectedServerUrl.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textBoxSelectedServerUrl.Location = new System.Drawing.Point(603, 598);
            this.textBoxSelectedServerUrl.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxSelectedServerUrl.Name = "textBoxSelectedServerUrl";
            this.textBoxSelectedServerUrl.Size = new System.Drawing.Size(346, 47);
            this.textBoxSelectedServerUrl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(33, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = "图片数量：";
            // 
            // textBoxPictureQuantity
            // 
            this.textBoxPictureQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.textBoxPictureQuantity.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxPictureQuantity.Location = new System.Drawing.Point(287, 16);
            this.textBoxPictureQuantity.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxPictureQuantity.Name = "textBoxPictureQuantity";
            this.textBoxPictureQuantity.Size = new System.Drawing.Size(80, 55);
            this.textBoxPictureQuantity.TabIndex = 8;
            this.textBoxPictureQuantity.Text = "1";
            this.textBoxPictureQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnMinus.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnMinus.Location = new System.Drawing.Point(381, 16);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinus.Size = new System.Drawing.Size(86, 56);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnPlus.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnPlus.Location = new System.Drawing.Point(469, 16);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlus.Size = new System.Drawing.Size(86, 56);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 544);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "列表服务器：";
            // 
            // btnDownloadNewClient
            // 
            this.btnDownloadNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadNewClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDownloadNewClient.FlatAppearance.BorderSize = 3;
            this.btnDownloadNewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnDownloadNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadNewClient.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold);
            this.btnDownloadNewClient.Location = new System.Drawing.Point(1242, 544);
            this.btnDownloadNewClient.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnDownloadNewClient.Name = "btnDownloadNewClient";
            this.btnDownloadNewClient.Size = new System.Drawing.Size(526, 105);
            this.btnDownloadNewClient.TabIndex = 13;
            this.btnDownloadNewClient.Text = "下载新版";
            this.btnDownloadNewClient.UseVisualStyleBackColor = false;
            this.btnDownloadNewClient.Visible = false;
            this.btnDownloadNewClient.Click += new System.EventHandler(this.btnDownloadNewClient_Click);
            // 
            // panelNotification
            // 
            this.panelNotification.Controls.Add(this.label4);
            this.panelNotification.Controls.Add(this.btnHideNotification);
            this.panelNotification.Controls.Add(this.textBoxNotification);
            this.panelNotification.Location = new System.Drawing.Point(28, 20);
            this.panelNotification.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(1766, 976);
            this.panelNotification.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(807, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 82);
            this.label4.TabIndex = 2;
            this.label4.Text = "公告";
            // 
            // btnHideNotification
            // 
            this.btnHideNotification.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHideNotification.Location = new System.Drawing.Point(1687, 7);
            this.btnHideNotification.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnHideNotification.Name = "btnHideNotification";
            this.btnHideNotification.Size = new System.Drawing.Size(72, 72);
            this.btnHideNotification.TabIndex = 1;
            this.btnHideNotification.Text = "×";
            this.btnHideNotification.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnHideNotification.UseVisualStyleBackColor = true;
            this.btnHideNotification.Click += new System.EventHandler(this.btnHideNotification_Click);
            // 
            // textBoxNotification
            // 
            this.textBoxNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNotification.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.textBoxNotification.Location = new System.Drawing.Point(7, 108);
            this.textBoxNotification.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxNotification.Name = "textBoxNotification";
            this.textBoxNotification.Size = new System.Drawing.Size(1752, 859);
            this.textBoxNotification.TabIndex = 0;
            this.textBoxNotification.Text = "";
            this.textBoxNotification.TextChanged += new System.EventHandler(this.textBoxNotification_TextChanged);
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.Color.Transparent;
            this.btnInitialize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInitialize.FlatAppearance.BorderSize = 3;
            this.btnInitialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnInitialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialize.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.btnInitialize.Location = new System.Drawing.Point(954, 544);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(274, 105);
            this.btnInitialize.TabIndex = 15;
            this.btnInitialize.Text = "初始化";
            this.btnInitialize.UseVisualStyleBackColor = false;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(954, 459);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(758, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1114, 704);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timerRefreshNumberRecord
            // 
            this.timerRefreshNumberRecord.Interval = 120000;
            this.timerRefreshNumberRecord.Tick += new System.EventHandler(this.timerRefreshNumberRecord_Tick);
            // 
            // comboBoxChangeBG
            // 
            this.comboBoxChangeBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.comboBoxChangeBG.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBoxChangeBG.FormattingEnabled = true;
            this.comboBoxChangeBG.Location = new System.Drawing.Point(954, 657);
            this.comboBoxChangeBG.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxChangeBG.Name = "comboBoxChangeBG";
            this.comboBoxChangeBG.Size = new System.Drawing.Size(274, 47);
            this.comboBoxChangeBG.TabIndex = 16;
            this.comboBoxChangeBG.Text = "选择背景";
            this.comboBoxChangeBG.TextChanged += new System.EventHandler(this.comboBoxBGChanged);
            // 
            // panelRandomMode
            // 
            this.panelRandomMode.BackColor = System.Drawing.Color.Transparent;
            this.panelRandomMode.Controls.Add(this.label3);
            this.panelRandomMode.Controls.Add(this.btnMinus);
            this.panelRandomMode.Controls.Add(this.btnPlus);
            this.panelRandomMode.Controls.Add(this.textBoxPictureQuantity);
            this.panelRandomMode.Location = new System.Drawing.Point(35, 657);
            this.panelRandomMode.Name = "panelRandomMode";
            this.panelRandomMode.Size = new System.Drawing.Size(566, 83);
            this.panelRandomMode.TabIndex = 17;
            // 
            // panelSelectedMode
            // 
            this.panelSelectedMode.BackColor = System.Drawing.Color.Transparent;
            this.panelSelectedMode.Controls.Add(this.label5);
            this.panelSelectedMode.Controls.Add(this.comboBoxFileList);
            this.panelSelectedMode.Location = new System.Drawing.Point(35, 657);
            this.panelSelectedMode.Name = "panelSelectedMode";
            this.panelSelectedMode.Size = new System.Drawing.Size(874, 143);
            this.panelSelectedMode.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(565, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 57);
            this.label5.TabIndex = 19;
            this.label5.Text = "指定文件模式";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxFileList
            // 
            this.comboBoxFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.comboBoxFileList.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBoxFileList.FormattingEnabled = true;
            this.comboBoxFileList.Location = new System.Drawing.Point(7, 88);
            this.comboBoxFileList.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxFileList.Name = "comboBoxFileList";
            this.comboBoxFileList.Size = new System.Drawing.Size(857, 47);
            this.comboBoxFileList.TabIndex = 19;
            this.comboBoxFileList.Text = "选择一个文件";
            // 
            // btnSwitchToRandomMode
            // 
            this.btnSwitchToRandomMode.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchToRandomMode.Enabled = false;
            this.btnSwitchToRandomMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSwitchToRandomMode.FlatAppearance.BorderSize = 3;
            this.btnSwitchToRandomMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnSwitchToRandomMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchToRandomMode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSwitchToRandomMode.Location = new System.Drawing.Point(28, 810);
            this.btnSwitchToRandomMode.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSwitchToRandomMode.Name = "btnSwitchToRandomMode";
            this.btnSwitchToRandomMode.Size = new System.Drawing.Size(315, 60);
            this.btnSwitchToRandomMode.TabIndex = 19;
            this.btnSwitchToRandomMode.Text = "随机模式";
            this.btnSwitchToRandomMode.UseVisualStyleBackColor = false;
            this.btnSwitchToRandomMode.Click += new System.EventHandler(this.btnSwitchToRandomMode_Click);
            // 
            // btnSwitchToSelectedMode
            // 
            this.btnSwitchToSelectedMode.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchToSelectedMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSwitchToSelectedMode.FlatAppearance.BorderSize = 3;
            this.btnSwitchToSelectedMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnSwitchToSelectedMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchToSelectedMode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSwitchToSelectedMode.Location = new System.Drawing.Point(368, 810);
            this.btnSwitchToSelectedMode.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSwitchToSelectedMode.Name = "btnSwitchToSelectedMode";
            this.btnSwitchToSelectedMode.Size = new System.Drawing.Size(315, 60);
            this.btnSwitchToSelectedMode.TabIndex = 21;
            this.btnSwitchToSelectedMode.Text = "指定模式";
            this.btnSwitchToSelectedMode.UseVisualStyleBackColor = false;
            this.btnSwitchToSelectedMode.Click += new System.EventHandler(this.btnSwitchToSelectedMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(214)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1800, 1012);
            this.Controls.Add(this.panelNotification);
            this.Controls.Add(this.btnSwitchToSelectedMode);
            this.Controls.Add(this.btnSwitchToRandomMode);
            this.Controls.Add(this.panelRandomMode);
            this.Controls.Add(this.panelSelectedMode);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.comboBoxServerList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSelectedServerUrl);
            this.Controls.Add(this.textBoxMainServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDownloadNewClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.comboBoxChangeBG);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Lzh\'s RandomPicture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelNotification.ResumeLayout(false);
            this.panelNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRandomMode.ResumeLayout(false);
            this.panelRandomMode.PerformLayout();
            this.panelSelectedMode.ResumeLayout(false);
            this.panelSelectedMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxMsg;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMainServer;
        private System.Windows.Forms.ComboBox comboBoxServerList;
        private System.Windows.Forms.TextBox textBoxSelectedServerUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPictureQuantity;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btnDownloadNewClient;
        private System.Windows.Forms.Panel panelNotification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHideNotification;
        private System.Windows.Forms.RichTextBox textBoxNotification;
        public System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Timer timerRefreshNumberRecord;
        private System.Windows.Forms.ComboBox comboBoxChangeBG;
        private System.Windows.Forms.Panel panelRandomMode;
        private System.Windows.Forms.Panel panelSelectedMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFileList;
        public System.Windows.Forms.Button btnSwitchToRandomMode;
        public System.Windows.Forms.Button btnSwitchToSelectedMode;
    }
}

