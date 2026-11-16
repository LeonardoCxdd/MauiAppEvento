namespace MauiAppEvento.Views;

public partial class TelaInicialDoEvento : ContentPage
{
	public TelaInicialDoEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try

		{
			Navigation.PushAsync(new Views.VerTicketDoEvento());
		}
		catch (Exception ex)
		{
			DisplayAlert("Erro", $"Ocorreu um erro ao navegar para a tela de cadastro: {ex.Message}", "OK");

		}	 
    }
}