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
    public partial class TypeTester : Form
    {
        public TypeTester()
        {
            InitializeComponent();
        }



        #region events
        private void TypeTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "JS Speed Tester", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return;
            e.Cancel = true;
        }

        #endregion
    }
}
