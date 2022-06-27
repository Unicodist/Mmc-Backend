using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.ViewModel.Notice;

public class NoticeCreateViewModel
{
    [DisplayName("Notice Title")]
    [Required(ErrorMessage = "Please write a title")]
    public string Title { get; set; }
    [DisplayName("Notice Body")]
    [MinLength(10,ErrorMessage = "Notice body cannot be less than 10 characters")]
    public string? Body { get; set; }
    public IFormFile? Image { get; set; }
    [DisplayName("Choose Importance")]
    public long SeverityId { get; set; }
    [DisplayName("Related Courses")]
    public ICollection<string>? CourseGuids { get; set; }
    public IEnumerable<string>? SemesterGuids { get; set; }
}
