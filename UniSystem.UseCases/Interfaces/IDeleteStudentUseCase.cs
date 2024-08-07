using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IDeleteStudentUseCase
    {
        Task ExecuteAsync(Student student);
    }
}