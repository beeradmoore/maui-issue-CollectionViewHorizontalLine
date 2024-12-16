namespace MauiCollectionViewLineIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    void Button_OnClicked(object? sender, EventArgs e)
    {
        App.Current.Windows[0].Page = new TestPage();
    }
}