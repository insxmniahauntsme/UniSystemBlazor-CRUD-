using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IEditFacultyUseCase
    {
        Task ExecuteAsync(Faculty faculty);
    }
}