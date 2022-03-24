using ApiHelper.ControllerHelper;
using athena_api.Context;
using athena_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace athena_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompetencesController : ControllerHelper<AthenaContext, Competence, int>
{
  public CompetencesController(AthenaContext context) : base(context, context.Competences)
  {
  }
}