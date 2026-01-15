using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.Api.Middleware;
using System.Text.Json.Serialization;
using ecommerce.Core.Mappers;
using FluentValidation.AspNetCore;
var builder = WebApplication.CreateBuilder(args);
//Add Infrastructure Service 
builder.Services.AddInfrastructure();
//Add Core Service 
builder.Services.AddCore();
// Add controllers to the service collection
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile));
//FluentValidations
builder.Services.AddFluentValidationAutoValidation();

var app = builder.Build();
//add ExceptionalHandlingMidddleWare
app.UseExceptionHandlingMiddleware();
//Routing 
//app.UseRouting(); // in asp.net core 8 not required
app.UseAuthorization();

//Add Controller routes
app.MapControllers();
app.Run();
