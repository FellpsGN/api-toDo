using GerenciadorDeTarefas.Application.UseCases.Tarefas;
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegistrarTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult RegistrarTarefa([FromBody] RequestRegistrarTarefasJson request)
    {
        var useCase = new RegistrarTarefaUseCase();
        var response = useCase.Execute(request);
        return NoContent();
    }
}
