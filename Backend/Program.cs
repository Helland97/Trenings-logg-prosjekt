using Microsoft.EntityFrameworkCore;
using Trenings_logg_prosjekt.Backend.Data;

var builder = WebApplication.CreateBuilder(args);

// --------------------
// Services
// --------------------

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

// --------------------
// Middleware
// --------------------

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
