namespace bank.shared.Requests;

public class PagedRequest : Request
{
    public int PageSize {get; set;} = Configurantion.DefaultPageSize;
    public int PageNumber {get; set;} = Configurantion.DefaultPageNumber;
}