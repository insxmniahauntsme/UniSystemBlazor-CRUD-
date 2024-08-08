using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetFacultyByIdUseCase
    {
        Task<Faculty> ExecuteAsync(int id);
    }
}