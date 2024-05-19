using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CourseAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CourseAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CourseAPIContext") 
	?? throw new InvalidOperationException("Connection string 'CourseAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;
	SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
