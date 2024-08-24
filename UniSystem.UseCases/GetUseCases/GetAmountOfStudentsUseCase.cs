
using UniSystem.Core.Entities;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetAmountOfStudentsUseCase : IGetAmountOfStudentsUseCase
    {
        private IGetStudentsUseCase _getStudentsUseCase;

        public GetAmountOfStudentsUseCase(IGetStudentsUseCase getStudentsUseCase) 
        {
            _getStudentsUseCase = getStudentsUseCase;
        }

        public async Task<int> ExecuteAsync(string groupName)
        {
            IEnumerable<Student> students = await _getStudentsUseCase.ExecuteAsync();

            if (students == null || !students.Any(s => s.GroupName == groupName))
                return 0;

            return students.Where(s => s.GroupName == groupName).Count();
        }
    }
}
