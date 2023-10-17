using Microsoft.EntityFrameworkCore;
using TestesDeIntegracao.Data;
using TestesDeIntegracao.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProdutoDbContext>
    (opts =>
    {
        opts.UseSqlServer(builder.Configuration.
        GetConnectionString("DataBaseConnection"));
    });

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ProdutoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

public partial class Program { }
