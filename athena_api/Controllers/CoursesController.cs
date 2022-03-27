using ApiHelper.ControllerHelper;
using athena_api.Context;
using athena_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace athena_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerHelper<AthenaContext, Course, int>
{
  public CoursesController(AthenaContext context) : base(context, context.Courses, "CourseId")
  {
  }
}