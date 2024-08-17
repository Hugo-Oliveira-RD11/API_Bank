using System.ComponentModel.DataAnnotations;
using Models.Client.Transfer;

namespace Models.Client;

public class ContaCP : Conta
{
    public ICollection<TransferCP> trans {get;} = new List<TransferCP>();
}
