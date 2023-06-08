using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shelter.Application.Abstractions;
using Shelter.Application.Commands;
using Shelter.Application.Queries;
using Shelter.Infrastructure;
using Shelter.Infrastructure.Repositoties;

var builder = WebApplication.CreateBuilder(args);
var cs = builder.Configuration.GetConnectionString("Defaut");
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ComentDbContext>(opt => opt.UseSqlServer(cs));
builder.Services.AddScoped<IComentGlobRepository, ComentGlobRepository>();
builder.Services.AddScoped<IComentGoodRepository, ComentGoodRepository>();
builder.Services.AddScoped<IComentKindAnimalsRepository, ComentKindOfAnimalsRepository>();
builder.Services.AddMediatR(typeof(CreateComentGlob));
builder.Services.AddMediatR(typeof(CreateComentGood));
builder.Services.AddMediatR(typeof(CreateComentKindAnimals));
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

app.MapGet("/api/comentglob/{id}", async (IMediator mediator, int id) => {
    var getComentglob = new GetComentGlobById { ComentGlobId = id };
    var _comentglob = await mediator.Send(getComentglob);
    return Results.Ok(_comentglob);
}).WithName("GetComentGlobById") ;
app.MapPost("/api/comentglob", async (IMediator mediator, ComentGlob comentGlob) =>
{
    var createComentGlob = new CreateComentGlob { ComentGlobText = comentGlob.Text };
    var createdComentGlob = await mediator.Send(createComentGlob);
    return Results.CreatedAtRoute("GetComentGlobById", new { createdComentGlob.Id }, createdComentGlob);
});
app.MapGet("/api/comentglob", async (IMediator mediator) =>
{
    var getComentglob = new GetAllComentGlob();
    var _comentglob = await mediator.Send(getComentglob);
    return TypedResults.Ok(_comentglob);
});

app.MapGet("/api/comentgood/{id}", async (IMediator mediator, int id) => {
    var getComentgood = new GetComentGoodById { ComentGoodId = id };
    var _comentgood = await mediator.Send(getComentgood);
    return Results.Ok(_comentgood);
}).WithName("GetComentGoodById");
app.MapPost("/api/comentgood", async (IMediator mediator, ComentGlob comentGood) =>
{
    var createComentGood = new CreateComentGood { ComentGoodText = comentGood.Text };
    var createdComentGood = await mediator.Send(createComentGood);
    return Results.CreatedAtRoute("GetComentGoodById", new { createdComentGood.Id }, createdComentGood);
});
app.MapGet("/api/comentgood", async (IMediator mediator) =>
{
    var getComentgood = new GetAllComentGood();
    var _comentgood = await mediator.Send(getComentgood);
    return TypedResults.Ok(_comentgood);
});

app.MapGet("/api/comentkindanimals/{id}", async (IMediator mediator, int id) => {
    var getComentkindanimals = new GetComentKindAnimalsById { ComentKindAnimalsId = id };
    var _comentkindanimals = await mediator.Send(getComentkindanimals);
    return Results.Ok(_comentkindanimals);
}).WithName("GetComentKindAnimalsById");
app.MapPost("/api/comentkindanimals", async (IMediator mediator, ComentKindAnimals comentKindAnimals) =>
{
    var createComentKindAnimals = new CreateComentKindAnimals { ComentKindAnimalsText = comentKindAnimals.Text };
    var createdComentKindAnimals = await mediator.Send(createComentKindAnimals);
    return Results.CreatedAtRoute("GetComentKindAnimalsById", new { createdComentKindAnimals.Id }, createdComentKindAnimals);
});
app.MapGet("/api/comentkindanimals", async (IMediator mediator) =>
{
    var getComentkindAnimals = new GetAllComentKindAnimals();
    var _comentkindAnimals = await mediator.Send(getComentkindAnimals);
    return TypedResults.Ok(_comentkindAnimals);
});
app.Run();