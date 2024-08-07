using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class AddGroupUseCase : IAddGroupUseCase
    {
        private IGroupRepository _groupRepository;

        public AddGroupUseCase(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task ExecuteAsync(Group group)
        {
            await _groupRepository.AddGroupAsync(group);
        }
    }
}
