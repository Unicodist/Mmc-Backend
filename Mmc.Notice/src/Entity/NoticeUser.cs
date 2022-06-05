using Mmc.Notice.Entity.Interface;

namespace Mmc.Notice.Entity;

public class NoticeUser : INoticeUser
{
    public long Id { get; set; }
    public string Name { get; set; }
}