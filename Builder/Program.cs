using System;
using System.Windows.Forms;
using Builder;

// Token: 0x02000006 RID: 6
internal static class Program
{
	// Token: 0x06000029 RID: 41 RVA: 0x00004514 File Offset: 0x00002714
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		if (Class1.registryKey_0 == null || Class1.smethod_2() == null)
		{
			Class1.smethod_0();
			Application.Run(new AuthLicense());
		}
		else if (Class1.smethod_2() != null)
		{
			Application.Run(new Form1());
		}
	}
}
