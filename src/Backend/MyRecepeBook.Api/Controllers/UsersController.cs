using Microsoft.AspNetCore.Mvc;
using MyRecepeBook.Application.UseCases.User.Register;
using MyRecepeBook.Communication.Requests;

namespace MyRecepeBook.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterUserAccountJson request)
    {
        Console.WriteLine("CONTROLLER CHAMADO");
        //Registo uma conta de uma pessoa
        var UseCase = new RegisterUserAccountUseCase();
        UseCase.Execute(request);
        return Created();
    }
}
