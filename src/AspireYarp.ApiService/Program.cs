using AspireYarp.ApiService.Features;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapGet("/api/v1/products", ReadProducts.Endpoint);
app.MapGet("/api/v1/products/{productId:int}/pic", ReadProductPicture.Endpoint);

app.MapDefaultEndpoints();

app.Run();
