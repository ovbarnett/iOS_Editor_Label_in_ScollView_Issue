using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace iOS_Editor_Label_in_ScollView_Issue;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
