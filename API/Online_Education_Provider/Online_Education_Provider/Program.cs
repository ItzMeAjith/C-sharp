using Microsoft.EntityFrameworkCore;
using Online_Education_Provider.Models;
using Online_Education_Provider.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Db Connection
builder.Services.AddDbContext<OnlineEducationProviderContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("OneToManyConnection")));

//For cyclic loop ignore
builder.Services.AddControllers().AddNewtonsoftJson(option=>option.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore);

//Dependency
builder.Services.AddScoped<ICourse,DerivedCourse>();
builder.Services.AddScoped<IQuiz, DerivedQuiz>();

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
