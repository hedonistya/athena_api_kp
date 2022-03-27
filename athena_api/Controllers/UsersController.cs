using ApiHelper.ControllerHelper;
using athena_api.Context;
using athena_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace athena_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerHelper<AthenaContext, User, int>
{
  public UsersController(AthenaContext context) : base(context, context.Users, "UserId")
  {
  }
}