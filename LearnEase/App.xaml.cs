using Microsoft.Maui.Controls;
namespace LearnEase;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}
}

