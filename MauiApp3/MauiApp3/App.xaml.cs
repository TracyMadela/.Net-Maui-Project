﻿namespace MauiApp3;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new MainPage());

        MainPage = new AppShell();
	}
}
