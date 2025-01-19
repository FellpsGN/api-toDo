using GerenciadorDeTarefas.Application.UseCases.Tarefas.Registrar;
using GerenciadorDeTarefas.Application.UseCases.Tarefas.GetTarefas;

using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseTarefasCriadasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetTarefas()
    {
        var useCase = new GetTarefasUseCase();
        var response = useCase.Execute();
        
        if(response.Tarefas.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

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
