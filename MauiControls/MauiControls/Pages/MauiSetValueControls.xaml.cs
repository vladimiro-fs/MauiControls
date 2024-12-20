namespace MauiControls.Pages;

using System.Globalization;

public partial class MauiSetValueControls : ContentPage
{
	public MauiSetValueControls()
	{
		InitializeComponent();
	}

    private async void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
			await DisplayAlert("CheckBox", "Checked", "OK");
		else
			await DisplayAlert("CheckedBox", "Unchecked", "OK");
    }

    private async void CheckBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
            await DisplayAlert("CheckBox", "Checked", "OK");
        else
            await DisplayAlert("CheckedBox", "Unchecked", "OK");
    }

    private async void CheckBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
            await DisplayAlert("CheckBox", "Checked", "OK");
        else
            await DisplayAlert("CheckedBox", "Unchecked", "OK");
    }

    private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = Math.Round(Slider1.Value, 2);
        lblSlider.Text = value.ToString();
    }

    private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        lblStepper.Text = string.Format($"Stepper value: {value}");
    }

    private async void Switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
            await DisplayAlert("Switch", "On", "OK");
        else
            await DisplayAlert("Switch", "Off", "OK");
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-PT");

        var date = ((DatePicker)sender).Date;
        var selectedDate = date.ToString("d", culture);

        await DisplayAlert("Selected date", selectedDate, "OK");
    }

    private async void Time1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (Time1 != null) 
        {
            var selectedTime = Time1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Selected time", selectedTime, "OK");
        }
    }
}