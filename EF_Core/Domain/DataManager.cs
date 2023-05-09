using EF_Core.Domain.Repositories.Abstract;

namespace EF_Core.Domain
{
    public class DataManager
    {
        public IGroupsRepository Groups { get; set; }
        public IAnalysisRepository Analysis { get; set; }
        public IOrdersRepository Orders { get; set; }

        public DataManager(IGroupsRepository groupsRepository, IAnalysisRepository analysisRepository, IOrdersRepository ordersRepository)
        {
            Groups = groupsRepository;
            Analysis = analysisRepository;
            Orders = ordersRepository;
        }
    }
}
