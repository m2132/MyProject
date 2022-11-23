using Microsoft.EntityFrameworkCore;
using MyProject.Mock;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services;
using MyProject.WebApi;
using MyProjerct.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddServices();

builder.Services.AddDbContext<IContext, MyDbContext>();
//builder.Services.AddSingleton<IContext, MockContext>();

var MyOrigins = "_myOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyOrigins,
                      builder =>
                      {
                          builder.WithOrigins("*")
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
