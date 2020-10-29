using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace JSTypeTester
{
    public partial class Tester : Form
    {
        private Thread tread;
        private string registerNumber;
        private string lanugage;

        public Tester(string regNum, string strm, string lang)
        {
            this.InitializeComponent();
            this.registerNumber = regNum;
            this.lanugage = lang;
            this.lblRegNum.Text = regNum;
            this.lblLanguange.Text = lang;
            this.lblStream.Text = strm;
        }

        public void UpdateLog(string input)
        {
            this.lblRTL.Text = input;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Tester_Load(object sender, EventArgs e)
        {
            if (this.lanugage == "English")
            {
                this.txtSpeed.SelectionFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            }
            else
            {
                this.myProcess = new Process();
                this.myProcess.StartInfo.CreateNoWindow = true;
                this.myProcess.StartInfo.UseShellExecute = true;
                this.myProcess.StartInfo.WorkingDirectory = "C:\\ISM300\\";
                this.myProcess.StartInfo.FileName = "winkbmgr.exe";
                this.myProcess.StartInfo.Arguments = "";
                this.myProcess.Start();
                Thread.Sleep(1000);
            }
            this.tread = new Thread(new ThreadStart(this.StartClockTicks));
            this.tread.Start();
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to close changes Speed Test", "JS Speed Tester", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            e.Cancel = true;
        }

        public void StartClockTicks()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int num1 = 600000;
            while (stopwatch.ElapsedMilliseconds <= (long)num1)
            {
                Thread.Sleep(10);
                if (!Application.OpenForms.OfType<Tester>().Any<Tester>())
                {
                    this.tread.Abort();
                    break;
                }
                TimeSpan elapsed = stopwatch.Elapsed;
                int num2 = elapsed.Minutes;
                string str1 = num2.ToString("D2");
                elapsed = stopwatch.Elapsed;
                num2 = elapsed.Seconds;
                string str2 = num2.ToString("D2");
                this.updateUITimer(str1 + ":" + str2);
            }
            int num3;
            //this.Invoke((Delegate)(() => num3 = (int)MessageBox.Show((IWin32Window)this, "Time Over!!!")));
            //this.Invoke((Delegate)(() =>
            //{
            //    this.lblTypedCharacter.Text = this.txtSpeed.Text.Length.ToString();
            //    this.saveDocument(this.txtSpeed.Text);
            //    this.txtSpeed.Enabled = false;
            //}));
            //this.tread.Abort();
        }

        private void saveDocument(string text)
        {
            DateTime now = DateTime.Now;
            string path = "D:\\Speeds\\" + this.lanugage + "\\" + this.registerNumber;
            string str = "\\" + (object)now.Day + "_" + (object)now.Month + "_" + (object)now.Year + "_" + (object)now.Hour + "_" + (object)now.Minute + "_" + (object)now.Second + ".txt";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            StreamWriter text1 = File.CreateText(path + str);
            text1.Write(text);
            text1.Close();
            if (!(this.lanugage == "Malayalam"))
                return;
            this.myProcess.Kill();
        }

        private void updateUITimer(string ElapsedTime)
        {
            this.lblRTL.BeginInvoke((Delegate)new Tester.InvokeDelegate(this.UpdateLog), (object)ElapsedTime);
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            int num = (int)MessageBox.Show("The form will now be closed.", "Time Elapsed");
            this.Close();
        }

        private void lnkLblCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int num = (int)MessageBox.Show("Developed by: JISHNU.S # 9048911293\nContact me: jishnutkl@gmail.com\nSoftware developed for JS Typewriting and computer center");
        }

        public delegate void InvokeDelegate(string input);
    }
}
