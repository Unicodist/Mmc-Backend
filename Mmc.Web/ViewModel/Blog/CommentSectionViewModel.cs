namespace Mechi.Backend.ViewModel.Blog;

public class CommentSectionViewModel
{
    public IEnumerable<CommentItemViewModel> Comments { get; set; } = new List<CommentItemViewModel>();

    public void AddComments(ICollection<CommentItemViewModel> comments)
    {
        Comments = Comments.Concat(comments);
    }
        
}