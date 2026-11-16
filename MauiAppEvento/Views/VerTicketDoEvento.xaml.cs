namespace MauiAppEvento.Views;

public partial class VerTicketDoEvento : ContentPage
{
	public VerTicketDoEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Views.ResumoDoEvento());
        } catch (Exception ex)
        {
            DisplayAlert("Erro", $"Ocorreu um erro ao navegar para a tela de cadastro: {ex.Message}", "OK");
        }
        
        
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
           Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", $"Ocorreu um erro ao navegar para a tela de cadastro: {ex.Message}", "OK");
        }
    }
}