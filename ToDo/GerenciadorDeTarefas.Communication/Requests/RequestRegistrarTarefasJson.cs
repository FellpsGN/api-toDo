using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Requests;

public class RequestRegistrarTarefasJson
{
    public string Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public TarefasPrioridade Prioridade { get; set; }
    public DateTime? RealizarAte { get; set; }
    public TarefasStatus Status { get; set; }

}
