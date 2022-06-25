using Mmc.Notice.BaseType;
using Mmc.Notice.Enum;

namespace Mmc.Notice.Entity.Interface
{
    public interface INotice
    {
        long Id { get; }
        string Title { get; }
        string? Body { get; }
        DateTime PostedOn { get; }
        string? Picture { get; }
        Status Status { get; }
        long AdminId { get; }
        
        INoticeUser Author { get; }
        GuidType Guid { get; }
        ICollection<ICourse> Courses { get; }
        void Deactivate();
        void AddCourse(ICourse course);
    }
}
