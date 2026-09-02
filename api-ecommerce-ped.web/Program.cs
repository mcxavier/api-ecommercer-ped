using api_ecommercer_ped.persistence.Context;
using api_ecommercer_ped.webapi.Extensions;
using api_ecommercer_ped.application.Services;
using api_ecommercer_ped.persistence;
using api_ecommercer_ped.persistence.Context;
using api_ecommercer_ped.webapi.Extensions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureApplicationApp();
builder.Services.AddCorsPolicy();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();



var app = builder.Build();


//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
