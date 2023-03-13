using Microsoft.Extensions.DependencyInjection;
using PersonalFinances.Financial.Application.Commands;
using PersonalFinances.Financial.Application.Mappings;
using PersonalFinances.Financial.Domain;
using PersonalFinances.Financial.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddServices()
    .AddMongo()
    .AddRepositories();
builder.Services.AddAutoMapper(typeof(InputModelToEntityModelProfile));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddExpenseCommand).Assembly));

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
