using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GS4_Calibration_Utility.My
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("MyTemplate", "10.0.0.0")]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		private static List<WeakReference> __ENCList;

		[DebuggerNonUserCode]
		static MyApplication()
		{
			MyApplication.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public MyApplication()
		{
			MyApplication.__ENCAddToList(this);
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (MyApplication.__ENCList)
			{
				if (MyApplication.__ENCList.Count == MyApplication.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(MyApplication.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (MyApplication.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								MyApplication.__ENCList[item] = MyApplication.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					MyApplication.__ENCList.RemoveRange(item, checked(MyApplication.__ENCList.Count - item));
					MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count;
				}
				MyApplication.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		[STAThread]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}
	}
}