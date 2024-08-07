using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(Student student);
        Task<IEnumerable<Student>> GetStudentsAsync();
    }
}
