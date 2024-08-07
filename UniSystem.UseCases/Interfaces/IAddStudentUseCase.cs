using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IAddStudentUseCase
    {
        Task ExecuteAsync(Student student);
    }
}