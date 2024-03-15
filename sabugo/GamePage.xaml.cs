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
	TemResposta=false
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
	}
}