using System.ComponentModel.DataAnnotations;

namespace Banquinho.Models.Contact;

public class Contacts
{
    [Key]
    public Guid ID { get; set; }
    public string? Celular { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    
}