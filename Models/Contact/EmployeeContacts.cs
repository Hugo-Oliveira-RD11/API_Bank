using Banquinho.Models.Employee;

namespace Banquinho.Models.Contact;

public class EmployeeContacts
{
    public Guid Id { get; set; }
    
    public Contacts contacts { get; set; }
    public Guid contacts_id { get; set; }

    public Employees employee { get; set; }
    public ulong CPF_id { get; set; }
}