using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class EditFacultyUseCase : IEditFacultyUseCase
    {
        private readonly IFacultyRepository _facultyRepository;

        public EditFacultyUseCase(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        public async Task ExecuteAsync(Faculty faculty)
        {
            await _facultyRepository.EditFacultyAsync(faculty);
        }
    }
}
