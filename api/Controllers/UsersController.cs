using Microsoft.AspNetCore.Mvc;
using service;


namespace api.Controllers;

public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }
    
    [Route("/")]
    public ActionResult GetUsers()
    {
        return Ok(_service.GetUsers());
    }
}