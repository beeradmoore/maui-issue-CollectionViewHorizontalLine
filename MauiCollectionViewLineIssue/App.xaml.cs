namespace MauiCollectionViewLineIssue;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // Change this to go directly to the test page to see the issue go away
        //return new Window(new TestPage());
        return new Window(new NavigationPage(new MainPage()));
    }
}