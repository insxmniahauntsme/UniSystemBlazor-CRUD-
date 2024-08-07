using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class DeleteGroupUseCase : IDeleteGroupUseCase
    {
        private IGroupRepository _groupRepository;

        public DeleteGroupUseCase(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task ExecuteAsync(Group group) 
        {
            await _groupRepository.DeleteGroupAsync(group);
        }
    }
}
