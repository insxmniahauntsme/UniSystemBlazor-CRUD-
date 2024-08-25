using UniSystem.Core.Entities;

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetStudentsByPropertyUseCase
    {
        Task<IEnumerable<Student>> ExecuteAsync(string property);
    }
}
