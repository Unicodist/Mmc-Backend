using Mmc.Core.Enum;

namespace Mmc.Core.Dto;

public class StudentEnrollCreateDto
{
    public long userId { get; set; }
    public string CourseGuid { get; set; }
    public Semester Semester { get; set; }
}
