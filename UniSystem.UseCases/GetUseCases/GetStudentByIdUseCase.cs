using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetStudentByIdUseCase : IGetStudentByIdUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> ExecuteAsync(int id)
        {
            return await _studentRepository.GetStudentByIdAsync(id);
        }

    }
}

