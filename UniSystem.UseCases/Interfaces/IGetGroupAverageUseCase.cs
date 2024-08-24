
namespace UniSystem.UseCases.Interfaces
{
    public interface IGetGroupAverageUseCase
    {
        Task<double> ExecuteAsync(string groupName);
    }
}
