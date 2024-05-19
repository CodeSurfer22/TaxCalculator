using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using TaxCalculator.API.BusinessLogic.Interfaces;
using TaxCalculator.API.BusinessLogic;
using TaxCalculator.API.Data;

var builder = WebApplication.CreateBuilder(args);

//Register services
builder.Services.AddSingleton<ITaxCalculatorService, TaxCalculatorService>();

// Add services to the container.

builder.Services.AddControllers();

// Add Entity Framework Core and configure the connection string
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Ensure the database is created and migrations are applied
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();
}

app.Run();
