using HepsiApi.Persistence;
using HepsiApi.Application;
using HepsiApi.Mapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// uygulama farklý ortamlar için özelleþtirilmiþ ayarlarla çalýþtýrýlabilir.
var env = builder.Environment;
builder.Configuration
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

// uygulamanýn hizmetlerine veritabaný baðlamýný (DbContext) ekler.
builder.Services.AddPersistence(builder.Configuration);
// baðýmlýlýklar için eklendi
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
