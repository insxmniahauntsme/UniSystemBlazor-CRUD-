using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GroupsAverageUseCases
{
    public class GetGroupAverageUseCase : IGetGroupAverageUseCase
    {
        private ICalculateGroupAverageUseCase _calculateGroupAverageUseCase;

        public GetGroupAverageUseCase(ICalculateGroupAverageUseCase calculateGroupAverageUseCase)
        {
            _calculateGroupAverageUseCase = calculateGroupAverageUseCase;
        }
        public async Task<double> ExecuteAsync(string groupName)
        {
            return await _calculateGroupAverageUseCase.CalculateGroupAverage(groupName);
        }
    }
}
