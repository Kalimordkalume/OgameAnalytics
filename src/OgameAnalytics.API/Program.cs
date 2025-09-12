using OgameAnalytics.Infrastructure;
using Scalar.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

// Servicios e infraestructura
builder.Services.AddInfrastructure(builder.Configuration);
// Controllers Registration.
builder.Services.AddControllers();
// Domain Services Registration.
//builder.Services.AddScoped<BuildingCostService>();

// Use Case Registration
//builder.Services.AddScoped<ICalculateBuildingUpgradeCost, CalculateBuildingUpgradeCostHandler>();


//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowFrontend",
//        policy => policy.WithOrigins("https://localhost:8881")
//                        .AllowAnyHeader()
//                        .AllowAnyMethod());
//});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();




var app = builder.Build();

//app.UseCors("AllowFrontend");
app.MapOpenApi();

// Middleware
if (app.Environment.IsDevelopment())
{

    app.MapScalarApiReference();
}

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.MapControllers();

app.Run();

