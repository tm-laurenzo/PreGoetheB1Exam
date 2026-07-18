namespace PreGoetheB1Exam;

public partial class Phoneword : ContentPage
{
    int count = 0;

    // Named Label - declared as a member of the class

    public Phoneword()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(CounterLabel.Text);
    }
}