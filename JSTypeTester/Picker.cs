using DataManager;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JSTypeTester
{
    public partial class Picker : Form
    {
        private User currentSession = null;
        public Picker(User user)
        {
            this.currentSession = user;
            InitializeComponent();
            SetIntervalDataSource();

            this.txtRegisterNumber.Text = user.RegisterNumber;
        }

        private void SetIntervalDataSource()
        {
            List<Intervals> intervals = SpeedDataHandler.GetInstance().GetSpeedIntervals();
            this.cmbTime.DataSource = intervals;
            this.cmbTime.SelectedItem = intervals[1];
            this.cmbTime.ValueMember = "Interval";
            this.cmbTime.DisplayMember = "Name";
        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            ProcessParameters();
            if(this.currentSession.InputType == InputType.HardCopy)
            {
                //Begin Test
            }
            else
            {
                //Open Speed Selection Window
            }
        }

        private void ProcessParameters()
        {
            this.currentSession.Interval = (Intervals) this.cmbTime.SelectedItem;
            this.currentSession.Language = this.radLangEnglish.Checked ? Language.English : Language.Malayalam;
            this.currentSession.InputType = this.radInputComputer.Checked ? InputType.Computer : InputType.HardCopy;
            this.currentSession.Stream = this.radStreamLower.Checked ? Stream.Higher : Stream.Lower;
        }

        private void radInputHardCopy_Click(object sender, EventArgs e)
        {
            SetButtonText();
        }
        private void radInputComputer_Click(object sender, EventArgs e)
        {
            SetButtonText();
        }

        private void SetButtonText()
        {
            if(radInputHardCopy.Checked)
            {
                btnBeginTest.Text = "Begin Test";
            }
            else
            {
                btnBeginTest.Text = "Choose Speed";
            }                
        }

       
    }
}
