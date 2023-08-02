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

   // This method is triggered when the "CounterBtn" button is clicked
    private void OnCounterClicked(object sender, EventArgs e)
    {
        // Increment the counter each time the button is clicked
        count++;

        // Update the text of the "CounterBtn" to display the number of times it has been clicked
        // Use a conditional statement to adjust the text based on the count value
        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        // Announce the updated text for accessibility purposes using SemanticScreenReader
        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

