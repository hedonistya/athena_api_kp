using ApiHelper.ControllerHelper;
using athena_api.Context;
using athena_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace athena_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MissionsController : ControllerHelper<AthenaContext, Mission, int>
{
  public MissionsController(AthenaContext context) : base(context, context.Missions)
  {
  }
}