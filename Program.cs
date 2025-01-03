using dressed_backend.Data;
using dressed_backend.Repositories;
using dressed_backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<DesignRepository>();
builder.Services.AddScoped<DesignService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
   
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
