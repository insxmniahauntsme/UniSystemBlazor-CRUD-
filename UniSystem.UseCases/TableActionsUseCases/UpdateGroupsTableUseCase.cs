using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class UpdateGroupsTableUseCase : IUpdateGroupsTableUseCase
    {
        private IGroupRepository _groupRepository;

        public UpdateGroupsTableUseCase(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task ExecuteAsync(Group group)
        {
            await _groupRepository.UpdateGroupsTable(group);
        }
    }
}
