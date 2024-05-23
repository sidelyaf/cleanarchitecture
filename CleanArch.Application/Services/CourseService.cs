using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRespository _courseRepository;
        public CourseService(ICourseRespository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel() { Courses = _courseRepository.GetCourses() };
        }
    }
}
