using DataManager;
using Entities;
using SpeedAnalyzer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace JSTypeTester
{
    public partial class TypeTester : Form
    {
        private User currentSessionUser = null;

        private Timer timer;

        private Timer wordCountTimer;

        private Stopwatch watch;

        private int totalTypes = 0;

        private long totalIntervalInMilliseconds = 0;

        public TypeTester(User user)
        {
            this.currentSessionUser = user;
            InitializeComponent();

            this.txtRegisterNumber.Text = user.RegisterNumber;
            this.txtLanguage.Text = user.Language.ToString().ToLower();
            this.txtStream.Text = user.Stream.ToString().ToLower();

            if (this.currentSessionUser.InputType == InputType.HardCopy)
            {
                this.speedSplitContainer.Panel1.Hide();
                this.speedSplitContainer.SplitterDistance = 0;
            }
            else
            {
                this.rTxtInputSpeed.Text = this.currentSessionUser.Speed.SpeedText;
                this.speedSplitContainer.Panel1.Show();
                this.speedSplitContainer.SplitterDistance = 350;
            }

            
            BeginTimer();
        }

        private void BeginTimer()
        {
            this.currentSessionUser.Result = new Result();
            this.currentSessionUser.Result.StartTime = DateTime.Now;
            this.currentSessionUser.Result.ExpectedEndTime = this.currentSessionUser.Result.StartTime.AddMinutes(this.currentSessionUser.Interval.Interval);

            this.totalIntervalInMilliseconds = ((this.currentSessionUser.Interval.Interval) * 60) * 1000;
            //this.currentSessionUser.Result.ExpectedEndTime = this.currentSessionUser.Result.StartTime.AddSeconds(this.currentSessionUser.Interval.Interval);

            watch = System.Diagnostics.Stopwatch.StartNew();
            timer = new Timer();
            timer.Tick += new EventHandler(TimerTickHandler);
            timer.Interval = 500; // in miliseconds
            timer.Start();

            wordCountTimer = new Timer();
            wordCountTimer.Tick += new EventHandler(WordCountTimerTick);
            wordCountTimer.Interval = 2000;
            wordCountTimer.Start();
        }

        private void WordCountTimerTick(object sender, EventArgs e)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds);
            double totalSeconds = (watch.ElapsedMilliseconds / 1000);
            double characterPerSeconds = this.totalTypes / totalSeconds;
            this.lblTotalKeyPress.Text = string.Format("Total Keypress: {0}", this.totalTypes);
            if (totalSeconds > 0)
            {
                this.lblCharacterPerMinute.Text = string.Format("Character Per Minute: {0:0.##}", (characterPerSeconds * 60));
            }
        }

        private void TimerTickHandler(object sender, EventArgs e)
        {
            UpdateTimerClock();

            if(DateTime.Now >= this.currentSessionUser.Result.ExpectedEndTime)
            {
                StopTimers();
                UpdateTimerClock();
                StopTestAndGetResult();
            }

        }

        private void StopTimers()
        {
            timer.Stop();
            timer.Dispose();

            wordCountTimer.Stop();
            wordCountTimer.Dispose();

            watch.Stop();
        }

        private void UpdateTimerClock()
        {
            TimeSpan t = TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds);
            string elapsedTime = string.Format("{0:D2}:{1:D2}",t.Minutes,t.Seconds);
            this.lblElapsedTime.Text = elapsedTime;

            long remainingMilliSeconds = this.totalIntervalInMilliseconds - watch.ElapsedMilliseconds;
            t = TimeSpan.FromMilliseconds(remainingMilliSeconds);
            elapsedTime = string.Format("Remaining Time: {0:D2}:{1:D2}", t.Minutes, t.Seconds);
            this.lblRemainingTime.Text = elapsedTime;
        }

        private void StopTestAndGetResult()
        {
            this.rTxtUserSpeed.Enabled = false;
            string speedName = "_";
            Speed speed = new Speed(speedName);
            speed.SpeedText = this.rTxtUserSpeed.Text;

            speed = SpeedPropertyExtractor.GetSpeedProperties(speed);
            
        }

        #region events
        private void TypeTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "JS Speed Tester", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return;
            e.Cancel = true;
        }

        #endregion

        private void rTxtUserSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            this.totalTypes++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to stop this test?", "JS Speed Tester", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();

                new Picker(this.currentSessionUser).ShowDialog();

                this.Close();
                this.Dispose();
            }
        }
    }
}
