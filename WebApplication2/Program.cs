using Microsoft.EntityFrameworkCore;
using proyectoef.Models.Context;

var builder = WebApplication.CreateBuilder(args);

//Se agrega DbContext
builder.Services.AddDbContext<TareaContext>(opt => opt.UseInMemoryDatabase("TareasDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
