using System.ComponentModel.DataAnnotations;

namespace Banquinho.Models.Client.Account.History;

public class HistoryCorrents
{
    [Key]
    public Guid Id_history { get; set; }
    public string? Description { get; set; }
    public DateTime Data_compra { get; set; }
    public string? Receptor { get; set; }
    public ulong Value { get; set; }
    
    public AccountCorrents account { get; set; }
    public Guid account_Id { get; set; }
}