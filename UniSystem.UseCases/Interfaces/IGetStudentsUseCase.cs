using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetStudentsUseCase
    {
        Task<IEnumerable<Student>> ExecuteAsync();
    }
}
