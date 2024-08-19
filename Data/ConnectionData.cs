using Microsoft.EntityFrameworkCore;
using Models;
using Models.Client;
using Models.Client.Transfer;
using Models.Employee;
using Models.Fisico;

namespace Data;

public class ConnecionData : DbContext
{
    public DbSet<Endereco> Endereco {get;set;}
    public DbSet<Agencia> Agencia {get;set;}
    public DbSet<ContaCC> ContaCC {get;set;}
    public DbSet<ContaCP> ContaCP {get;set;}
    public DbSet<TransferCC> TransferCC {get;set;}
    public DbSet<TransferCP> TransferCP {get;set;}
    public DbSet<Funcionario> Funcionario {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql("Server=localhost;" + "Port=5432;Database=Banquinho" + "User Id = postgresl" + "Password=nada");
}
