namespace MAUISqlite;

// This is the entry point of the application. The App class is a partial class
// that represents the application and is responsible for initializing it.

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
