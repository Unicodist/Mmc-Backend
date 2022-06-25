using System.ComponentModel;

namespace Mechi.Backend.ViewModel.Notice;

public class NoticeCreateViewModel
{
    [DisplayName("Notice Title")]
    public string Title { get; set; }
    [DisplayName("Notice Body")]
    public string? Body { get; set; }
    public IFormFile Image { get; set; }
    [DisplayName("Choose Importance")]
    public long SeverityId { get; set; }
    [DisplayName("Related Courses")]
    public IEnumerable<long>? CourseId { get; set; }
    public IEnumerable<long> SemesterId { get; set; }
}
