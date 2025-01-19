namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseTarefasCriadasJson
{
    public List<ResponseShortTarefasJson> Tarefas { get; set; } = new List<ResponseShortTarefasJson>();
}
