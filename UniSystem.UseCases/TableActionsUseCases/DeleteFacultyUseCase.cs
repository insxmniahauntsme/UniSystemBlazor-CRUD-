using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class DeleteFacultyUseCase : IDeleteFacultyUseCase
    {
        private IFacultyRepository _facultyRepository;

        public DeleteFacultyUseCase(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        public async Task ExecuteAsync(Faculty faculty) 
        {
            await _facultyRepository.DeleteFacultyAsync(faculty);
        }
    }
}
