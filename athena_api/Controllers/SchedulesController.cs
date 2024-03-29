﻿using ApiHelper.ControllerHelper;
using athena_api.Context;
using athena_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace athena_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SchedulesController : ControllerHelper<AthenaContext, Schedule, int>
{
  public SchedulesController(AthenaContext context) : base(context, context.Schedules, "ScheduleId")
  {
  }
}