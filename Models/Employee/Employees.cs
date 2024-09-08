using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Fisico;

namespace Banquinho.Models.Employee;

public enum Cargo{gerente = 1, subgerente =2, balconista=3}

public class Employees
{
    [Key]
    public Guid Id { get; set; }
    public uint codigo {get;set;}
    public uint agencia {get;set;}
    public uint senha {get;set;}
    public Cargo cargo  {get;set;}
    public DateTime? Created {get;set;}
    public bool Ativo {get;set;}
    
    public ICollection<EmployeeEndereco>? endereco {get;set;}

    public EmployeePeople EmployeePeople { get; set; }
}