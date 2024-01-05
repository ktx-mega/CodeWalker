using System;

namespace CodeWalker.Console
{
	[Serializable]
	public class ConsoleArgumentException : Exception
	{
		public ConsoleArgumentException() { }
		public ConsoleArgumentException(string message) : base(message) { }
		public ConsoleArgumentException(string message, Exception inner) : base(message, inner) { }
		protected ConsoleArgumentException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}