using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IEditGroupUseCase
    {
        Task ExecuteAsync(Group group);
    }
}