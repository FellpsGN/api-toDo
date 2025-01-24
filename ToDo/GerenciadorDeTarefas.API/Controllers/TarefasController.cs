using GerenciadorDeTarefas.Application.UseCases.Tarefas.Registrar;
using GerenciadorDeTarefas.Application.UseCases.Tarefas.GetTarefas;

using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

using Microsoft.AspNetCore.Mvc;
using GerenciadorDeTarefas.Application.UseCases.Tarefas.GetTarefaById;

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

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseShortTarefasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult GetTarefaById(int id)
    {
        var useCase = new GetTarefaByIdUseCase();
        var response = useCase.Execute(id);
        if(response == null)
        {
            return NoContent();
        }
        return Ok(response);
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
