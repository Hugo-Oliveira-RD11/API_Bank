using System.ComponentModel.DataAnnotations;
using Models.Fisico;

namespace Models.Client;

public abstract class Conta : People
{
    public uint senha {get;set;}
    public DateTime Created {get;set;}
}
