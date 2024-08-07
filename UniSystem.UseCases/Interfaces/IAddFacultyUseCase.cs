using UniSystem.Core.Entities;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public interface IAddFacultyUseCase
    {
        Task ExecuteAsync(Faculty faculty);
    }
}