using Microsoft.IdentityModel.Tokens;
using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TablesUseCases
{
    public class GetGroupsUseCase : IGetGroupsUseCase
    {
        private readonly IGroupRepository _groupRepository;

        public GetGroupsUseCase(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<IEnumerable<Group>> ExecuteAsync()
        {
            return await _groupRepository.GetGroupsAsync();
        }

    }
}

