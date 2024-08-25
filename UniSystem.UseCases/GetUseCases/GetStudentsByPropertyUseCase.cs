using System.Linq;
using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetStudentsByPropertyUseCase : IGetStudentsByPropertyUseCase
    {
        private IStudentRepository _studentRepository;

        public GetStudentsByPropertyUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>> ExecuteAsync(string property)
        {
            return await _studentRepository.GetStudentsByPropertyAsync(property);
        }
    }
}
