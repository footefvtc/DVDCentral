using Microsoft.AspNetCore.Authorization;
using BDF.DVDCentral.API.Services;
using BDF.DVDCentral.API.Models;

namespace BDF.DVDCentral.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : GenericController<User, UserManager, DVDCentralEntities>
{
    private IUserService _userService;
    private readonly ILogger<UserController> logger;
    private readonly DbContextOptions<DVDCentralEntities> options;

    public UserController(IUserService userService,
                          ILogger<UserController> logger,
                          DbContextOptions<DVDCentralEntities> options) : base(logger, options)
    {
        this._userService = userService;
        this.options = options;
        this.logger = logger;
    }

    /// <summary>
    /// Used to authenticate a user
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest model)
    {
        var response = _userService.Authenticate(model);

        if (response == null)
        {
            logger.LogWarning("Authentication unsuccessful for {UserId}", model.UserId);
            return BadRequest(new { message = "Username or password is incorrect" });
        }
        logger.LogWarning("Authentication successful for {UserId}", model.UserId);
        return Ok(response);
    }

    [Microsoft.AspNetCore.Authorization.Authorize]
    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var users = _userService.GetAll();
        return Ok(users);
    }

    //[Authorize]
    //[HttpGet]

    //public IEnumerable<User> Get1()
    //{
    //    logger.LogWarning("Get Users");
    //    //return await new UserManager(options).LoadAsync().Result;
    //    return null;
    //    //return _userService.GetAll();
    //}
}
