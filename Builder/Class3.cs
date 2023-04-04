using System;
using System.Reflection;

// Token: 0x0200000C RID: 12
internal class Class3
{
	// Token: 0x06000031 RID: 49 RVA: 0x000045DC File Offset: 0x000027DC
	internal static void KE1iXaGGABBVA(int typemdt)
	{
		Type type = Class3.module_0.ResolveType(0x2000000 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo methodInfo = (MethodInfo)Class3.module_0.ResolveMethod(fieldInfo.MetadataToken + 0x6000000);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, methodInfo));
		}
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002362 File Offset: 0x00000562
	public Class3()
	{
	} 

	// Token: 0x06000033 RID: 51 RVA: 0x000023BB File Offset: 0x000005BB
	static Class3()
	{
		Class3.module_0 = typeof(Class3).Assembly.ManifestModule;
	}

	// Token: 0x04000035 RID: 53
	internal static Module module_0;

	// Token: 0x0200000D RID: 13
	// (Invoke) Token: 0x06000035 RID: 53
	internal delegate void Delegate0(object o);
}
