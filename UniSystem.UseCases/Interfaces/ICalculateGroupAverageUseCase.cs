
namespace UniSystem.UseCases.Interfaces
{
    public interface ICalculateGroupAverageUseCase
    {
        Task<double> CalculateGroupAverage(string groupName);
    }
}
