using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IDeleteFacultyUseCase
    {
        Task ExecuteAsync(Faculty faculty);
    }
}