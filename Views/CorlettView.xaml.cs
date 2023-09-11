using CommunityToolkit.Maui.Views;

namespace PainApp;



public partial class CorlettView : ContentPage
{
    public CorlettView()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        DrawView.Lines.Clear(); 
    }
}