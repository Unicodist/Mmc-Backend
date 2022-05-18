namespace Mmc.Notice.Entity.Interface
{
    public interface INotice
    {
        long NoticeMasterId { get; }
        string NoticeMasterTitle { get; }
        string? NoticeMasterBody { get; }
        DateTime PostedOn { get; }
        string? NoticeMasterNoticePicture { get; }
        long NoticeMasterAuthorId { get; }
        
        IUser NoticeMasterEntityAuthor { get; }
    }
}
