namespace MAUISqlite;

public partial class MainPage : ContentPage
{
        // Initialize a counter variable to keep track of the number of button clicks
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
                // This constructor is called when the MainPage is created, and it initializes the component.

	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

