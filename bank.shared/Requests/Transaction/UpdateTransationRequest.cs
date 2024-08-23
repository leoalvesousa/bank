using System.ComponentModel.DataAnnotations;
using bank.shared.Enums;
using bank.shared.Requests;

namespace bank.shared.Requests.Transation;

public class UpdateTransactionRequest: Request
{
    [Required(ErrorMessage = "Título Inválido")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tipo Inválido")]
    public ETransactionsType Type {get;set;} = ETransactionsType.Withdraw;

    [Required(ErrorMessage = "Valor Inválido")]
    public decimal Amount { get; set; } 

    [Required(ErrorMessage = "Categoria Inválido")]
    public long CategoryId { get; set; }

     public long Id {get; set; }
}