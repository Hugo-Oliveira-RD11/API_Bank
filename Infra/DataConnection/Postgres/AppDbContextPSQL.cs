using Banquinho.Models.Client;
using Banquinho.Models.Client.Account;
using Banquinho.Models.Client.Account.History;
using Banquinho.Models.Contact;
using Banquinho.Models.Employeeses;
using Banquinho.Models.Fisico;
using Microsoft.EntityFrameworkCore;

namespace Banquinho.Infra.DataConnection.Postgres;

public class AppDbContextPSQL : DbContext
{
    public AppDbContextPSQL(DbContextOptions<AppDbContextPSQL> op) : base(op)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // relations
            modelBuilder.Entity<Peoples>()
                .HasOne(e => e.accountCorrents)
                .WithOne(e => e.people)
                .HasForeignKey<AccountCorrents>(e => e.CPF_id)
                .IsRequired();

            modelBuilder.Entity<Peoples>()
                .HasOne(e => e.accountSavings)
                .WithOne(e => e.people)
                .HasForeignKey<AccountSavings>(e => e.CPF_id)
                .IsRequired();
            
            modelBuilder.Entity<Peoples>()
                .HasMany<PeopleContacts>(e => e.peopleContacts)
                .WithOne(e => e.people)
                .HasForeignKey(e => e.CPF_Id)
                .IsRequired();
            
            modelBuilder.Entity<Peoples>()
                .HasMany<PeopleAddresses>(e => e.peopleEndereco)
                .WithOne(e => e.people)
                .HasForeignKey(e => e.CPF_id)
                .IsRequired();

            modelBuilder.Entity<AccountCorrents>()
                .HasMany<HistoryCorrents>(e => e.history_mouth)
                .WithOne(e => e.account)
                .HasForeignKey(e => e.account_Id)
                .IsRequired();
            
            modelBuilder.Entity<AccountSavings>()
                .HasMany<HistorySavings>(e => e.history)
                .WithOne(e => e.account)
                .HasForeignKey(e => e.account_Id)
                .IsRequired();
            // end client relations

            modelBuilder.Entity<Employees>()
                .HasOne<EmployeePeoples>(e => e.EmployeePeoples)
                .WithOne(e => e.employees)
                .HasForeignKey<EmployeePeoples>(e => e.EmployeeId)
                .IsRequired();
            modelBuilder.Entity<EmployeePeoples>()
                .HasMany<EmployeeAddresses>(e => e.endereco)
                .WithOne(e => e.employee)
                .HasForeignKey(e => e.CPF_Id)
                .IsRequired();
            
            modelBuilder.Entity<EmployeePeoples>()
                .HasMany<EmployeeContacts>(e => e.contacts)
                .WithOne(e => e.employeePeoples)
                .HasForeignKey(e => e.CPF_id)
                .IsRequired();

        }

    public DbSet<EmployeeAddresses> EmployeeAddress { get; set; }
    public DbSet<PeopleAddresses> PeopleAddress { get; set; }
    public DbSet<EmployeeContacts> EmployeeContact { get; set; }
    public DbSet<PeopleContacts> PeopleContact { get; set; }
    public DbSet<Employees> Employee { get; set; }
    public DbSet<EmployeePeoples> EmployeePeople { get; set; }
    public DbSet<Peoples> People { get; set; }
    public DbSet<AccountCorrents> AccountCorrent { get; set; }
    public DbSet<AccountSavings> AccountSavings { get; set; }
    public DbSet<HistoryCorrents> HistoryCorrent { get; set; }
    public DbSet<HistorySavings> HistorySavings { get; set; }
}