using System.ComponentModel.DataAnnotations;

namespace Models.Client.Transfer;

public class TransferCP : Transfer
{
    public ContaCP? conta {get;set;}
    public bool operation {get;set;}
    public ulong limite {get;set;}
    public int Saldo {get;set;} // pensar em melhorar com redis ou redimencionando as tabelas!

    TransferCP()
    {
        this.limite = 200;
        this.Saldo = 0;
        this.Created = DateTime.Now;
    }
}
