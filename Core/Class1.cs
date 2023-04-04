using System;
using System.Reflection;

// Token: 0x02000005 RID: 5
internal class Class1
{
	// Token: 0x0600000B RID: 11 RVA: 0x0000253C File Offset: 0x0000073C
	internal static void SgO07DHH6Gxvl(int typemdt)
	{
		Type type = Class1.module_0.ResolveType(0x2000000 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo methodInfo = (MethodInfo)Class1.module_0.ResolveMethod(fieldInfo.MetadataToken + 0x6000000);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, methodInfo));
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002260 File Offset: 0x00000460
	public Class1()
	{
		Class2.gux07DHz5xwRs();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000226D File Offset: 0x0000046D
	static Class1()
	{
		Class2.gux07DHz5xwRs();
		Class1.module_0 = typeof(Class1).Assembly.ManifestModule;
	}

	// Token: 0x04000002 RID: 2
	internal static Module module_0;
}
