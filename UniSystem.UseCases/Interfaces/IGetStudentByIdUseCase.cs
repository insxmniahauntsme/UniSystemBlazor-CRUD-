using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetStudentByIdUseCase
    {
        Task<Student> ExecuteAsync(int id);
    }
}