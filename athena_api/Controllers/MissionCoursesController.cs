using ApiHelper.ControllerHelper;
using athena_api.Context;
using athena_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace athena_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskCoursesController : ControllerHelper<AthenaContext, MissionCourse, int>
{
  public TaskCoursesController(AthenaContext context) : base(context, context.MissionCourses, "MissionCourseId")
  {
  }
}