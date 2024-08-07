using UniSystem.Core.PluginInterfaces;
using UniSystem.Core.Entities;

namespace UniSystem.Plugins.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly DataContext _context;

        public GroupRepository(DataContext context)
        {

            _context = context;
        }

        public Task AddGroupAsync(Group group)
        {
            if (_context.Groups.ToList().Any(g => g.GroupName.Equals(group.GroupName, StringComparison.OrdinalIgnoreCase)) || string.IsNullOrWhiteSpace(group.GroupName))
                return Task.CompletedTask;

            _context.Groups.Add(group);
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public Task DeleteGroupAsync(Group group)
        {
            if (_context.Groups.ToList().Any(g => g.GroupName.Equals(group.GroupName, StringComparison.OrdinalIgnoreCase)))
            {
                _context.Groups.Remove(group);
                _context.SaveChanges();
            }

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Group>> GetGroupsAsync()
        {
            return await Task.FromResult(_context.Groups);
        }
    }
}
