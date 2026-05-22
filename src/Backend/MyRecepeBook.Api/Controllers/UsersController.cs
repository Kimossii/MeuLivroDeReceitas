using Microsoft.AspNetCore.Mvc;
using MyRecepeBook.Communication.Requests;

namespace MyRecepeBook.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterUserAccountJson request)
    {
        //Registo uma conta de uma pessoa
        return Created();
    }
}
