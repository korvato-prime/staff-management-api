using Microsoft.EntityFrameworkCore;
using StaffManagement;
using StaffManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddDbContext<EmployeeDBContext>(options => options.UseInMemoryDatabase("Employees"));
builder.Services.AddDbContext<EmployeeDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StaffAppConnection")));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();


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

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();