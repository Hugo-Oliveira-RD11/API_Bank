using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Contact;
using Banquinho.Models.Fisico;

namespace Banquinho.Models.Employeeses;


public class EmployeePeoples 
{

    [Key]
    public ulong CPF {get;set;}
    public string? First_name {get;set;}
    public string? Last_name {get;set;}
    [DataType(DataType.Date)]
    public DateOnly? nascimento {get;set;}

    public ICollection<EmployeeContacts> contacts { get; set; }
    public ICollection<EmployeeAddresses>? endereco {get;set;}
    public Employees employees { get; set; }
    public Guid EmployeeId { get; set; }
    
    [DataType(DataType.DateTime)]
    public DateTime? Created {get;} = DateTime.Now;
    [DataType(DataType.DateTime)]
    public DateTime? Modified {get;set;}
}
