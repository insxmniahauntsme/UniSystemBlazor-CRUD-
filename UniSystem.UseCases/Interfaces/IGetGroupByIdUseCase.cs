using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetGroupByIdUseCase
    {
        Task<Group> ExecuteAsync(int id);
    }
}