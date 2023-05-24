using Microsoft.EntityFrameworkCore;
using WEB_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<API_MenuDbContext>(options=>options.UseSqlServer("data source=DESKTOP-GL7RKG7\\SQLEXPRESS;database=DBAPI;integrated security=true;trustservercertificate=true;"));
builder.Services.AddCors(op=>
{
    op.AddPolicy("MyHotelPolicy", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();


    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("MyHotelPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
