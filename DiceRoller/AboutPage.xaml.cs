namespace DiceRoller;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private async void AboutButton_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/VitorbSil");
    }
}