namespace bank.shared.Requests.Categories;

public class CreateCategoryRequest : Request
{
    public string UserId {get; set;} = string.Empty;
}