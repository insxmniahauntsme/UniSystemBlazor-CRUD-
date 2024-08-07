using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class AddFacultyUseCase : IAddFacultyUseCase
    {
        private IFacultyRepository _facultyRepository;

        public AddFacultyUseCase(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        public async Task ExecuteAsync(Faculty faculty)
        {
            await _facultyRepository.AddFacultyAsync(faculty);
        }
    }
}
