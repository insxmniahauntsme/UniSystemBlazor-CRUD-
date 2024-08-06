using UniSystem.Core.PluginInterfaces;
using UniSystem.Core.Entities;

namespace UniSystem.Plugins.Repositories
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly IEnumerable<Faculty> faculties;

        public FacultyRepository(DataContext context)
        {

            faculties = context.Faculties;
        }

        public async Task<IEnumerable<Faculty>> GetFacultiesAsync()
        {
            return await Task.FromResult(faculties);
        }
    }
}
