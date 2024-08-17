using System.ComponentModel.DataAnnotations;

namespace Models.Client.Transfer;

public abstract class Transfer
{
    [Key]
    public int id {get;set;}
    public ulong ExtratoAnterior {get;set;}
    public ulong ExtratoAtual {get;set;}
    public DateTime Created {get;set;}
}
