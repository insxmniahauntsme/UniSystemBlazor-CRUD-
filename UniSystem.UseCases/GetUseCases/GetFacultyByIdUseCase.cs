using Microsoft.IdentityModel.Tokens;
using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetFacultyByIdUseCase : IGetFacultyByIdUseCase
    {
        private readonly IFacultyRepository _facultyRepository;

        public GetFacultyByIdUseCase(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }
        public async Task<Faculty> ExecuteAsync(int Id)
        {
            return await _facultyRepository.GetFacultyByIdAsync(Id);
        }

    }
}

