using UniSystem.Core.Entities;

namespace UniSystem.Core.PluginInterfaces
{
    public interface IGroupRepository
    {
        Task AddGroupAsync(Group group);
        Task DeleteGroupAsync(Group group);
        Task EditGroupAsync(Group group);
        Task<IEnumerable<Group>> GetGroupsAsync();
        Task<IEnumerable<Group>> GetGroupsByPropertyAsync(string name);
        Task<Group> GetGroupByIdAsync(int Id);
        Task UpdateGroupsTable(Group group);
    }
}
