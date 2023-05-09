using System.Linq;
using Microsoft.EntityFrameworkCore;
using EF_Core.Domain.Entities;
using EF_Core.Domain.Repositories.Abstract;

namespace EF_Core.Domain.Repositories.EntityFramework
{
    public class EFAnalysisRepository : IAnalysisRepository
    {
        private readonly AppDbContext context;

        public EFAnalysisRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Analys> GetAnalysis()
        {
            return context.Analysis;
        }

        public Analys GetAnalysById(int id)
        {
            return context.Analysis.FirstOrDefault(x => x.an_id == id);
        }

        public void SaveAnalys(Analys entity)
        {
            if (entity.an_id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeleteAnalys(int id)
        {
            context.Analysis.Remove(new Analys() { an_id = id });
            context.SaveChanges();
        }
    }
}
