using Microsoft.IdentityModel.Tokens;
using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TablesUseCases
{
    public class GetStudentsUseCase : IGetStudentsUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentsUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<IEnumerable<Student>> ExecuteAsync()
        {
            return await _studentRepository.GetStudentsAsync();
        }

    }
}

