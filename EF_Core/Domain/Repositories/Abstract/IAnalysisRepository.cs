using System.Linq;
using EF_Core.Domain.Entities;

namespace EF_Core.Domain.Repositories.Abstract
{
    public interface IAnalysisRepository
    {
        public IQueryable<Analys> GetAnalysis();

        public Analys GetAnalysById(int id);

        public void SaveAnalys(Analys entity);

        public void DeleteAnalys (int id);
    }
}
