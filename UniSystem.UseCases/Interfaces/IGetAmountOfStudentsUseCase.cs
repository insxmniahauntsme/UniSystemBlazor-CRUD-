

namespace UniSystem.UseCases.Interfaces
{
    public interface IGetAmountOfStudentsUseCase
    {
        Task<int> ExecuteAsync(string groupName);
    }
}
