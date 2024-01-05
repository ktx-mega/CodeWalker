using CodeWalker.GameFiles;
using System;
using System.IO;

namespace CodeWalker.Console
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				string content = File.ReadAllText(args[1]);
				YtdFile file = XmlYtd.GetYtd(content, "");
				byte[] outputBytes = file.Save();
				File.WriteAllBytes(args[2], outputBytes);
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