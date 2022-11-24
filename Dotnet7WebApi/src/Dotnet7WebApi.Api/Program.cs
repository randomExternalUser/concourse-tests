using Dotnet7WebApi.Domain.Interfaces;
using Dotnet7WebApi.Infrastructure.DataAccess;
using Dotnet7WebApi.Infrastructure.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ApplicationDbContext>();
builder.Services.AddScoped<IItemsRepository, ItemsRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
