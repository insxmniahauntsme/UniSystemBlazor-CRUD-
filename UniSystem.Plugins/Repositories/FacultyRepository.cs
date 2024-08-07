using UniSystem.Core.PluginInterfaces;
using UniSystem.Core.Entities;

namespace UniSystem.Plugins.Repositories
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly DataContext _context;

        public FacultyRepository(DataContext context)
        {

            _context = context;
        }

        public Task AddFacultyAsync(Faculty faculty)
        {
            if (_context.Faculties.ToList().Any(f => f.FacultyName.Equals(faculty.FacultyName, StringComparison.OrdinalIgnoreCase)) || string.IsNullOrWhiteSpace(faculty.FacultyName))
                return Task.CompletedTask;
            
            _context.Faculties.Add(faculty);
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public Task DeleteFacultyAsync(Faculty faculty)
        {
            if (_context.Faculties.ToList().Any(f => f.FacultyName.Equals(faculty.FacultyName, StringComparison.OrdinalIgnoreCase)))
            {
                _context.Faculties.Remove(faculty);
                _context.SaveChanges();
            }
            
            return Task.CompletedTask;                      

        }

        public async Task<IEnumerable<Faculty>> GetFacultiesAsync()
        {
            return await Task.FromResult(_context.Faculties);
        }

    }
}
