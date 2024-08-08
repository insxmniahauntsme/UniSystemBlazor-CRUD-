using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetStudentByNameUseCase
    {
        Task<Student> ExecuteAsync(string name);
    }
}