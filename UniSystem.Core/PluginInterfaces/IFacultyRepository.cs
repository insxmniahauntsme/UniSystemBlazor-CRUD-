using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IFacultyRepository
    {
        Task<IEnumerable<Faculty>> GetFacultiesAsync();
    }
}
