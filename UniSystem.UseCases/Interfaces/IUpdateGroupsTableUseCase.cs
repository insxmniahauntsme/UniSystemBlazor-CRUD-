using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IUpdateGroupsTableUseCase
    {
        Task ExecuteAsync(Group group);
    }
}
