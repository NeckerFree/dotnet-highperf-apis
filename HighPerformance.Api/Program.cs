using HighPerformance.Application;
using HighPerformance.Application.Interfaces;
using HighPerformance.Application.Mappings;
using HighPerformance.Persistence;
using HighPerformance.Persistence.Repositories;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

// Register Application Layer services
builder.Services.AddApplication();

// Register Persistence Layer services
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddAutoMapper(typeof(ProductProfile).Assembly);
builder.Services.AddControllers();

// Add CORS policy
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAll", policy =>
//    {
//        policy.AllowAnyOrigin()
//              .AllowAnyMethod()
//              .AllowAnyHeader();
//    });
//});

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
