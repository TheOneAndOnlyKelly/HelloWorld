using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HellWorldLib;
using System.Collections.Generic;

namespace HelloWorldUnitTests
{
	[TestClass]
	public class TestMessages
	{
		[TestMethod]
		public void TestConsole()
		{
			IMessage Messenger = new ConsoleMsg();
			if (string.IsNullOrEmpty(Messenger.OutputMessage()))
				Assert.Fail();
		}

		[TestMethod]
		public void TestWeb()
		{
			IMessage Messenger = new WebMsg();
			if (string.IsNullOrEmpty(Messenger.OutputMessage()))
				Assert.Fail();
		}
	}
}
