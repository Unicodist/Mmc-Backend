using System.ComponentModel;

namespace Mechi.Backend.ViewModel.Notice;

public class NoticeCreateViewModel
{
    public string Title { get; set; }
    public string? Body { get; set; }
    public IFormFile Image { get; set; }
    public long SeverityId { get; set; }
    [DisplayName("Related Faculties")]
    public IEnumerable<long>? FacultyId { get; set; }
    [DisplayName("Related Courses")]
    public IEnumerable<long>? CourseId { get; set; }
    public IEnumerable<long> SemesterId { get; set; }
}
