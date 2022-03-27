using athena_api.Context;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AthenaContext>(options =>
  options.UseSqlServer(
    "Server=sql5107.site4now.net;Database=db_a8415f_athena;User Id=db_a8415f_athena_admin;Password=1234Qwer#;Trusted_Connection=false;Integrated Security=false"));
builder.Services.AddControllers().AddNewtonsoftJson(
  options => options.SerializerSettings.ReferenceLoopHandling =
    ReferenceLoopHandling.Ignore
);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();