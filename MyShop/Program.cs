using Microsoft.EntityFrameworkCore;
using MyShop.DataLayer.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Add Context

builder.Services.AddDbContext<MyShopDBContext>(options => 
{
   var connectionString = builder.Configuration.GetConnectionString("MyShopDbContext");
    options.UseSqlServer(connectionString);
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

