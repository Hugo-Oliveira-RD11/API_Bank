using System.ComponentModel.DataAnnotations;

namespace Models.Client.Transfer;

public class TransferCC : Transfer
{
    public ContaCC? conta {get;set;}
    public ulong limite {get;set;}

    TransferCC()
    {
        this.limite = 1000;
    }
}
