namespace MauiControls.Pages;

public partial class MauiCommandControls : ContentPage
{
	public MauiCommandControls()
	{
		InitializeComponent();
	}

    private async void btnDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RotateTo(360, 2000);
        await DisplayAlert("Button", "Task completed", "OK");
    }

    private async void btnImageDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RotateTo(360, 5000);
        await DisplayAlert("Button", "Task completed", "OK");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = ((RadioButton)sender);

        if (lblPets2 != null)
        {
            lblPets2.Text = $"{selectedRadioButton.Value} selected";
            lblPets2.FontSize = 20;
        }
    }

    private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        await DisplayAlert("Searching ...", $"{searchBar.Text}", "OK");
    }

    private async void SwipeItem_Invoked(object sender, EventArgs e)
    {
        await DisplayAlert("SwipeView", "Element touched", "OK");
    }
}