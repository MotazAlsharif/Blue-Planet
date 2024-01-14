namespace BluePlanet2.view;

public partial class emamainpage : ContentPage
{
    
    public emamainpage()
    {
        InitializeComponent();
    }
   
   
    private async void OnHawksbillSeaTurtleButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//view/hawksbillseaturtle");
    }

}