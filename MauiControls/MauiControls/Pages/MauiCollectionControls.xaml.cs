namespace MauiControls.Pages;

using MauiControls.Models;
using MauiControls.ViewModels;

public partial class MauiCollectionControls : ContentPage
{
    public MauiCollectionControls()
    {
        InitializeComponent();
        BindingContext = new PhotoViewModel();
    }

    private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        if (e.CurrentItem != null && e.PreviousItem != null)
        {
            Photo previous = e.PreviousItem as Photo;
            Photo next = e.CurrentItem as Photo;

            await DisplayAlert("CarouselView",
                $"previous={previous.Name} \n\nnext={next.Name}", "OK");
        }
    }

    private void SeatbeltAlert_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Seatbelt alert",
            "You selected/deselected this item", "OK");
    }
}