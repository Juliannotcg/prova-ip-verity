using MediatR;
using Microsoft.AspNetCore.Mvc;
using Prova.Application.Services;
using Prova.Application.ViewModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(PasswordService));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapFallback(() => Results.Redirect("/swagger"));
app.UseHttpsRedirection();


app.MapGet("api/password/{password}", async ([FromServices] IMediator _mediator, string password) =>
{
    var pass = new InputPassViewModel()
    {
        Password = password,
    };

    return await _mediator.Send(pass);
})
.WithName("ValidationPassword");

app.Run();

