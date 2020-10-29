namespace JSTypeTester
{
    partial class SpeedPicker
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
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rTxtSpeed = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.btnBeginTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParagraph = new System.Windows.Forms.TextBox();
            this.txtCharacters = new System.Windows.Forms.TextBox();
            this.txtWhiteSpace = new System.Windows.Forms.TextBox();
            this.txtWordsPerMinute = new System.Windows.Forms.TextBox();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Enabled = false;
            this.txtLanguage.Location = new System.Drawing.Point(74, 10);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(145, 20);
            this.txtLanguage.TabIndex = 1;
            // 
            // txtStream
            // 
            this.txtStream.Enabled = false;
            this.txtStream.Location = new System.Drawing.Point(295, 10);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(136, 20);
            this.txtStream.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stream";
            // 
            // rTxtSpeed
            // 
            this.rTxtSpeed.Enabled = false;
            this.rTxtSpeed.Location = new System.Drawing.Point(16, 83);
            this.rTxtSpeed.Name = "rTxtSpeed";
            this.rTxtSpeed.Size = new System.Drawing.Size(415, 179);
            this.rTxtSpeed.TabIndex = 4;
            this.rTxtSpeed.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed";
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Location = new System.Drawing.Point(74, 43);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(357, 21);
            this.cmbSpeed.TabIndex = 6;
            this.cmbSpeed.SelectedIndexChanged += new System.EventHandler(this.cmbSpeed_SelectedIndexChanged);
            // 
            // btnBeginTest
            // 
            this.btnBeginTest.Location = new System.Drawing.Point(16, 338);
            this.btnBeginTest.Name = "btnBeginTest";
            this.btnBeginTest.Size = new System.Drawing.Size(415, 42);
            this.btnBeginTest.TabIndex = 7;
            this.btnBeginTest.Text = "Begin Test";
            this.btnBeginTest.UseVisualStyleBackColor = true;
            this.btnBeginTest.Click += new System.EventHandler(this.btnBeginTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Paragraphs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of Sentences";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of Words";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Number of Characters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Number of Whitespace";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Words Per Minute";
            // 
            // txtParagraph
            // 
            this.txtParagraph.Enabled = false;
            this.txtParagraph.Location = new System.Drawing.Point(135, 266);
            this.txtParagraph.Name = "txtParagraph";
            this.txtParagraph.Size = new System.Drawing.Size(83, 20);
            this.txtParagraph.TabIndex = 14;
            // 
            // txtCharacters
            // 
            this.txtCharacters.Enabled = false;
            this.txtCharacters.Location = new System.Drawing.Point(348, 266);
            this.txtCharacters.Name = "txtCharacters";
            this.txtCharacters.Size = new System.Drawing.Size(83, 20);
            this.txtCharacters.TabIndex = 15;
            // 
            // txtWhiteSpace
            // 
            this.txtWhiteSpace.Enabled = false;
            this.txtWhiteSpace.Location = new System.Drawing.Point(348, 289);
            this.txtWhiteSpace.Name = "txtWhiteSpace";
            this.txtWhiteSpace.Size = new System.Drawing.Size(83, 20);
            this.txtWhiteSpace.TabIndex = 16;
            // 
            // txtWordsPerMinute
            // 
            this.txtWordsPerMinute.Enabled = false;
            this.txtWordsPerMinute.Location = new System.Drawing.Point(348, 312);
            this.txtWordsPerMinute.Name = "txtWordsPerMinute";
            this.txtWordsPerMinute.Size = new System.Drawing.Size(83, 20);
            this.txtWordsPerMinute.TabIndex = 17;
            // 
            // txtSentence
            // 
            this.txtSentence.Enabled = false;
            this.txtSentence.Location = new System.Drawing.Point(135, 289);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(83, 20);
            this.txtSentence.TabIndex = 18;
            // 
            // txtWords
            // 
            this.txtWords.Enabled = false;
            this.txtWords.Location = new System.Drawing.Point(135, 312);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(83, 20);
            this.txtWords.TabIndex = 19;
            // 
            // SpeedPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 392);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.txtWordsPerMinute);
            this.Controls.Add(this.txtWhiteSpace);
            this.Controls.Add(this.txtCharacters);
            this.Controls.Add(this.txtParagraph);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBeginTest);
            this.Controls.Add(this.cmbSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rTxtSpeed);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 431);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(463, 431);
            this.Name = "SpeedPicker";
            this.Text = "SpeedPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtStream;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rTxtSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Button btnBeginTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParagraph;
        private System.Windows.Forms.TextBox txtCharacters;
        private System.Windows.Forms.TextBox txtWhiteSpace;
        private System.Windows.Forms.TextBox txtWordsPerMinute;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.TextBox txtWords;
    }
}