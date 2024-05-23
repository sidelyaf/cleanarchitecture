using CleanArch.Domain.Models;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRespository
    {
        IEnumerable<Course> GetCourses();
    }
}
