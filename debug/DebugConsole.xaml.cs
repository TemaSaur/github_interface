﻿namespace flightgear_interface;

public partial class DebugConsole : IDebug
{
	public DebugConsole()
	{
		InitializeComponent();
		DebugText.Text = "Flightgear interface debug console\n==================================\n";
		Show();
	}

	public void WriteLine(object output)
	{
		var debugText = $"{output} ({output.GetType().Name})\n";
		DebugText.Text += debugText;
		DebugText.ScrollToEnd();
	}
	
}