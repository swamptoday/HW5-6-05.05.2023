using System.Linq;
using EF_Core.Domain.Entities;


namespace EF_Core.Domain.Repositories.Abstract
{
    public interface IGroupsRepository
    {
        public IQueryable<Group> GetGroups();

        public Group GetGroupById(int id);

        public void SaveGroup(Group entity);

        public void DeleteGroup(int id);
    }

}
