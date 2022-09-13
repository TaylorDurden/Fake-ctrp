using Fake_ctrip.API.Database;
using Fake_ctrip.API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<ITouristRouteRepository, TouristRouteRepository>();
builder.Services.AddDbContext<AppDbContext>(options => {
    //options.UseSqlServer("server=192.168.56.1:143333; Database=CTripDB; User Id=sa; Password=-bash07@668aKM;");
    options.UseSqlServer(builder.Configuration["DbContext:ConnectionString"]);
    //var connectionString = builder.Configuration.GetConnectionString("MySQLConnectionString");
    //ServerVersion serverVersion = ServerVersion.AutoDetect(connectionString);
    //options.UseMySql(connectionString, serverVersion);
});
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

app.MapControllers();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/test", async context =>
    {
        await context.Response.WriteAsync("Test!");
    });
});

app.Run();
