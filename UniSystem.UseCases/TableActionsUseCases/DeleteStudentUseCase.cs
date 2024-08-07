using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class DeleteStudentUseCase : IDeleteStudentUseCase
    {
        private IStudentRepository _studentRepository;

        public DeleteStudentUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task ExecuteAsync(Student student) 
        {
            await _studentRepository.DeleteStudentAsync(student);
        }
    }
}
