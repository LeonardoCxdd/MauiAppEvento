namespace MauiAppEvento.Views;

public class TelaInicialDoEvento : ContentPage
{
	public TelaInicialDoEvento()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}