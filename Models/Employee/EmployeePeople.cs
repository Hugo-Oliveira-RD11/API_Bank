using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Contact;

namespace Banquinho.Models.Employee;


public class EmployeePeople 
{
    [Key]
    public ulong CPF {get;set;}
    public string? First_name {get;set;}
    public string? Last_name {get;set;}
    [DataType(DataType.Date)]
    public DateOnly? nascimento {get;set;}

    public EmployeeContacts contacts { get; set; }
    public Guid Id { get; set; }
    
    [DataType(DataType.DateTime)]
    public DateTime? Created {get;set;}
    [DataType(DataType.DateTime)]
    public DateTime? Modified {get;set;}
}
