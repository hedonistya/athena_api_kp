﻿using ApiHelper.ControllerHelper;
using athena_api.Context;
using athena_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace athena_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommentsController : ControllerHelper<AthenaContext, Comment, int>
{
  public CommentsController(AthenaContext context) : base(context, context.Comments, "CommentId")
  {
  }
}