using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IDeleteGroupUseCase
    {
        Task ExecuteAsync(Group group);
    }
}