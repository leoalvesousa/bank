using bank.shared.Enums;

namespace bank.shared.Models;

public class Transaction
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;

    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime PaidOrRecivedAt {get; set;}

    public ETransactionsType Type {get; set;} = ETransactionsType.Withdraw;
    public long CategoryId {get; set;}
    public Category Category {get; set;} = null!;

    public string UserId {get; set;} = string.Empty;
}