using contact_manager.Models.Data;
using contact_manager.Models.Data.History;

namespace contact_manager.Models.Domain.History
{
    internal class HistoryService : IHistoryService
    {
        private readonly IRepository<HistoryEntry> _repository;
        public HistoryService(IRepository<HistoryEntry> repository)
        {
            this._repository = repository;
        }

        public List<HistoryEntry> Get(long entityId, EntityType personType)
        {
            return this._repository.GetAll()
                .Where(e => e.EntityId == entityId && e.EntityType == personType)
                .OrderByDescending(f => f.TimeStamp)
                .ToList();
        }
    }
}
