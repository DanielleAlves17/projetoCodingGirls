using Microsoft.EntityFrameworkCore;
using Escola.Context;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//builder.Services.AddDbContext<Escola_Context>(opt => opt.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=escola;User ID=root1;Password=Ab@caxi33"));
//builder.Services.AddDbContext<Escola_Context>(opt => opt.UseLazyLoadingProxies().UseSqlServer(@"Server = tcp:escolad.database.windows.net, 1433; Initial Catalog = Escola; Persist Security Info=False; User ID = root1; Password = Ab@caxi33; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"));
builder.Services.AddDbContext<Escola_Context>(opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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

app.UseAuthorization();

app.MapControllers();

app.Run();
