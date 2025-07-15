using Microsoft.EntityFrameworkCore;
using Offer_API.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<OfferDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("defCon")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowReactApp");
//app.UseHttpsRedirection(); ����� � ������ ������ ����� ���� �� ������ ��� ����� ���������� � ��� ��� �����
app.UseAuthorization();
app.MapControllers();
app.Run();
