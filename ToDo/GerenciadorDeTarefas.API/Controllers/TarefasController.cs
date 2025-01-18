using GerenciadorDeTarefas.Application.UseCases.Tarefas;
using GerenciadorDeTarefas.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    [HttpPost]

    public IActionResult RegistrarTarefa([FromBody] RequestRegistrarTarefasJson request)
    {
        var useCase = new RegistrarTarefaUseCase();
        var response = useCase.Execute(request);
        return NoContent();
    }
}
