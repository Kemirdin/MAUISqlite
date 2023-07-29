namespace MAUISqlite;

// This is the entry point of the application. The App class is a partial class
// that represents the application and is responsible for initializing it.

public partial class App : Application
{
    // The constructor of the App class. It is called when the application starts.

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
