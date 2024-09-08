using System.ComponentModel.DataAnnotations;

namespace Banquinho.Models.Client.Account.History;

public class HistoryPoupanca
{
    [Key]
    public Guid Id_history { get; set; }
    public DateTime Data_Transferencia { get; set; }
    public string? Description { get; set; }
    public string? Receptor { get; set; }
    public ulong Value { get; set; }

    public AccountPoupanca account { get; set; }
    public Guid account_Id { get; set; }
}