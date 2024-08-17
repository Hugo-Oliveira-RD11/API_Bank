using System.ComponentModel.DataAnnotations;

namespace Models.Client;

public abstract class Conta : People
{
    public DateTime Created {get;set;}
    public int agencia {get;set;}
    public int senha {get;set;}
    public ContaCC? corrente {get;set;}
    public ContaCP? poupanca {get;set;}
}
