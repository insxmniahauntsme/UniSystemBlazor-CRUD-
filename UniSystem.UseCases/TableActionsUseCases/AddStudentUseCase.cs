using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class AddStudentUseCase : IAddStudentUseCase
    {
        private IStudentRepository _studentRepository;

        public AddStudentUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task ExecuteAsync(Student student)
        {
            await _studentRepository.AddStudentAsync(student);
        }
    }
}
