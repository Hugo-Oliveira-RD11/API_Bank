using Banquinho.Infra.DataConnection.Postgres;
using Banquinho.Infra.Repository.Client.Account;
using Banquinho.Infra.Repository.Employee;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContextPSQL>( op 
    => op.UseNpgsql(builder.Configuration.GetConnectionString("AppDbContextPSQL")));

builder.Services.AddTransient<IAccountCorrentRepository, AccountCorrentRepository>();
builder.Services.AddTransient<IAccountPoupancaRepository, AccountPoupancaRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IAccountPoupancaRepository, AccountPoupancaRepository>();

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
