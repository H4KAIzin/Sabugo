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
		Application.Current.MainPage = new GamePage ();
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



//--------------------------------------------------------------------------------------------------------------//

  async	void QuandoClicarNoBotaoInstagram(object sender, EventArgs args)
	{
    	Uri uri = new Uri("https://www.instagram.com/lucas_viniciusgow?igsh=MXVwcjMyb2VtM3JtNw==");
    	await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
		framinho2.IsVisible = false;
	}

//--------------------------------------------------------------------------------------------------------------//

  async	void QuandoClicarNoBotaoInstagram2(object sender, EventArgs args)
	{
    	Uri uri = new Uri("https://www.instagram.com/draazykkkk?igsh=MWN0ZnJndng4NTV4NA==");
    	await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
		framinho2.IsVisible = false;
	}

}