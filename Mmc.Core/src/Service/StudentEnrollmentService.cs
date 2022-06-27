using Mmc.Core.Dto;
using Mmc.Core.Entity;
using Mmc.Core.Entity.Interface;
using Mmc.Core.Exception;
using Mmc.Core.Repository;
using Mmc.Core.Service.Interface;
using Mmc.Notice.Repository;
using Mmc.User.Repository;

namespace Mmc.Core.Service;

public class StudentEnrollmentService : IStudentEnrollmentService
{
    private readonly IUserUserRepository _userRepository;
    private readonly ICourseRepository _courseRepository;
    private readonly IStudentEnrollmentRepository _enrollmentRepository;

    public StudentEnrollmentService(IUserUserRepository userRepository, ICourseRepository courseRepository, IStudentEnrollmentRepository enrollmentRepository)
    {
        _userRepository = userRepository;
        _courseRepository = courseRepository;
        _enrollmentRepository = enrollmentRepository;
    }

    public async Task<IStudentEnrollment> Create(StudentEnrollCreateDto dto)
    {
        var user = await _userRepository.GetUserUserById(dto.userId);
        var course = await _courseRepository.GetByGuidAsync(dto.CourseGuid)??throw new CourseNotFoundException();
        var enrollment = new StudentEnrollment(user,course,dto.Semester);
        return await _enrollmentRepository.InsertAsync(enrollment);
    }

    public async Task Update(StudentEnrollUpdateDto dto)
    {
        var enrollment = await _enrollmentRepository.GetByGuidAsync(dto.EnrollmentGuid)??throw new StudentEnrollmentNotFoundException();
        var course = await _courseRepository.GetByGuidAsync(dto.CourseGuid) ?? throw new CourseNotFoundException();
        enrollment.Update(dto.Semester, course);
    }
}
