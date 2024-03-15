namespace sabugo;

public partial class GamePage : ContentPage
{
	

List<cingaro> cigas = new List<cingaro>();
  cingaro CingaroAtual;
   //---------------------------------------------------------------------------------------------------------------//
	public GamePage()
	{
		InitializeComponent();
	

	cigas.Add(new cingaro()
	{
	Inf = 0,
	Textinho = "Há muito tempo atrás, na era das trevas, um forasteiro perdido e com fome, estava preste a morrer porém achou um reino próximo chamado Averdell, este é você, suas escolhas irão definir o futuro deste Reino e de seu Personagem, seu nome é Damion Cambell.",
	TemResposta=false,
	});

	//-----------------------------------------------------------------------------------------------------------//
	cigas.Add(new cingaro()
	{
	Inf = 1,
	Textinho = "Damion Cambell entra no Reino, porém há dois guardas no portão da frente do Reino, você precisa pagar uma taixa para entrar, você não tem dinheiro, você suborna os guardas e entra no reino normalmente, primeiramente procurando por um abrigo, um Motel seria mais barato, entrando no Motel, Damion pergunta a um homem que estava atendendo os outros.\nDamion Cambell: Senhor, há vagas para quartos por aqui?\nDono do Motel: Há apenas um quarto, porém está com a cama quebrada.\nDamion Cambell: Não tem problema, estou há um tempo sem um bom abrigo.\nO homem da a chave a você.\n-(Damion Cambell recebeu a chave do Quarto 7)Damion entra no quarto e sente uma presença estranha, a presença fala em sua mente.\nPresença: Olá Damion, eu sei que você é novo aqui no Reino de Averdell, me chame de Stuart, eu irei dar dicas para você conforme o tempo passa, começando por essa, NÃO confie no Reino.\nDamion: Como assim não confiar no Reino?\nStuart: ...(Você não sente mais a presença de Stuart).\nFaça sua escolha, Procure por respostas ou deixe tudo para depois.",
	TemResposta=true,
    TextoDaResposta01="Procure por respostas",
    TextoDaResposta02="Deixe tudo de lado",
    InfLevelResposta01=2,
	InfLevelResposta02=4000,
	});
	//------------------------------------------------------------------------------------------------------------//

	cigas.Add(new cingaro()
	{
	Inf = 2,
	Textinho = "Damion apenas da um cochilo e acorda rapidamente atrás de pistas, ele sai do motel e procura por jornais espalhados nas paredes das casas e comércios, tudo parece normal até ele entrar em um beco, um homem suspeito aparece.\nHomem misterioso: Nunca te vi por estas bandas.\nDamion: Não sou daqui.\nHomem misterioso: O Império vai fazer você pagar impostos, vai ficar cada vez mais caro, se junte a nossa Revolução, este Império vai cair se as coisas continuarem assim.\nDamion não sabe o que fazer e apenas fala.\nDamion: Vou pensar.\nHomem misterioso: Quando você se decidir, vá até o centro de comércios e entre na loja de botânica, haverá um atendente, fale o código "2271" para ele.\nDamion sai do beco e vai a procura de comida, quando ele volta para seu quarto de motel ele lembra que Stuart lhe falou para não confiar no Império.",
	TemResposta=true,
    TextoDaResposta01="ir ao centro",
    TextoDaResposta02="Procurar pistas sozinho.",
    InfLevelResposta01=3,
	InfLevelResposta02=4001,
	});
    //-------------------------------------------------------------------------------------------------------------//
	
	cigas.Add(new cingaro()
	{
	Inf = 3,
	Textinho = "No final da tarde, Damion vai a procura da loja de Botânica, chegando na loja de Botânica, você fala um código para o dono da loja.\nDamion: 2271\nDono da Loja: A porta ja ja vai abrir espere aqui.\nO Dono da Loja sai da bancada e uma porta subterrânea se abre em baixo da bancada, o dono chega novamente com uma tocha e fala.\nDono da Loja: Me acompanhe Senhor.\nHá uma escada enorme subterrânea embaixo da Loja, o lugar é totalmente escuro.\n Depois de aproximadamente 10 minutos descendo escadas você se depara com um altar e tem pessoas em volta, parece uma reunião, como um conselho, Damion pergunta ao dono.\nDamion: O que é tudo isso?\nDono da Loja: Um conselho de Revolucionários para mudar o Reino.\nAquele mesmo homem do beco chega em Damion e fala.\nHomem Misterioso: Olá de novo Damion, parece que você realmente confiou em mim, preciso de sua ajuda, sei que você é diferente das outras pessoas, uma premunição talvez.\nDono da Loja: Damion se junte a nós, temos algo a lhe oferecer.\nDamion fica pensativo, porém ele ja está aqui mesmo e não tem nada a perder.\nDamion: Eu me juntarei a vocês, mas eu terei benefícios?\nHomem Misterioso: Você será pago com 50 Sabugos por Mês e ajuda nossa.\nDamion: Tudo bem então, trato feito, quero que cumpram o que dizem.\nUm dos homens pegam uma pedra de coloração diferente com escrituras nela.\nDono da Loja: Pegue a Runa Damion.\nDamion pega a Runa.\n-(Damion recebeu a Runa de Terra)Descrição da Runa: Bloqueada - Desperte a Runa no Templo.\nDepois de tudo isso os Revolucionários somem como sombra na escuridão do Altar\n.Damion acompanha o Dono da Loja até o lado de fora e o a Loja de Botânica se fecha.",
	TemResposta=false,
	});
    
	//------------------------------------------------------------------------------------------------------------//

	cigas.Add(new cingaro()
	{
	Inf = 4000,
	Textinho = "Damion dorme e acorda no outro dia, ele sai do motel atrás de comida e a procura de dinheiro, um Guarda Real aparece em sua frente e fala.\nGuarda Real: Não lembro de um rosto igual o seu por aqui, pague seu imposto imediatamente.\nVocê não tem dinheiro e terá que pagar 10 Sabugos (dinheiro do Reino), você não tem dinheiro e fala para o Guarda Real.\nDamion: Não tenho dinheiro no momento, acabei de chegar no Reino.\nGuarda Real: Vou deixar passar desta vez, porém você esta devendo 10 Sabugos ao Reino.\n-(Você está devendo ao Reino).\nO Guarda Real vai embora.\nAndando pelo Reino você encontra um papel na parede de uma loja.\nEstamos procurando por um carregador de bagagens.",
	TemResposta=false,
	});

	//------------------------------------------------------------------------------------------------------------//

	cigas.Add(new cingaro()
	{
	Inf = 4001,
	Textinho = "Você não encontra nada.",
	});

}

	//---------------------------------------------------------------------------------------------------------------//

	void PreencherPagina()
  {
    labelTexto.Text = CingaroAtual.Textinho;

    if (CingaroAtual.TemResposta)
    {
      BotaoProx.IsVisible = false;
      BotaoUm.IsVisible = true;
      BotaoDois.IsVisible = true;
      BotaoUm.Text = CingaroAtual.TextoDaResposta01;
      BotaoDois.Text = CingaroAtual.TextoDaResposta02;
    }
    else
    {
      BotaoProx.IsVisible = true;
      BotaoUm.IsVisible = false;
      BotaoDois.IsVisible = false;
      
    }
  }

	//-------------------------------------------------------------------------------------------------------------------//

	void TrocaCingaroAtual(int Inf)
	{
    CingaroAtual = cigas.Where(d => d.Inf == Inf).First();
    PreencherPagina();
  }

  //------------------------------------------------------------------------------------------------

  void ClicouBotaoProx(object sender, EventArgs args)
  {
    var proximoInf = CingaroAtual.Inf + 1;
    TrocaCingaroAtual(proximoInf);
  }

  //------------------------------------------------------------------------------------------------

  void ClicouBotaoUm(object sender, EventArgs args)
  {
    TrocaCingaroAtual(CingaroAtual.InfLevelResposta01);
  }

  //------------------------------------------------------------------------------------------------

  void ClicouBotaoDois(object sender, EventArgs args)
  {
    TrocaCingaroAtual(CingaroAtual.InfLevelResposta02);
  }
}