using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IGroupRepository
    {
        Task<IEnumerable<Group>> GetGroupsAsync();
    }
}
