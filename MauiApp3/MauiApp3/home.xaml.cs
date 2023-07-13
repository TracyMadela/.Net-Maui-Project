namespace MauiApp3;

public partial class home : ContentPage
{
	public home()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}