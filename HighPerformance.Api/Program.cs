using HighPerformance.Application;
using HighPerformance.Application.Interfaces;
using HighPerformance.Application.Products.Commands;
using HighPerformance.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

//builder.Services.AddInfrastructure();
// Register Application Layer services
builder.Services.AddApplication();

// Register Infrastructure Layer services
//builder.Services.AddInfrastructure();

// Register Persistence Layer services
//builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateProductCommand).Assembly)); // Fix the error here

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
