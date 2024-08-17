using System.ComponentModel.DataAnnotations;

namespace Models.Client.Transfer;

public abstract class Transfer
{
    [Key]
    public int id {get;set;}
    public ulong ValorAnterior {get;set;}
    public ulong ValorAtual {get;set;}
    public DateTime Created {get;set;}
}
