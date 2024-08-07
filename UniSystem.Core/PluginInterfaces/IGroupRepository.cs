using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IGroupRepository
    {
        Task AddGroupAsync(Group group);
        Task DeleteGroupAsync(Group group);
        Task<IEnumerable<Group>> GetGroupsAsync();
    }
}
