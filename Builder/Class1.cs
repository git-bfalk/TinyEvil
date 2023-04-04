using System;
using Microsoft.Win32;

// Token: 0x02000005 RID: 5
internal class Class1
{
	// Token: 0x06000023 RID: 35 RVA: 0x0000232D File Offset: 0x0000052D
	internal static void smethod_0()
	{
		Registry.LocalMachine.CreateSubKey("SOFTWARE\\loliHunter");
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0000233F File Offset: 0x0000053F
	internal static void smethod_1(object object_0)
	{
		Class1.registryKey_0.SetValue("ID", object_0);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000044D4 File Offset: 0x000026D4
	internal static string smethod_2()
	{
        return Class1.registryKey_0.GetValue("ID").ToString();
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002351 File Offset: 0x00000551
	internal static void smethod_3()
	{
		Class1.registryKey_0.DeleteValue("ID");
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002362 File Offset: 0x00000562
	public Class1()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000236F File Offset: 0x0000056F
	static Class1()
	{
		Class1.registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\loliHunter", true);
	}

	// Token: 0x04000030 RID: 48
	internal static RegistryKey registryKey_0;
}
