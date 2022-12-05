namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void ButtonStart_Pressed(object sender, EventArgs e)
    {
        Label.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.";
    }

    private void ButtonStop_Pressed(object sender, EventArgs e)
    {
        Label.Text = "Short text";
    }
}

