using Banquinho.Models.Client;
using Banquinho.Models.Client.Account;
using Banquinho.Models.Client.Account.History;
using Banquinho.Models.Contact;
using Banquinho.Models.Employee;
using Banquinho.Models.Fisico;
using Microsoft.EntityFrameworkCore;

namespace Banquinho.DataConnection.Postgres;

public class AppDbContextPSQL : DbContext
{
    public AppDbContextPSQL(DbContextOptions<AppDbContextPSQL> op) : base(op)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // relations
            modelBuilder.Entity<People>()
                .HasOne(e => e.accountCorrent)
                .WithOne(e => e.people)
                .HasForeignKey<AccountCorrent>(e => e.CPF_id)
                .IsRequired();

            modelBuilder.Entity<People>()
                .HasOne(e => e.accountPoupanca)
                .WithOne(e => e.people)
                .HasForeignKey<AccountPoupanca>(e => e.CPF_id)
                .IsRequired();
            
            modelBuilder.Entity<People>()
                .HasMany<PeopleContacts>(e => e.peopleContacts)
                .WithOne(e => e.people)
                .HasForeignKey(e => e.CPF_Id)
                .IsRequired();
            
            modelBuilder.Entity<People>()
                .HasMany<PeopleEndereco>(e => e.peopleEndereco)
                .WithOne(e => e.people)
                .HasForeignKey(e => e.CPF_id)
                .IsRequired();

            modelBuilder.Entity<AccountCorrent>()
                .HasMany<HistoryCorrent>(e => e.history_mouth)
                .WithOne(e => e.account)
                .HasForeignKey(e => e.account_Id)
                .IsRequired();
            
            modelBuilder.Entity<AccountPoupanca>()
                .HasMany<HistoryPoupanca>(e => e.history)
                .WithOne(e => e.account)
                .HasForeignKey(e => e.account_Id)
                .IsRequired();
            // end client relations

            modelBuilder.Entity<Employees>()
                .HasOne<EmployeePeople>(e => e.EmployeePeople)
                .WithOne(e => e.employees)
                .HasForeignKey<EmployeePeople>(e => e.EmployeeId)
                .IsRequired();
            modelBuilder.Entity<Employees>()
                .HasMany<EmployeeEndereco>(e => e.endereco)
                .WithOne(e => e.employee)
                .HasForeignKey(e => e.CPF_Id)
                .IsRequired();

        }
}