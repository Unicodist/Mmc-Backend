namespace Mmc.Blog.Dto;

public class CommentUpdateDto : CommentCreateDto
{
    public CommentUpdateDto(long id, string guid, string articleGuid, string body, long userId) : base(articleGuid, body, userId)
    {
        Id = id;
    }

    public long Id { get; protected set; }
}