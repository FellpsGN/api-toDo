using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefas.GetTarefas;
public class GetTarefasUseCase
{
    public ResponseTarefasCriadasJson Execute()
    {
        return new ResponseTarefasCriadasJson
        {
            Tarefas = new List<ResponseShortTarefasJson>
            { 
                new ResponseShortTarefasJson
                {
                    Id = 5,
                    Titulo = "Criar API Gerenciadora de Tarefas",
                    Descricao = "Criar uma API do zero usando a linguagem C#",
                    Prioridade = Communication.Enums.TarefasPrioridade.Alta,
                    RealizarAte = new DateTime(year: 2025, month: 01, day: 25),
                     Status = Communication.Enums.TarefasStatus.Desenvolvendo
                }
            }
        };
    }
}
