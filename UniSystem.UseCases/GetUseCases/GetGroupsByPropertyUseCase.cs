using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetGroupsByPropertyUseCase : IGetGroupsByPropertyUseCase
    {
        private IGroupRepository _groupRepository;

        public GetGroupsByPropertyUseCase(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<IEnumerable<Group>> ExecuteAsync(string property)
        {
            return await _groupRepository.GetGroupsByPropertyAsync(property);
        }
    }
}
