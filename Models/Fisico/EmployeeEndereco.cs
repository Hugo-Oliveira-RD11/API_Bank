using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Employee;

namespace Banquinho.Models.Fisico;

public class EmployeeEndereco : Endereco
{
    /*[Key]
    public Guid id {get;set;}
    public string? Bairro {get;set;}
    public uint NumCasa {get;set;}
    public uint CEP {get;set;}
    public string? Cidade {get;set;}
    public string? Rua {get;set;}
    public string? Estato {get;set;}
    [DataType(DataType.DateTime)]
    public DateTime? Created {get;set;}*/

    public Employees employee { get; set; }
    public Guid CPF_Id {get;set;}
}