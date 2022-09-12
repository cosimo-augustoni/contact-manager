using contact_manager.Models.Data.History;

namespace contact_manager.Models.Domain.History
{
    public interface IHistoryService
    {
        List<HistoryEntry> Get(long entityId, EntityType personType);
    }
}
