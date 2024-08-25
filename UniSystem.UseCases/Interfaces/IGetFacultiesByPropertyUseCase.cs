using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetFacultiesByPropertyUseCase
    {
        Task<IEnumerable<Faculty>> ExecuteAsync(string property);
    }
}
