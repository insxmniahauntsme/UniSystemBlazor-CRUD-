using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(Student student);
        Task EditStudentAsync(Student student);
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<IEnumerable<Student>> GetStudentsByPropertyAsync(string name);
        Task<Student> GetStudentByIdAsync(int id);
    }
}
