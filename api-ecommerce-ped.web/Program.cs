using api_ecommercer_ped.persistence.Context;
using api_ecommercer_ped.webapi.Extensions;
using api_ecommercer_ped.application.Services;
using api_ecommercer_ped.persistence;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureApplicationApp();
builder.Services.AddCorsPolicy();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();



var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
