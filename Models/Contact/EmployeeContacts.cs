using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Employeeses;

namespace Banquinho.Models.Contact;

public class EmployeeContacts
{
    [Key]
    public Guid Id { get; set; }
    public string? Celular { get; set; }
    public string? Telefone { get; set; }

    public EmployeePeoples employeePeoples { get; set; }
    public ulong CPF_id { get; set; }
}