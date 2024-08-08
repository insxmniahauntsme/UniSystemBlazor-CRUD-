using Microsoft.IdentityModel.Tokens;
using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetStudentByNameUseCase : IGetStudentByNameUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByNameUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> ExecuteAsync(string name)
        {
            return await _studentRepository.GetStudentByNameAsync(name);
        }

    }
}

