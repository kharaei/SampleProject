using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Application.Usecases.User.Command.Registration;

namespace SampleProject.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Insert(RegistrationCommand request, CancellationToken cToken)
    {
        var newEntityId = await mediator.Send(request, cToken);
        return Ok(newEntityId);
    }
}