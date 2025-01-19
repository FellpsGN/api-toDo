using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefas;

public class RegistrarTarefaUseCase
{
    public ResponseRegistrarTarefaJson Execute(RequestRegistrarTarefasJson request)
    {
        return new ResponseRegistrarTarefaJson
        {
            Id = request.Id,
            Titulo = request.Titulo,
            Descricao = request.Descricao,
            Prioridade = request.Prioridade,
            RealizarAte = request.RealizarAte,
            Status = request.Status
        };
    }
}
