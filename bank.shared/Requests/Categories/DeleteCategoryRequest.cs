namespace bank.shared.Requests.Categories;

public class DeleteCategoryRequest : Request
{
    public string UserId {get; set;} = string.Empty;
}