using Mmc.Notice.BaseType;

namespace Mmc.Notice.Entity.Interface
{
    public interface INotice
    {
        long Id { get; }
        string Title { get; }
        string? Body { get; }
        DateTime PostedOn { get; }
        string? Picture { get; }
        long AdminId { get; }
        
        INoticeUser Author { get; }
        GuidType Guid { get; set; }
    }
}
