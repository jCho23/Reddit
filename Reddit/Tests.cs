using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace Reddit
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		Query MyUsername;
		Query MyPassword;


		MyUsername= 

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile ("/Users/junecho/Desktop/Reddit.apk")
				.StartApp();
		}

		[Test]
		public void AppLaunches()
		{
			//Arrange


			//Act
			app.Flash(x => x.Id("login_button"));
			app.Tap(x => x.Id("login_button"));



			app.Repl();
		}
	}
}

