using H1Store.Catalogo.Application.AutoMapper;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.Services;
using H1Store.Catalogo.Data.EntityFramework;
using H1Store.Catalogo.Data.Repository;
using H1Store.Catalogo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
});

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

builder.Services.AddScoped<ICartaRepository, CartaRepository>();
builder.Services.AddScoped<ICartaService, CartaService>();


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
