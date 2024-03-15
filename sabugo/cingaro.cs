// clases que serão utilizadas na troca de paginas e no desenvolvimento do jogo! //
public class cingaro
{
     public int Inf; // Esse é o código da parte da história, que deve ser único para cada HistoryStep
  public string? Textinho; // Atributo para guardar o Texto que vai aparecer para o usuario
  public bool TemImagem = false; // Atributo para dizer se tem ou não uma imagem para mostrar
  public string? UrlDaImagem; // Em caso de ter imagem, esse atributo vai guardar OU o endereço da Imagem, ou o nome da Imagem (se ela estiver em resources/images)
  public bool TemResposta = false; // Atributo para dizer se é um texto para contar a história ou se é preciso responder algo para continuar
  public string? TextoDaResposta01; // Texto do primeiro botão de resposta
  public string? TextoDaResposta02; // Texto do segundo botão de resposta
  public int InfLevelResposta01; // Para qual Código do HistoryStep que o primeiro botão de respostas deve levar 
  public int InfLevelResposta02; // Para qual Código do HistoryStep que o segundo botão de respostas deve levar 
}