using UniSystem.Core.Entities;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public interface IAddGroupUseCase
    {
        Task ExecuteAsync(Group group);
    }
}