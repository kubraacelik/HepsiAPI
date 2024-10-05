using HepsiApi.Persistence;
using HepsiApi.Application;
using HepsiApi.Mapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// uygulama farkl� ortamlar i�in �zelle�tirilmi� ayarlarla �al��t�r�labilir.
var env = builder.Environment;
builder.Configuration
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

// uygulaman�n hizmetlerine veritaban� ba�lam�n� (DbContext) ekler.
builder.Services.AddPersistence(builder.Configuration);
// ba��ml�l�klar i�in eklendi
builder.Services.AddApplication();
builder.Services.AddCustomMapper();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
