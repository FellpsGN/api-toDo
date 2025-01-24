using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefas.GetTarefaById;

public class GetTarefaByIdUseCase
{
    public ResponseShortTarefasJson Execute(int id)
    {
        return new ResponseShortTarefasJson
        {
            Id = id,
            Titulo = "Teste API tarefas",
            Descricao = "Descrição sobre a tarefa",
            Prioridade = Communication.Enums.TarefasPrioridade.Baixa,
            RealizarAte = new DateTime(year: 2023, month: 01, day:01),
            Status = Communication.Enums.TarefasStatus.Fazer
        };
    }
}
