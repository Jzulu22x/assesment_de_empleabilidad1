using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using assessmente_de_empleabilidad.Data;

Env.Load();
var host = Environment.GetEnvironmentVariable("DB_HOST");
var databaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var username = Environment.GetEnvironmentVariable("DB_USERNAME");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
var connectionString = $"server={host};port={port};database={databaseName};uid={username};password={password}";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.20-mysql")));
builder.Services.AddControllers();

// Agregar soporte para Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();  // Aquí agregas Swagger

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

// Habilitar el middleware de Swagger en la aplicación
if (app.Environment.IsDevelopment())  // Solo en desarrollo para no exponerlo en producción
{
    app.UseSwagger();
    app.UseSwaggerUI();  // Esto genera la interfaz de usuario interactiva de Swagger
}

app.Run();
