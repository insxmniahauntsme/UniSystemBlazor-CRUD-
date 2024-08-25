using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetGroupsByPropertyUseCase
    {
        Task<IEnumerable<Group>> ExecuteAsync(string property);
    }
}
