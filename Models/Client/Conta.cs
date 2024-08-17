using System.ComponentModel.DataAnnotations;

namespace Models.Client;

public abstract class Conta
{
    [Key]
    public int id {get;set;}
    public People? people {get;set;}
    public DateTime Created {get;set;}
    public int agencia {get;set;}
    public int senha {get;set;}
}
