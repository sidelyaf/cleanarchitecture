using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using MediatR;

namespace CleanArch.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRespository _courseRepository;
        public CourseCommandHandler(ICourseRespository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course() { Name = request.Name, Desctiption = request.Desctiption, ImageUrl = request.ImageUrl };
            _courseRepository.Add(course);
            return Task.FromResult(true);
        }
    }
}
