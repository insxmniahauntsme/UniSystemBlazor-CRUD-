using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IEditStudentUseCase
    {
        Task ExecuteAsync(Student student);
    }
}