using UniSystem.Core.PluginInterfaces;
using UniSystem.Core.Entities;

namespace UniSystem.Plugins.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IEnumerable<Student> students;

        public StudentRepository(DataContext context)
        {

            students = context.Students;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await Task.FromResult(students);
        }
    }
}
