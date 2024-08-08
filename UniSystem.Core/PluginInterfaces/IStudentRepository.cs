using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(Student student);
        Task EditStudentAsync(Student student);
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<Student> GetStudentByNameAsync(string name);
    }
}
