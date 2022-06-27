using Mmc.Core.Dto;
using Mmc.Core.Entity.Interface;

namespace Mmc.Core.Service.Interface;

public interface IStudentEnrollmentService
{
    public Task<IStudentEnrollment> Create(StudentEnrollCreateDto dto);
    public Task Update(StudentEnrollUpdateDto dto);
}
