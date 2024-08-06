using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
    }
}
