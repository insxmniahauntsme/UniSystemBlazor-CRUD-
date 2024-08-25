using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IFacultyRepository
    {
        Task AddFacultyAsync(Faculty faculty);
        Task DeleteFacultyAsync(Faculty faculty);
        Task EditFacultyAsync(Faculty faculty);
        Task<IEnumerable<Faculty>> GetFacultiesAsync();
        Task<IEnumerable<Faculty>> GetFacultiesByPropertyAsync(string name);
        Task<Faculty> GetFacultyByIdAsync(int id);
    }
}
