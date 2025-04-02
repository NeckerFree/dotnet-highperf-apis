using FluentValidation;
using HighPerformance.Api.Logger;
using HighPerformance.Api.Middleware;
using HighPerformance.Application;
using HighPerformance.Application.Behaviors;
using HighPerformance.Application.Interfaces;
using HighPerformance.Application.Mappings;
using HighPerformance.Application.Products.Validators;
using HighPerformance.Persistence;
using HighPerformance.Persistence.Repositories;
using MediatR;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();

// Register Application Layer services
builder.Services.AddApplication();

// Register Persistence Layer services
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddAutoMapper(typeof(ProductProfile).Assembly);
builder.Services.AddValidatorsFromAssemblyContaining<GetProductByIdQueryValidator>();
// Or register all validators in the assembly:
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
builder.Services.AddControllers();
// Register the custom file logger provider
builder.Logging.ClearProviders(); // Clear default providers
builder.Logging.AddProvider(new FileLoggerProvider($"Logs/log-{DateTime.Now:yyyy-MM-dd}.txt"));

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

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
