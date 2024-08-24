using UniSystem.UseCases.Interfaces;
using UniSystem.Core.Entities;

namespace UniSystem.UseCases.GroupsAverageUseCases
{
    public class CalculateGroupAverageUseCase : ICalculateGroupAverageUseCase
    {
        private IGetStudentsUseCase _getStudentsUseCase;

        public CalculateGroupAverageUseCase(IGetStudentsUseCase getStudentsUseCase)
        {
            _getStudentsUseCase = getStudentsUseCase;
        }

        public async Task<double> CalculateGroupAverage(string groupName)
        {
            IEnumerable<Student> students = await _getStudentsUseCase.ExecuteAsync();

            if (students == null || !students.Any(s => s.GroupName == groupName))
                return 0;

            return Math.Round(students
                .Where(s => s.GroupName == groupName)
                .Select(s => s.AverageScore)
                .DefaultIfEmpty(0)
                .Average(), 2);

        }
    }
}
