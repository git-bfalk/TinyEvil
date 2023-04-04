namespace Builder
{
	// Token: 0x02000003 RID: 3
	public partial class AuthLicense : global::System.Windows.Forms.Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002268 File Offset: 0x00000468
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002468 File Offset: 0x00000668
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Builder.AuthLicense));
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(0xF, 0x23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(0x192, 0x14);
			this.textBox1.TabIndex = 0;
			this.button1.Location = new global::System.Drawing.Point(0xC, 0x64);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(0x4B, 0x17);
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(0xC, 0x13);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0x3A, 0xD);
			this.label1.TabIndex = 2;
			this.label1.Text = "License ID";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(0xC, 0x3A);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0x41, 0xD);
			this.label2.TabIndex = 4;
			this.label2.Text = "License Key";
			this.textBox2.Location = new global::System.Drawing.Point(0xF, 0x4A);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(0x111, 0x14);
			this.textBox2.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(0x1AD, 0x88);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "AuthLicense";
			this.Text = "Enter License Key";
			base.Load += new global::System.EventHandler(this.AuthLicense_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.TextBox textBox2;
	}
}
