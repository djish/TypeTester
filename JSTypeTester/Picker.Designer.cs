namespace JSTypeTester
{
    partial class Picker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisterNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radLangMalayalam = new System.Windows.Forms.RadioButton();
            this.radLangEnglish = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radStreamHigher = new System.Windows.Forms.RadioButton();
            this.radStreamLower = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radInputHardCopy = new System.Windows.Forms.RadioButton();
            this.radInputComputer = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBeginTest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stream";
            // 
            // txtRegisterNumber
            // 
            this.txtRegisterNumber.Enabled = false;
            this.txtRegisterNumber.Location = new System.Drawing.Point(114, 10);
            this.txtRegisterNumber.Name = "txtRegisterNumber";
            this.txtRegisterNumber.Size = new System.Drawing.Size(250, 20);
            this.txtRegisterNumber.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radLangMalayalam);
            this.panel1.Controls.Add(this.radLangEnglish);
            this.panel1.Location = new System.Drawing.Point(114, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 24);
            this.panel1.TabIndex = 4;
            // 
            // radLangMalayalam
            // 
            this.radLangMalayalam.AutoSize = true;
            this.radLangMalayalam.Location = new System.Drawing.Point(94, 4);
            this.radLangMalayalam.Name = "radLangMalayalam";
            this.radLangMalayalam.Size = new System.Drawing.Size(75, 17);
            this.radLangMalayalam.TabIndex = 1;
            this.radLangMalayalam.TabStop = true;
            this.radLangMalayalam.Text = "Malayalam";
            this.radLangMalayalam.UseVisualStyleBackColor = true;
            // 
            // radLangEnglish
            // 
            this.radLangEnglish.AutoSize = true;
            this.radLangEnglish.Checked = true;
            this.radLangEnglish.Location = new System.Drawing.Point(3, 4);
            this.radLangEnglish.Name = "radLangEnglish";
            this.radLangEnglish.Size = new System.Drawing.Size(59, 17);
            this.radLangEnglish.TabIndex = 0;
            this.radLangEnglish.TabStop = true;
            this.radLangEnglish.Text = "English";
            this.radLangEnglish.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radStreamHigher);
            this.panel2.Controls.Add(this.radStreamLower);
            this.panel2.Location = new System.Drawing.Point(114, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 24);
            this.panel2.TabIndex = 5;
            // 
            // radStreamHigher
            // 
            this.radStreamHigher.AutoSize = true;
            this.radStreamHigher.Location = new System.Drawing.Point(94, 4);
            this.radStreamHigher.Name = "radStreamHigher";
            this.radStreamHigher.Size = new System.Drawing.Size(56, 17);
            this.radStreamHigher.TabIndex = 1;
            this.radStreamHigher.TabStop = true;
            this.radStreamHigher.Text = "Higher";
            this.radStreamHigher.UseVisualStyleBackColor = true;
            // 
            // radStreamLower
            // 
            this.radStreamLower.AutoSize = true;
            this.radStreamLower.Checked = true;
            this.radStreamLower.Location = new System.Drawing.Point(3, 4);
            this.radStreamLower.Name = "radStreamLower";
            this.radStreamLower.Size = new System.Drawing.Size(54, 17);
            this.radStreamLower.TabIndex = 0;
            this.radStreamLower.TabStop = true;
            this.radStreamLower.Text = "Lower";
            this.radStreamLower.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radInputHardCopy);
            this.panel3.Controls.Add(this.radInputComputer);
            this.panel3.Location = new System.Drawing.Point(114, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 24);
            this.panel3.TabIndex = 6;
            // 
            // radInputHardCopy
            // 
            this.radInputHardCopy.AutoSize = true;
            this.radInputHardCopy.Location = new System.Drawing.Point(94, 4);
            this.radInputHardCopy.Name = "radInputHardCopy";
            this.radInputHardCopy.Size = new System.Drawing.Size(75, 17);
            this.radInputHardCopy.TabIndex = 1;
            this.radInputHardCopy.TabStop = true;
            this.radInputHardCopy.Text = "Hard Copy";
            this.radInputHardCopy.UseVisualStyleBackColor = true;
            this.radInputHardCopy.Click += new System.EventHandler(this.radInputHardCopy_Click);
            // 
            // radInputComputer
            // 
            this.radInputComputer.AutoSize = true;
            this.radInputComputer.Checked = true;
            this.radInputComputer.Location = new System.Drawing.Point(3, 4);
            this.radInputComputer.Name = "radInputComputer";
            this.radInputComputer.Size = new System.Drawing.Size(70, 17);
            this.radInputComputer.TabIndex = 0;
            this.radInputComputer.TabStop = true;
            this.radInputComputer.Text = "Computer";
            this.radInputComputer.UseVisualStyleBackColor = true;
            this.radInputComputer.Click += new System.EventHandler(this.radInputComputer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input";
            // 
            // btnBeginTest
            // 
            this.btnBeginTest.Location = new System.Drawing.Point(114, 154);
            this.btnBeginTest.Name = "btnBeginTest";
            this.btnBeginTest.Size = new System.Drawing.Size(250, 38);
            this.btnBeginTest.TabIndex = 8;
            this.btnBeginTest.Text = "Choose Speed";
            this.btnBeginTest.UseVisualStyleBackColor = true;
            this.btnBeginTest.Click += new System.EventHandler(this.btnBeginTest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time";
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(114, 127);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(250, 21);
            this.cmbTime.TabIndex = 10;
            // 
            // Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 211);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBeginTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRegisterNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(396, 250);
            this.Name = "Picker";
            this.Text = "Picker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisterNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radLangMalayalam;
        private System.Windows.Forms.RadioButton radLangEnglish;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radStreamHigher;
        private System.Windows.Forms.RadioButton radStreamLower;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radInputHardCopy;
        private System.Windows.Forms.RadioButton radInputComputer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBeginTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTime;
    }
}