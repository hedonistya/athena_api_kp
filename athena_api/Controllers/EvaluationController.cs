using ApiHelper.ControllerHelper;
using athena_api.Context;
using athena_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace athena_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EvaluationController : ControllerHelper<AthenaContext, Evaluation, int>
{
  public EvaluationController(AthenaContext context) : base(context, context.Evaluations)
  {
  }
}