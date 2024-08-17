using System.ComponentModel.DataAnnotations;
using Models;
using Models.Fisico;

namespace Models.Employee;

public enum Cargo{gerente = 1, subgerente =2}

public class Funcionario : People
{
    public uint codigo {get;set;}
    public uint senha {get;set;}
    public Cargo cargo  {get;set;}
    public DateTime? Created {get;set;}
}
