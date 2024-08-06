using UniSystem.Core.PluginInterfaces;
using UniSystem.Core.Entities;

namespace UniSystem.Plugins.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly IEnumerable<Group> groups;

        public GroupRepository(DataContext context)
        {

            groups = context.Groups;
        }

        public async Task<IEnumerable<Group>> GetGroupsAsync()
        {
            return await Task.FromResult(groups);
        }
    }
}
