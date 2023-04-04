namespace Builder
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : global::System.Windows.Forms.Form
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

		// Token: 0x06000022 RID: 34 RVA: 0x0000310C File Offset: 0x0000130C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.checkBox4 = new global::System.Windows.Forms.CheckBox();
			this.checkBox3 = new global::System.Windows.Forms.CheckBox();
			this.txtFileTest = new global::System.Windows.Forms.TextBox();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.delayTime = new global::System.Windows.Forms.DateTimePicker();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtExtension = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtEmail = new global::System.Windows.Forms.TextBox();
			this.numRansom = new global::System.Windows.Forms.NumericUpDown();
			this.button1 = new global::System.Windows.Forms.Button();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.txtFilePath = new global::System.Windows.Forms.TextBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.txtID = new global::System.Windows.Forms.TextBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.txtResult = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.components);
            this.toolTip_1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.saveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
			this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog_0 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.saveFileDialog_1 = new global::System.Windows.Forms.SaveFileDialog();
            this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numRansom).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			base.SuspendLayout();
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new global::System.Drawing.Point(-4, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(0x1F2, 0x10F);
			this.tabControl1.TabIndex = 0;
			this.tabPage1.BackColor = global::System.Drawing.Color.Black;
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 0x16);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(0x1EA, 0xF5);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Build";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(0xB, 0x9D);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(0x1D4, 0x52);
			this.listBox1.TabIndex = 7;
			this.groupBox2.Controls.Add(this.checkBox4);
			this.groupBox2.Controls.Add(this.checkBox3);
			this.groupBox2.Controls.Add(this.txtFileTest);
			this.groupBox2.Controls.Add(this.checkBox2);
			this.groupBox2.Controls.Add(this.delayTime);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox2.Location = new global::System.Drawing.Point(0xFE, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(0xE1, 0x90);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Extras";
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new global::System.Drawing.Point(0x71, 0x13);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new global::System.Drawing.Size(0x60, 0x11);
			this.checkBox4.TabIndex = 0xE;
			this.checkBox4.Text = "Fake Message";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new global::System.Drawing.Point(0xB, 0x5B);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new global::System.Drawing.Size(0x4D, 0x11);
			this.checkBox3.TabIndex = 0xD;
			this.checkBox3.Text = "Test Mode";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new global::System.EventHandler(this.checkBox3_CheckedChanged);
			this.txtFileTest.Enabled = false;
			this.txtFileTest.Location = new global::System.Drawing.Point(0xB, 0x72);
			this.txtFileTest.Name = "txtFileTest";
			this.txtFileTest.Size = new global::System.Drawing.Size(0xC4, 0x14);
			this.txtFileTest.TabIndex = 0xB;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new global::System.Drawing.Point(0xD, 0x13);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(0x59, 0x11);
			this.checkBox2.TabIndex = 0xA;
			this.checkBox2.Text = "Process Killer";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged);
			this.delayTime.CustomFormat = "dd/MM/yyyy";
			this.delayTime.Enabled = false;
			this.delayTime.Location = new global::System.Drawing.Point(0xB, 0x41);
			this.delayTime.Name = "delayTime";
			this.delayTime.Size = new global::System.Drawing.Size(0xC4, 0x14);
			this.delayTime.TabIndex = 9;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(0xD, 0x2A);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(0x5F, 0x11);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Delay Execute";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtExtension);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.numRansom);
			this.groupBox1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox1.Location = new global::System.Drawing.Point(0xB, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(0xE8, 0x73);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General Information";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(0x75, 0x40);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(0x35, 0xD);
			this.label4.TabIndex = 6;
			this.label4.Text = "Extension";
			this.txtExtension.Location = new global::System.Drawing.Point(0x78, 0x50);
			this.txtExtension.Name = "txtExtension";
			this.txtExtension.Size = new global::System.Drawing.Size(0x5E, 0x14);
			this.txtExtension.TabIndex = 5;
			this.txtExtension.Text = "TnyEvil";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 0x10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0x47, 0xD);
			this.label1.TabIndex = 1;
			this.label1.Text = "Email contact";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 0x40);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0x4E, 0xD);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ransom (USD)";
			this.txtEmail.Location = new global::System.Drawing.Point(9, 0x20);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new global::System.Drawing.Size(0xCD, 0x14);
			this.txtEmail.TabIndex = 0;
			this.txtEmail.Text = "your@email.com";
			this.numRansom.Location = new global::System.Drawing.Point(9, 0x50);
            this.numRansom.Maximum = new decimal(0x5F5E0FF);
			this.numRansom.Name = "numRansom";
			this.numRansom.Size = new global::System.Drawing.Size(0x62, 0x14);
			this.numRansom.TabIndex = 3;
			this.button1.BackColor = global::System.Drawing.Color.Teal;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new global::System.Drawing.Point(0xD, 0x7F);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(0x4B, 0x17);
			this.button1.TabIndex = 2;
			this.button1.Text = "Build";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.tabPage2.BackColor = global::System.Drawing.Color.Black;
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 0x16);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(0x1EA, 0xF5);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Decryption";
			this.groupBox4.Controls.Add(this.button5);
			this.groupBox4.Controls.Add(this.button4);
			this.groupBox4.Controls.Add(this.txtFilePath);
			this.groupBox4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox4.Location = new global::System.Drawing.Point(0x22, 0xB6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(0x1AB, 0x38);
			this.groupBox4.TabIndex = 0xB;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Single File";
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new global::System.Drawing.Point(0xC, 0x14);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(0x29, 0x17);
			this.button5.TabIndex = 9;
			this.button5.Text = "...";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new global::System.Drawing.Point(0x133, 0x13);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(0x6D, 0x17);
			this.button4.TabIndex = 7;
			this.button4.Text = "Decrypt File";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.txtFilePath.Location = new global::System.Drawing.Point(0x3B, 0x13);
			this.txtFilePath.Multiline = true;
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new global::System.Drawing.Size(0xF2, 0x17);
			this.txtFilePath.TabIndex = 8;
			this.groupBox3.Controls.Add(this.linkLabel1);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.txtID);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.txtResult);
			this.groupBox3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox3.Location = new global::System.Drawing.Point(0x22, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(0x1AB, 0xAB);
			this.groupBox3.TabIndex = 0xA;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Password";
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = global::System.Drawing.Color.Red;
			this.linkLabel1.Location = new global::System.Drawing.Point(0xE, 0x18);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(0x1F, 0xD);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Clear";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.button3.BackColor = global::System.Drawing.Color.DarkRed;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Location = new global::System.Drawing.Point(0x13E, 0xD);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(0x5C, 0x17);
			this.button3.TabIndex = 6;
			this.button3.Text = "New Key";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.txtID.Location = new global::System.Drawing.Point(0xE, 0x29);
			this.txtID.Multiline = true;
			this.txtID.Name = "txtID";
			this.txtID.Size = new global::System.Drawing.Size(0x18C, 0x58);
			this.txtID.TabIndex = 2;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new global::System.Drawing.Point(0xE, 0x87);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(0x79, 0x17);
			this.button2.TabIndex = 4;
			this.button2.Text = "Decrypt Password";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.txtResult.Location = new global::System.Drawing.Point(0x8D, 0x87);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new global::System.Drawing.Size(0x10D, 0x17);
			this.txtResult.TabIndex = 5;
			this.txtResult.Click += new global::System.EventHandler(this.txtResult_Click);
			this.txtResult.TextChanged += new global::System.EventHandler(this.txtResult_TextChanged);
			this.txtResult.DoubleClick += new global::System.EventHandler(this.txtResult_DoubleClick);
			this.txtResult.Enter += new global::System.EventHandler(this.txtResult_Enter);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(7, 0x15);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(0x37, 0xD);
			this.label3.TabIndex = 3;
			this.label3.Text = "Unique ID";
			this.timer_0.Interval = 0x7530;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.ClientSize = new global::System.Drawing.Size(0x1EA, 0x109);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TinyEvil Ransomware Builder";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numRansom).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.DateTimePicker delayTime;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.TextBox txtEmail;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.NumericUpDown numRansom;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.TextBox txtResult;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.TextBox txtID;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.TextBox txtExtension;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolTip toolTip_1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.TextBox txtFilePath;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog_0;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.CheckBox checkBox3;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.TextBox txtFileTest;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_0;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog_1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.CheckBox checkBox4;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x0400002F RID: 47
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;
	}
}