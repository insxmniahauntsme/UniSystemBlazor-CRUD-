using System.Linq;
using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetFacultiesByPropertyUseCase : IGetFacultiesByPropertyUseCase
    {
        private IFacultyRepository _facultyRepository;

        public GetFacultiesByPropertyUseCase(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        public async Task<IEnumerable<Faculty>> ExecuteAsync(string property)
        {
            return await _facultyRepository.GetFacultiesByPropertyAsync(property);
        }
    }
}
