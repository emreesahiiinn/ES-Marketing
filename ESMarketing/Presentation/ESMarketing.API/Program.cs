using ESMarketing.Application.ServiceRegistration;
using ESMarketing.Application.Validators.Product;
using ESMarketing.Infrastructure.Concretes.Storage.Local;
using ESMarketing.Infrastructure.Filters;
using ESMarketing.Infrastructure.ServiceRegistration;
using ESMarketing.Persistence.DependencyRegistration;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPersistenceServices();
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();

// Storage Type
builder.Services.AddStorage<LocalStorage>();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("http://localhost:5213", "https://localhost:5213").AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddControllers(options => options.Filters.Add<ValidationFilters>())
    .AddFluentValidation(configuration =>
        configuration.RegisterValidatorsFromAssemblyContaining<ProductCreateValidator>());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors();
app.MapControllers();

app.Run();