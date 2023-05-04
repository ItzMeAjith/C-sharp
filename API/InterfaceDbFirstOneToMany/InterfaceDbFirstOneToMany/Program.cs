using InterfaceDbFirstOneToMany.Models;
using InterfaceDbFirstOneToMany.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dbconnection
builder.Services.AddDbContext<BankContext>(op=>op.UseSqlServer(builder.Configuration.GetConnectionString("OneToManyConnection")));

//Cylic
builder.Services.AddControllers().AddNewtonsoftJson(options=>options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore);

//Instance for class and interface
builder.Services.AddScoped<IAccountInfo,DerivedAccountInfo>();

builder.Services.AddScoped<ITransactions,DerivedTransactions>();


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
