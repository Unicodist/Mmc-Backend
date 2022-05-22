namespace Mechi.Backend.ViewModel;

public class BlogPaginationViewModel
{
    public int CurrentPage { get; set; }
    public int TotalPageCount { get; set; }
    public bool FirstPage { get; set; }
    public bool LastPage { get; set; }
}