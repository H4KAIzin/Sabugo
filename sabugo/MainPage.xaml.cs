namespace sabugo;

public partial class MainPage : ContentPage
{
	
//---------------------------------------------------------------------------------------------------------------//
	public MainPage()
	{
		InitializeComponent();
	}
//---------------------------------------------------------------------------------------------------------------//
	private void ClicouBotaoIniciar(object sender, EventArgs args)
	{

	}	
//---------------------------------------------------------------------------------------------------------------//
	private void ClicouBotaoSobre(object sender, EventArgs args)
	{
		framinho.IsVisible = true;
	}
//---------------------------------------------------------------------------------------------------------------//
	private void ClicouBotaoCreditos(object sender, EventArgs args)
	{
		framinho2.IsVisible = true;
	}
//---------------------------------------------------------------------------------------------------------------//
	private void ClicouBotaoVoltar(object sender, EventArgs args)
  {
    framinho.IsVisible = false;
  }
//---------------------------------------------------------------------------------------------------------------//

private void ClicouBotaoVoltarDeNovo(object sender, EventArgs args)
  {
    framinho2.IsVisible = false;
  }

}

