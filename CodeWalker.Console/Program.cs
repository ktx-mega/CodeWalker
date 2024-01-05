using CodeWalker.GameFiles;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Numerics;

namespace CodeWalker.Console
{
	internal class Program
	{

		const string USAGE =
		#region USAGE
@"Usage:
cw_cli source output
";
		#endregion

		private static void Main(string[] args)
		{
			try
			{
				Core(args);
				Environment.ExitCode = 0;
			}
			catch (ConsoleArgumentException)
			{
				Environment.ExitCode = 1;
				return;
			}
			catch (Exception e)
			{
				Environment.ExitCode = 2;
				throw new Exception("", e);
			}
		}
	}
}