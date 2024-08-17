using System.ComponentModel.DataAnnotations;
using Models.Client.Transfer;

namespace Models.Client;

public class ContaCC : Conta
{
    public ICollection<TransferCC> trans {get;} = new List<TransferCC>();
}
