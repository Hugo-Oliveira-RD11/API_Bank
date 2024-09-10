using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Client.Account;
using Banquinho.Models.Contact;
using Banquinho.Models.Fisico;

namespace Banquinho.Models.Client;

public class Peoples
{
    [Key]
    public ulong CPF {get;set;}
    public string? First_name {get;set;}
    public string? Last_name {get;set;}
    [DataType(DataType.Date)]
    public DateOnly? nascimento {get;set;}
    public string? Celular { get; set; }
    public string? Email { get; set; }

    public AccountCorrents accountCorrents { get; set; }
    public AccountSavings accountSavings { get; set; }

    public ICollection<PeopleContacts> peopleContacts { get; set; } = new List<PeopleContacts>(); 
    
    public ICollection<PeopleAddresses> peopleEndereco { get; set; }
    
    
    [DataType(DataType.DateTime)]
    public DateTime? Created {get;set;}
    [DataType(DataType.DateTime)]
    public DateTime? Modified {get;set;}
}
