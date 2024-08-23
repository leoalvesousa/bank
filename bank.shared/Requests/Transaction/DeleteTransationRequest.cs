using System.ComponentModel.DataAnnotations;
using bank.shared.Enums;
using bank.shared.Requests;

namespace bank.shared.Requests.Transation;

public class DeleteTransactionRequest: Request
{
    public long Id {get; set;}
}