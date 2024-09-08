using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Employee;

namespace Banquinho.Models.Contact;

public class EmployeeContacts
{
    [Key]
    public Guid Id { get; set; }
    public string? Celular { get; set; }
    public string? Telefone { get; set; }
}