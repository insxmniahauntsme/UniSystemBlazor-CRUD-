using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetGroupsUseCase
    {
        Task<IEnumerable<Group>> ExecuteAsync();
    }
}
