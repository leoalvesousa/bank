namespace bank.shared.Requests.Categories;

public class GetCategoryById : Request
{
    public string UserId {get; set;} = string.Empty;
}