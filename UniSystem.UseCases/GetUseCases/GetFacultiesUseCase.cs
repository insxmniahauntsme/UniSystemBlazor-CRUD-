using Microsoft.IdentityModel.Tokens;
using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetFacultiesUseCase : IGetFacultiesUseCase
    {
        private readonly IFacultyRepository _facultyRepository;

        public GetFacultiesUseCase(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }
        public async Task<IEnumerable<Faculty>> ExecuteAsync()
        {
            return await _facultyRepository.GetFacultiesAsync();
        }

    }
}

