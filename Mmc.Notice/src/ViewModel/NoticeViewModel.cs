using Mmc.Notice.BaseType;
using Mmc.Notice.Entity.Interface;

namespace Mmc.Notice.ViewModel;

public class NoticeViewModel
{
    public string Guid { get; set; }
    public string Title { get; set; }
    public string? Body { get; set; }
    public string? Image { get; set; }
    public DateTime Date { get; set; }
    public string User { get; set; }
}