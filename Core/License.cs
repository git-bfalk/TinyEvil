using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace Core
{
	// Token: 0x02000003 RID: 3
	public class License
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000223C File Offset: 0x0000043C
		public License(string url)
		{
			Class2.gux07DHz5xwRs();
			
			License.string_0 = url;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002298 File Offset: 0x00000498
		private static string smethod_0(int int_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			while (0 < int_0--)
			{
				stringBuilder.Append("ABCDEFKLMNOPQRSTUVWXYZ1234567890"[random.Next("ABCDEFKLMNOPQRSTUVWXYZ1234567890".Length)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000022E8 File Offset: 0x000004E8
		public static string GenerateID(string input)
		{
			string text = string.Empty;
			string text2 = "VIN_IS_THE_BEST";
			byte[] bytes = Encoding.UTF8.GetBytes(input + text2);
			byte[] array = SHA256.Create().ComputeHash(bytes);
			foreach (byte b in array)
			{
				text += b.ToString("x2");
			}
			return text;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002358 File Offset: 0x00000558
		public static string GenerateKey()
		{
			string text = License.smethod_0(0x14);
			string text2 = string.Empty;
			for (int i = 0; i < 0x14; i += 4)
			{
				text2 = text2 + text.Substring(i, 4) + "-";
			}
			return text2.Substring(0, text2.Length - 1);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000023AC File Offset: 0x000005AC
		public bool IsLicenseValid(string id, string key)
		{
			string text = License.GenerateID(key);
			return id == text && this.method_0(id);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023E0 File Offset: 0x000005E0
		private bool method_0(string string_1)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString(string.Concat(new object[]
			{
				License.string_0,
				"verify.php?id=",
				string_1,
				"&username=",
				Environment.UserName,
				"&computer=",
				Environment.MachineName,
				"&os=",
				Environment.OSVersion,
				"&hwid=",
				this.method_1()
			}));
			return text == "Yes";
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002478 File Offset: 0x00000678
		private string method_1()
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Cryptography", true);
			return registryKey.GetValue("MachineGuid").ToString();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024A8 File Offset: 0x000006A8
		public string LicenseCheker(string id)
		{
			string text;
			using (WebClient webClient = new WebClient())
			{
				text = webClient.DownloadString(string.Concat(new string[]
				{
					License.string_0,
					"realtime_check.php?id=",
					id,
					"&hwid=",
					this.method_1()
				}));
			}
			return text;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002514 File Offset: 0x00000714
		public bool IsHashValid(string id, string key)
		{
			return id == License.GenerateID(key);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000224F File Offset: 0x0000044F
		static License()
		{
			Class2.gux07DHz5xwRs();
			License.string_0 = string.Empty;
		}

		// Token: 0x04000001 RID: 1
		private static string string_0;
	}
}
