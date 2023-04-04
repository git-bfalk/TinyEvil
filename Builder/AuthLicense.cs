using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Core;
using Microsoft.Win32;

namespace Builder
{
	// Token: 0x02000003 RID: 3
	public partial class AuthLicense : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000224C File Offset: 0x0000044C
		public AuthLicense()
		{
			this.icontainer_0 = null;
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000023E4 File Offset: 0x000005E4
		private void button1_Click(object sender, EventArgs e)
		{
			Core.License license = new Core.License("http://cr4ckz.coolpage.biz/");
			if (license.IsLicenseValid(this.textBox1.Text, this.textBox2.Text))
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\loliHunter", true).SetValue("ID", this.textBox1.Text);
				new Form1().Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Your license is not valid!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002266 File Offset: 0x00000466
		private void AuthLicense_Load(object sender, EventArgs e)
		{
		}
	}
}
