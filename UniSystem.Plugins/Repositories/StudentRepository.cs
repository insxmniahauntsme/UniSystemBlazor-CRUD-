using UniSystem.Core.PluginInterfaces;
using UniSystem.Core.Entities;

namespace UniSystem.Plugins.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private DataContext _context;

        public StudentRepository(DataContext context)
        {

            _context = context;
        }

        public Task AddStudentAsync(Student student)
        {
            if (_context.Students.ToList().Any(s => s.Name.Equals(student.Name, StringComparison.OrdinalIgnoreCase)) || string.IsNullOrWhiteSpace(student.Name))
                return Task.CompletedTask;

            _context.Students.Add(student);
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public Task DeleteStudentAsync(Student student)
        {
            if (_context.Students.ToList().Any(s => s.Name.Equals(student.Name, StringComparison.OrdinalIgnoreCase)))
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

            return Task.CompletedTask;
        }

        public Task EditStudentAsync(Student student)
        {
            if (_context.Students.ToList().Any(s => s.Name.Equals(student.Name, StringComparison.OrdinalIgnoreCase)))
            {
                _context.Students.Update(student);
                _context.SaveChanges();
            }

            return Task.CompletedTask;
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await Task.FromResult(_context.Students.First(s => s.StudentId == id));
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await Task.FromResult(_context.Students);
        }
    }
}
