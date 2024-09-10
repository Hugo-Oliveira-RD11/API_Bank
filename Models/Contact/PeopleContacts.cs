using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Client;

namespace Banquinho.Models.Contact;

public class PeopleContacts
{
    [Key]
    public Guid ID { get; set; }
    public string? Celular { get; set; }
    public string? Telefone { get; set; }
    
    public Peoples? people { get; set; }
    public ulong CPF_Id { get; set; }
    
}