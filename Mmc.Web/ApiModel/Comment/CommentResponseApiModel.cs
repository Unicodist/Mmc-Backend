namespace Mechi.Backend.ApiModel.Comment;

public class CommentResponseApiModel
{
    public string Guid { get; set; }
    public string Body { get; set; }
    public bool SelfAuthor { get; set; }
}