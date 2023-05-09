using System.Linq;
using Microsoft.EntityFrameworkCore;
using EF_Core.Domain.Entities;
using EF_Core.Domain.Repositories.Abstract;

namespace EF_Core.Domain.Repositories.EntityFramework
{
    public class EFGroupsRepository : IGroupsRepository
    {
        private readonly AppDbContext context;

        public EFGroupsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Group> GetGroups()
        {
            return context.Groups;
        }

        public Group GetGroupById(int id)
        {
            return context.Groups.FirstOrDefault(x => x.gr_id == id);
        }

        public void SaveGroup(Group entity)
        {
            if (entity.gr_id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeleteGroup(int id)
        {
            context.Groups.Remove(new Group() { gr_id = id });
            context.SaveChanges();
        }
    }
}
