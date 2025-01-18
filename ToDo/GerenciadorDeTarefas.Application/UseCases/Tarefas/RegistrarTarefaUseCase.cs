using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefas;

public class RegistrarTarefaUseCase
{
    public ResponseRegistrarTarefa Execute(RequestRegistrarTarefasJson request)
    {
        return new ResponseRegistrarTarefa
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
