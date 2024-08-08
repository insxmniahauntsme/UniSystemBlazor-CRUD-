using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class EditStudentUseCase : IEditStudentUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public EditStudentUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task ExecuteAsync(Student student)
        {
            await _studentRepository.EditStudentAsync(student);
        }
    }
}
