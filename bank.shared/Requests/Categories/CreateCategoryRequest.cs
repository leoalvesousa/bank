using System.ComponentModel.DataAnnotations;

namespace bank.shared.Requests.Categories;

public class CreateCategoryRequest : Request
{
[Required (ErrorMessage ="Título Inválido")]
[MaxLength(80, ErrorMessage = "O Título deve conter até 80 caracteres")]
public string Title { get; set; } = string.Empty;

[Required(ErrorMessage = "Descrição Inválida")]
public string Description {get; set;} = string.Empty;
}