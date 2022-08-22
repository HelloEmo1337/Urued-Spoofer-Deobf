using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace inject
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private static void Main(string[] args)
		{
			MessageBox.Show("UruedWasHere AkiraSpoofer...");
			Process.Start("drvmap.exe", "spoofer.sys");
		}
	}
}
