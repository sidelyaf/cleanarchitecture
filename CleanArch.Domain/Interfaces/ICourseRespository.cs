using CleanArch.Domain.Models;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRespository
    {
        IQueryable<Course> GetCourses();
        void Add(Course course);
        void Update(Course course);
    }
}
