using LeaveAllowance.Application.LeaveType;
using LeaveAllowance.Application.LeaveTypes;
using LeaveAllowance.Application.Mapping;
using LeaveAllowance.Domain.LeaveTypes;
using LeaveAllowance.EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//configuration for postgre database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"))
);
//register automapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

//custom services
builder.Services.AddScoped<ILeaveTypeService, LeaveTypeService>();


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
