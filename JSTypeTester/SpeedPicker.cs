using DataManager;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace JSTypeTester
{
    public partial class SpeedPicker : Form
    {
        private User currentSession = null;
        public SpeedPicker(User user)
        {
            this.currentSession = user;
            InitializeComponent();

            this.txtLanguage.Text = this.currentSession.Language.ToString();
            this.txtStream.Text = this.currentSession.Stream.ToString();

            LoadSpeeds();
        }

        private void LoadSpeeds()
        {
            List<Speed> speeds = SpeedDataHandler.GetInstance().LoadSpeeds(this.currentSession.Language, this.currentSession.Stream);
            this.cmbSpeed.DataSource = speeds;
            this.cmbSpeed.DisplayMember = "Name";
        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            this.Hide();

            new TypeTester(this.currentSession).ShowDialog();

            this.Close();
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            Speed speed = (Speed) cmbSpeed.SelectedItem;
            speed = SpeedDataHandler.GetInstance().LoadSpeedMetaData(speed);
            speed.WordsPerMinute = speed.Words / this.currentSession.Interval.Interval;

            this.txtParagraph.Text = speed.Paragraphs.ToString();
            this.txtSentence.Text = speed.Sentences.ToString();
            this.txtWords.Text = speed.Words.ToString();
            this.txtCharacters.Text = speed.Characters.ToString();
            this.txtWhiteSpace.Text = speed.Spaces.ToString();
            this.txtWordsPerMinute.Text = speed.WordsPerMinute.ToString();

            this.rTxtSpeed.Text = speed.SpeedText;

            this.currentSession.Speed = speed;
        }
    }
}
