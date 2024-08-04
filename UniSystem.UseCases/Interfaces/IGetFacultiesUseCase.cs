using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetFacultiesUseCase
    {
        Task<IEnumerable<Faculty>> ExecuteAsync();
    }
}
