using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Security.Policy;
using System.Diagnostics;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Lzh_s_RandomPicture {
    public partial class Form1 : Form {
        string ClientVersion = "0156";
        #region 变量定义
        struct structTripleValue {
            public string value1 { get; set; }
            public string value2 { get; set; }
            public string value3 { get; set; }
            public structTripleValue(string Value1 = null, string Value2 = null, string Value3 = null) { value1 = Value1; value2 = Value2; value3 = Value3; }
        }//三值容器，方便BW传递参数
        Dictionary<string, string> dcServerList = new Dictionary<string, string>();
        Dictionary<string, bool> isFileLoadComplete = new Dictionary<string, bool>();
        Dictionary<string, List<string>> dcFileList = new Dictionary<string, List<string>>();
        Dictionary<string, bool> dcServerState = new Dictionary<string, bool>();
        List<int> listNumberRecorder = new List<int>();
        List<string> listNotificationToShow = new List<string>();
        TextBox tb;
        Random rd = new Random();
        bool error1 = false;
        bool error2 = false;
        bool errorDownloadFileList = false;
        bool errorCheckUpdate = false;
        bool isMainServerOnline = false;
        bool isNeedUpdate = false;
        bool isShowNotification = false;
        #endregion
        #region 不用管的代码
        public Form1() {
            InitializeComponent();
        }
        #endregion
        #region 初始化
        public void Form1_Load(object sender, EventArgs e) {
            #region 解决缩放问题
            Font font96 = new Font("微软雅黑", 20f, FontStyle.Regular);
            Font font120 = new Font("微软雅黑", 18f, FontStyle.Regular);
            Font font144 = new Font("微软雅黑", 16f, FontStyle.Regular);
            Font font192 = new Font("微软雅黑", 14f, FontStyle.Regular);
            float dpiX;
            Graphics graphics = this.CreateGraphics();
            dpiX = graphics.DpiX;
            switch (dpiX) {
                case 96f: textBoxNotification.Font = font96; textBoxMsg.Font = font96; break;
                case 120f: textBoxNotification.Font = font120; textBoxMsg.Font = font120; break;
                case 144f: textBoxNotification.Font = font144; textBoxMsg.Font = font144; break;
                case 192f: textBoxNotification.Font = font192; textBoxMsg.Font = font192; break;
            }
            #endregion
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
            this.MaximizeBox = false;
            tb = textBoxPictureQuantity;
            if (!Directory.Exists(".\\RP_Data"))
                Directory.CreateDirectory(".\\RP_Data");
            this.Text = "Lzh's RandomPicture ver." + ClientVersion;
            #region 显示初始信息
            string InitialNotification = "---------------------------|这是LZH的随机图片生成器|确保列表服务器地址正确|点击初始化获得服务器列表和各服务器的图片列表|点击打开以浏览器模式打开图片的网页链接|因技术原因没法做到图片自动下载|---------------------------|图片是存储在服务器上的|服务器可由任何人建立|随机到的图片由服务器上的图片中选出|如果你建立了服务器|告诉我|我会把你的服务器加进服务器列表|---------------------------|本程序还附带一个服务端|在服务端压缩包内有相关使用教程|---------------------------|服务器建立借助了SakuraFrp的内网穿透服务|他们的服务免费|只要不大量使用|感谢SakuraFrp|---------------------------";
            string x = "不要放在C盘运行！！！";
            for (int i = 0; i < 3; i++) {
                RichTextBoxExtension.AppendTextColorful(textBoxNotification, x, Color.Yellow, true, 4);
            }

            List<string> listInitialNotification = new List<string>();
            listInitialNotification = InitialNotification.Split('|').ToList();
            foreach (var item in listInitialNotification) {
                RichTextBoxExtension.AppendTextColorful(textBoxNotification, item, Color.White, true);
            }
            #endregion
            RichTextBoxExtension.AppendTextColorful(textBoxMsg, "确认列表服务器地址后点击", Color.Yellow, false);
            RichTextBoxExtension.AppendTextColorful(textBoxMsg, " 初始化 ", Color.Blue, false);
            RichTextBoxExtension.AppendTextColorful(textBoxMsg, "按钮.", Color.Yellow, true);
        }

        // 准备使用，封装重用代码
        String LoadFileFormServer(String serverUrl, String fileName) {
            String strServerList;
            try {
                WebRequest request = WebRequest.Create(serverUrl + fileName);
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                strServerList = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch {
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "ServerList读取错误，将读取本地缓存.", Color.Red, true);
                return "error";
            }
            return strServerList;
        }
        bool SaveFile(String str, String fileName) {
            bool isError = false;
            FileStream fs = null;
            StreamWriter sw = null;
            try {
                fs = new FileStream(".\\RP_Data\\" + fileName, FileMode.OpenOrCreate);
                fs.Seek(0, SeekOrigin.Begin);
                fs.SetLength(0);
                sw = new StreamWriter(fs);
                sw.Write(str);
            }
            catch (Exception ex) {
                isError= true;
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "存储" + fileName + "时出现错误！", Color.Red, true);
            }
            finally {
                sw.Dispose();
                fs.Dispose();
            }
            return isError;
        }


        #region 下载和读取ServerList部分
        public void LoadServerList(bool isMainServerOnline) {
            string strServerList = "";
            bool error = false;
            if (isMainServerOnline) {
                // strServerList = LoadFileFormServer(textBoxMainServer.Text, "ServerList.txt");
                #region WEB操作
                try {
                    WebRequest request = WebRequest.Create(textBoxMainServer.Text + "ServerList.txt");
                    request.Credentials = CredentialCache.DefaultCredentials;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Console.WriteLine(response.StatusDescription);
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    strServerList = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                }
                catch {
                    error = true;
                    RichTextBoxExtension.AppendTextColorful(textBoxMsg, "ServerList读取错误，将读取本地缓存.", Color.Red, true);
                }
                #endregion
                if (error) {
                    error = false;
                }
                else {
                    FileStream fs = new FileStream(".\\RP_Data\\ServerList.txt", FileMode.OpenOrCreate);
                    fs.Seek(0, SeekOrigin.Begin);
                    fs.SetLength(0);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(strServerList);
                    sw.Dispose();
                    fs.Dispose();
                }
            }

            FileStream fs1 = new FileStream(".\\RP_Data\\ServerList.txt", FileMode.OpenOrCreate);
            StreamReader sr1 = new StreamReader(fs1);
            strServerList = sr1.ReadToEnd();
            List<string> list1 = Regex.Split(strServerList, "\\r\\n", RegexOptions.IgnoreCase).ToList();
            list1.Remove("");
            List<string> list2 = new List<string>();
            foreach (var element in list1) {
                list2 = list2.Concat(element.Split('=')).ToList();
            }
            for (int i = 0; i < list2.Count(); i++) {
                //单数
                if (i % 2 == 0) {
                    dcServerList.Add(list2[i], list2[i + 1]); ;
                }
            }
            foreach (var element in dcServerList) {
                comboBoxServerList.Items.Add(element.Key);
                if (!Directory.Exists(".\\RP_Data\\" + element.Key))
                    Directory.CreateDirectory(".\\RP_Data\\" + element.Key);
            }
        }
        #endregion
        #region FileList更新检查
        public void CheckUpdate() {
            foreach (var element in dcServerList) {
                if (dcServerState[element.Key]) {
                    string clientVersion = "";
                    string serverVersion = "";
                    string strFileList = "";
                    if (File.Exists(".\\RP_Data\\" + element.Key + "\\FileList.txt")) {
                        FileStream fs = new FileStream(".\\RP_Data\\" + element.Key + "\\FileList.txt", FileMode.Open);
                        StreamReader sr = new StreamReader(fs);
                        clientVersion = sr.ReadLine();
                        sr.Dispose();
                        fs.Dispose();
                    }
                    try {
                        #region WEB操作
                        WebRequest request = WebRequest.Create(element.Value + "Version.txt");
                        request.Credentials = CredentialCache.DefaultCredentials;
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Console.WriteLine(response.StatusDescription);
                        Stream dataStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(dataStream);
                        serverVersion = reader.ReadToEnd();
                        reader.Close();
                        dataStream.Close();
                        response.Close();
                        #endregion
                    }
                    catch {
                        RichTextBoxExtension.AppendTextColorful(textBoxMsg, "位于CheckUpdate函数的第一个Web操作出现问题.", Color.Red, true);
                        return;
                    }
                    clientVersion = clientVersion.Replace("\r\n", "");
                    serverVersion = serverVersion.Replace("\r\n", "");
                    if (!(clientVersion == serverVersion)) {
                        try {
                            #region WEB操作
                            WebRequest request = WebRequest.Create(element.Value + "FileList.txt");
                            request.Credentials = CredentialCache.DefaultCredentials;
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                            Console.WriteLine(response.StatusDescription);
                            Stream dataStream = response.GetResponseStream();
                            StreamReader reader = new StreamReader(dataStream);
                            strFileList = reader.ReadToEnd();
                            reader.Close();
                            dataStream.Close();
                            response.Close();
                            #endregion
                        }
                        catch {
                            RichTextBoxExtension.AppendTextColorful(textBoxMsg, "位于CheckUpdate函数的第二个Web操作出现问题.", Color.Red, true);
                            return;
                        }
                        FileStream fs = new FileStream(".\\RP_Data\\" + element.Key + "\\FileList.txt", FileMode.OpenOrCreate);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.Write(strFileList);
                        sw.Dispose();

                    }
                }


            }

        }



        #endregion
        #region 加载FileList
        public void LoadFileList() {
            foreach (var element in dcServerList) {
                if (dcServerState[element.Key]) {
                    FileStream fs = new FileStream(".\\RP_Data\\" + element.Key + "\\FileList.txt", FileMode.OpenOrCreate);
                    StreamReader sr = new StreamReader(fs);
                    List<string> list = Regex.Split(sr.ReadToEnd(), "\\r\\n", RegexOptions.IgnoreCase).ToList();
                    list.RemoveAt(0);
                    dcFileList.Add(element.Key, list);
                }
            }
        }
        #endregion
        #region 检查服务器状态
        public void CheckServerState() {
            foreach (var element in dcServerList) {
                bool isOnline = false;
                try {
                    #region WEB操作
                    WebRequest request = WebRequest.Create(element.Value + "Version.txt");
                    request.Credentials = CredentialCache.DefaultCredentials;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Console.WriteLine(response.StatusDescription);
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string test = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                    isOnline = true;
                    RichTextBoxExtension.AppendTextColorful(textBoxMsg, "服务器：" + element.Key + "---", Color.Yellow, false);
                    RichTextBoxExtension.AppendTextColorful(textBoxMsg, "在线", Color.FromArgb(112, 255, 125), true);

                    #endregion
                }
                catch {
                    RichTextBoxExtension.AppendTextColorful(textBoxMsg, "服务器：" + element.Key + "---", Color.Yellow, false);
                    RichTextBoxExtension.AppendTextColorful(textBoxMsg, "离线", Color.Red, true);
                }
                dcServerState.Add(element.Key, isOnline);
            }

        }
        #endregion
        #region 检查主服务器状态
        public bool CheckMainServerState() {
            try {
                #region WEB操作
                WebRequest request = WebRequest.Create(textBoxMainServer.Text + "Version.txt");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string test = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "主服务器---", Color.Yellow, false);
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "在线", Color.FromArgb(112, 255, 125), true);
                return true;
                #endregion
            }
            catch {
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "主服务器---", Color.Yellow, false);
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "离线", Color.Red, true);
                return false;
            }

        }
        #endregion
        #region 检查程序更新
        public void CheckCilentUpdate(bool isOnline) {
            if (isOnline) {
                #region WEB操作
                WebRequest request = WebRequest.Create(textBoxMainServer.Text + "ClientVersion.txt");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                if (!(ClientVersion == responseFromServer)) {
                    isNeedUpdate = true;
                }

                #endregion

            }

        }
        #endregion
        #region 检查公告信息
        public void CheckNotification(bool isOnline) {
            if (isOnline) {
                #region WEB操作
                WebRequest request = WebRequest.Create(textBoxMainServer.Text + "Notification.txt");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                List<string> list = Regex.Split(responseFromServer, "\\r\\n", RegexOptions.IgnoreCase).ToList();
                if (int.Parse(list[0]) == 1)
                    isShowNotification = true;
                list.RemoveAt(0);
                listNotificationToShow = list;
                #endregion
            }
        }

        public void ShowNotification() {
            if (isShowNotification) {
                panelNotification.Visible = true;
                foreach (var element in listNotificationToShow) {
                    RichTextBoxExtension.AppendTextColorful(textBoxNotification, element, Color.Yellow, true);
                }
            }
        }
        #endregion
        #region 为防止开启界面时间过久而设立的开始程序时后台运行初始化项目



        public void Initialize() {
            RichTextBoxExtension.AppendTextColorful(textBoxMsg, "请等待初始化", Color.Yellow, true);
            using (BackgroundWorker bw = new BackgroundWorker()) {
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_InitializeCompleted);
                bw.DoWork += new DoWorkEventHandler(bw_Initialize);
                bw.RunWorkerAsync();
            }
        }

        private void bw_Initialize(object sender, DoWorkEventArgs e) {
            isMainServerOnline = CheckMainServerState();
            LoadServerList(isMainServerOnline);
            CheckServerState();
            CheckCilentUpdate(isMainServerOnline);
            CheckUpdate();
            CheckNotification(isMainServerOnline);
        }

        private void bw_InitializeCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (isNeedUpdate) {
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "有新版本，请点击右下按钮下载并替换同名文件.", Color.Yellow, true);
                btnDownloadNewClient.Visible = true;
            }
            LoadFileList();
            ShowNotification();
            Thread.Sleep(dcServerList.Count * 700);
            RichTextBoxExtension.AppendTextColorful(textBoxMsg, "初始化完成.", Color.Green, true);
        }

        #endregion
        #endregion

        #region 其他方法
        private void btnMinus_Click(object sender, EventArgs e) {
            short pictureQuantity = short.Parse(tb.Text);
            if (!(pictureQuantity == 1)) {
                pictureQuantity--;
                textBoxPictureQuantity.Text = pictureQuantity.ToString();
            }

        }

        private void btnPlus_Click(object sender, EventArgs e) {
            short pictureQuantity = short.Parse(tb.Text);
            if (!(pictureQuantity == 10)) {
                pictureQuantity++;
                textBoxPictureQuantity.Text = pictureQuantity.ToString();
            }
        }
        #endregion
        #region 选择服务器选框
        public void ServerSelected(object sender, EventArgs e) {
            string serverName = comboBoxServerList.Text;
            RichTextBoxExtension.AppendTextColorful(textBoxMsg, "已选择服务器：" + serverName + "---", Color.Yellow, false);
            if (dcServerState[serverName]) {
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "在线", Color.FromArgb(112, 255, 125), true);
                btnOpen.Enabled = true;
            }
            else {
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "离线", Color.Red, true);
                btnOpen.Enabled = false;
            }
            textBoxSelectedServerUrl.Text = dcServerList[comboBoxServerList.Text];
        }

        #endregion
        #region 下载文件（未使用）
        public void LoadFile(string serverName, string file, bool isSpecificOperation = false, string specificFilePath = "") {
            if (isSpecificOperation) {

            }
            else {
                string urlPath = dcServerList[serverName] + file;
                structTripleValue TV = new structTripleValue(serverName, urlPath, file);
                #region 多线程操作
                using (BackgroundWorker bw = new BackgroundWorker()) {
                    bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_LoadFileCompleted);
                    bw.DoWork += new DoWorkEventHandler(bw_LoadFile);
                    bw.RunWorkerAsync(TV);
                }
            }

            #endregion
        }

        public void bw_LoadFile(object sender, DoWorkEventArgs e) {

            string url = ((structTripleValue)e.Argument).value2;
            #region WEB操作
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            structTripleValue DV = new structTripleValue(responseFromServer, ((structTripleValue)e.Argument).value1, ((structTripleValue)e.Argument).value3);
            e.Result = DV;
            #endregion
        }

        public void bw_LoadFileCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (error2) {
                //错误
                error2 = false;
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, this.Name + ":更新失败，服务器离线或错误的网址，将使用本地缓存。", Color.FromArgb(255, 0, 0), true);
            }
            else {
                structTripleValue DV = (structTripleValue)e.Result;
                if (DV.value1 == "Main") {
                    FileStream fs = new FileStream(".\\" + DV.value3, FileMode.Open);
                    byte[] data = Encoding.UTF8.GetBytes(DV.value1);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                    fs.Dispose();
                }
                else {
                    FileStream fs = new FileStream(".\\RP_Data\\" + DV.value2 + "\\" + DV.value3, FileMode.OpenOrCreate);
                    byte[] data = Encoding.UTF8.GetBytes(DV.value1);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                    fs.Dispose();
                }

            }
        }
        #endregion
        #region 按键：打开
        private void btnOpen_Click(object sender, EventArgs e) {
            string serverName = comboBoxServerList.Text;
            if (!(serverName == "选择一个服务器")) {
                List<string> currentFileList = dcFileList[serverName];
                for (int i = 0; i < int.Parse(textBoxPictureQuantity.Text); i++) {
                    while (true)//防止短时间出现重复选项
                    {
                        int rdNumber = rd.Next(0, currentFileList.Count);
                        if (!listNumberRecorder.Contains(rdNumber)) {
                            listNumberRecorder.Add(rdNumber);
                            break;
                        }
                    }
                    string file = currentFileList[rd.Next(0, currentFileList.Count)];
                    string url = dcServerList[serverName] + file;
                    file = file.Replace("\\Pictures\\", "");
                    RichTextBoxExtension.AppendTextColorful(textBoxMsg, "打开文件：" + file, Color.FromArgb(62, 174, 214), true);
                    System.Diagnostics.Process.Start("explorer.exe", url);
                }
            }
            else {
                RichTextBoxExtension.AppendTextColorful(textBoxMsg, "请选择服务器", Color.Yellow, true);
            }
        }
        #endregion

        private void textBoxMsg_TextChanged(object sender, EventArgs e) {
            textBoxMsg.ScrollToCaret();
        }

        private void btnDownloadNewClient_Click(object sender, EventArgs e) {
            btnDownloadNewClient.Visible = false;
            System.Diagnostics.Process.Start("explorer.exe", textBoxMainServer.Text + "Lzh'sRandomPicture.exe");
        }

        private void btnHideNotification_Click(object sender, EventArgs e) {
            panelNotification.Visible = false;
        }

        private void btnReload_Click(object sender, EventArgs e) {
            Form1_Load(new object(), new EventArgs());
        }

        private void btnInitialize_Click(object sender, EventArgs e) {
            Initialize();
            textBoxNotification.Clear();
            btnInitialize.Visible = false;
        }

        private void textBoxNotification_TextChanged(object sender, EventArgs e) {

        }

        private void timerRefreshNumberRecord_Tick(object sender, EventArgs e) {
            listNumberRecorder.Clear();
        }

        private void comboBoxBGChanged(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void btnSwitchToRandomMode_Click(object sender, EventArgs e) {
            btnSwitchToRandomMode.Enabled = false;
            btnSwitchToSelectedMode.Enabled = true;
            panelRandomMode.Visible = true;
            panelSelectedMode.Visible = false;
        }

        private void btnSwitchToSelectedMode_Click(object sender, EventArgs e) {
            btnSwitchToSelectedMode.Enabled = false;
            btnSwitchToRandomMode.Enabled = true;
            panelRandomMode.Visible = false;
            panelSelectedMode.Visible = true;
        }
    }
    //彩色输出扩展
    public static class RichTextBoxExtension {
        static Font fontS = new Font("微软雅黑", 8f, FontStyle.Regular);
        static Font fontM = new Font("微软雅黑", 14f, FontStyle.Regular);
        static Font fontL = new Font("微软雅黑", 20f, FontStyle.Regular);
        static Font fontXL = new Font("微软雅黑", 25f, FontStyle.Regular);
        public static void AppendTextColorful(this RichTextBox rtBox, string text, Color color, bool addNewLine = true, int size = 2) {
            if (addNewLine) {
                text += Environment.NewLine;
            }
            rtBox.SelectionStart = rtBox.TextLength;
            rtBox.SelectionLength = 0;
            rtBox.SelectionColor = color;
            switch (size) {
                case 1: rtBox.SelectionFont = fontS; break;
                case 2: rtBox.SelectionFont = fontM; break;
                case 3: rtBox.SelectionFont = fontL; break;
                case 4: rtBox.SelectionFont = fontXL; break;
            }
            rtBox.AppendText(text);
            rtBox.SelectionColor = rtBox.ForeColor;
        }
    }
}
