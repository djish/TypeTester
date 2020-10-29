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
    partial class Tester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Process myProcess = (Process)null;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label lblStream;
        private Label lblLanguange;
        private Label lblRegNum;
        private Label label3;
        private StatusStrip statusStrip1;
        private Label label4;
        private Label lable225;
        private Label lblRTL;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblTypedCharacter;
        private RichTextBox txtSpeed;
        private LinkLabel lnkLblCredit;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Tester));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new GroupBox();
            this.lblTypedCharacter = new Label();
            this.lable225 = new Label();
            this.lblRTL = new Label();
            this.label7 = new Label();
            this.label6 = new Label();
            this.label5 = new Label();
            this.lblStream = new Label();
            this.lblLanguange = new Label();
            this.lblRegNum = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.statusStrip1 = new StatusStrip();
            this.label4 = new Label();
            this.txtSpeed = new RichTextBox();
            this.lnkLblCredit = new LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.groupBox1.Controls.Add((Control)this.lblTypedCharacter);
            this.groupBox1.Controls.Add((Control)this.lable225);
            this.groupBox1.Controls.Add((Control)this.lblRTL);
            this.groupBox1.Controls.Add((Control)this.label7);
            this.groupBox1.Controls.Add((Control)this.label6);
            this.groupBox1.Controls.Add((Control)this.label5);
            this.groupBox1.Controls.Add((Control)this.lblStream);
            this.groupBox1.Controls.Add((Control)this.lblLanguange);
            this.groupBox1.Controls.Add((Control)this.lblRegNum);
            this.groupBox1.Controls.Add((Control)this.label3);
            this.groupBox1.Controls.Add((Control)this.label2);
            this.groupBox1.Controls.Add((Control)this.label1);
            this.groupBox1.Location = new Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(769, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information -  System Control";
            this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
            this.lblTypedCharacter.AutoSize = true;
            this.lblTypedCharacter.Location = new Point(312, 43);
            this.lblTypedCharacter.Name = "lblTypedCharacter";
            this.lblTypedCharacter.Size = new Size(0, 13);
            this.lblTypedCharacter.TabIndex = 12;
            this.lable225.AutoSize = true;
            this.lable225.Location = new Point(515, 42);
            this.lable225.Name = "lable225";
            this.lable225.Size = new Size(71, 13);
            this.lable225.TabIndex = 11;
            this.lable225.Text = "Elapsed Time";
            this.lblRTL.AutoSize = true;
            this.lblRTL.Font = new Font("Microsoft Sans Serif", 40f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblRTL.Location = new Point(601, 12);
            this.lblRTL.Name = "lblRTL";
            this.lblRTL.Size = new Size(162, 63);
            this.lblRTL.TabIndex = 10;
            this.lblRTL.Text = "00:00";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(197, 61);
            this.label7.Name = "label7";
            this.label7.Size = new Size(112, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Character Remaining :";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(217, 42);
            this.label6.Name = "label6";
            this.label6.Size = new Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Typed Character :";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(223, 20);
            this.label5.Name = "label5";
            this.label5.Size = new Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Character :";
            this.lblStream.AutoSize = true;
            this.lblStream.Location = new Point(105, 62);
            this.lblStream.Name = "lblStream";
            this.lblStream.Size = new Size(50, 13);
            this.lblStream.TabIndex = 1;
            this.lblStream.Text = "lblStream";
            this.lblLanguange.AutoSize = true;
            this.lblLanguange.Location = new Point(105, 42);
            this.lblLanguange.Name = "lblLanguange";
            this.lblLanguange.Size = new Size(71, 13);
            this.lblLanguange.TabIndex = 3;
            this.lblLanguange.Text = "lblLanguange";
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Location = new Point(105, 21);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new Size(59, 13);
            this.lblRegNum.TabIndex = 1;
            this.lblRegNum.Text = "lblRegNum";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(53, 62);
            this.label3.Name = "label3";
            this.label3.Size = new Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stream :";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Language :";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Number :";
            this.statusStrip1.Location = new Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(784, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "copyright -  JS typewriting and computer center";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(10, 544);
            this.label4.Name = "label4";
            this.label4.Size = new Size(228, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "copyright -  JS typewriting and computer center";
            this.txtSpeed.Cursor = Cursors.IBeam;
            this.txtSpeed.Font = new Font("ML-TTRevathi", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.txtSpeed.Location = new Point(8, 91);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new Size(769, 435);
            this.txtSpeed.TabIndex = 7;
            this.txtSpeed.Text = "";
            this.lnkLblCredit.AutoSize = true;
            this.lnkLblCredit.Location = new Point(733, 544);
            this.lnkLblCredit.Name = "lnkLblCredit";
            this.lnkLblCredit.Size = new Size(39, 13);
            this.lnkLblCredit.TabIndex = 8;
            this.lnkLblCredit.TabStop = true;
            this.lnkLblCredit.Text = "Credits";
            this.lnkLblCredit.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkLblCredit_LinkClicked);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(784, 562);
            this.Controls.Add((Control)this.lnkLblCredit);
            this.Controls.Add((Control)this.txtSpeed);
            this.Controls.Add((Control)this.label4);
            this.Controls.Add((Control)this.statusStrip1);
            this.Controls.Add((Control)this.groupBox1);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximumSize = new Size(800, 600);
            this.MinimumSize = new Size(800, 600);
            this.Name = nameof(Tester);
            this.Text = "JS Speed Tester ";
            this.Load += new EventHandler(this.Tester_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}