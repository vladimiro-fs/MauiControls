namespace MauiControls.Pages;

public partial class MauiEditControls : ContentPage
{
	public MauiEditControls()
	{
		InitializeComponent();
        this.BindingContext = this;
        this.IsBusy = false;
        BtnLogin.Clicked += BtnLogin_Clicked;
	}

    private async void BtnLogin_Clicked(object? sender, EventArgs e)
    {
        this.IsBusy = true;

        await Task.Delay(8000);
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    private async void Entry1_TextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = Entry1.Text;

        await DisplayAlert("Entry1 - Text changed", $"{oldText}" +
            $" - {newText} - {myText}", "OK");
    }

    private async void Entry1_Completed(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
        await DisplayAlert("Entry1 - Comppleted", text, "OK");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await ProgressBar.ProgressTo(0.90, 1000, Easing.Linear);
    }
}