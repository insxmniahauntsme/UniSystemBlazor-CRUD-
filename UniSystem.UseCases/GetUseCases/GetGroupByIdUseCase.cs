using Microsoft.IdentityModel.Tokens;
using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.GetUseCases
{
    public class GetGroupByIdUseCase : IGetGroupByIdUseCase
    {
        private readonly IGroupRepository _groupRepository;

        public GetGroupByIdUseCase(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<Group> ExecuteAsync(int Id)
        {
            return await _groupRepository.GetGroupByIdAsync(Id);
        }

    }
}

