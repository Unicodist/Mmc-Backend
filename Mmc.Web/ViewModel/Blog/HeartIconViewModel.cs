namespace Mechi.Backend.ViewModel.Blog;

public class HeartIconViewModel
{
    public HeartIconViewModel(string guid, int count, bool isLiked)
    {
        Guid = guid;
        Count = count;
        IsLiked = isLiked;
    }

    public string Guid { get; set; }
    public int Count { get; set; }
    public bool IsLiked { get; set; }
}
