using LearnMapster.CustomMapster;
using Mapster;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);





/*
 #skip this step if you already have dotnet-tools.json
dotnet new tool-manifest 

dotnet tool install Mapster.Tool 
 */
// Add services to the container.
TypeAdapterConfig.GlobalSettings.Default
           .NameMatchingStrategy(NameMatchingStrategy.IgnoreCase)
           .IgnoreNullValues(true)
           .AddDestinationTransform((string x) => x.Trim())
           .AddDestinationTransform((string x) => x ?? "")
           .AddDestinationTransform(DestinationTransform.EmptyCollectionIfNull);

builder.Services.RegisterMapsterConfiguration();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
