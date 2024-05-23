using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRespository
    {
        private UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
           return _context.Courses.AsEnumerable();
        }
    }
}
