using contact_manager.Models.Data;
using contact_manager.Models.Data.History;

namespace contact_manager.Models.Domain.History
{
    public interface IHistoryService
    {
        void Add(IObjectIdentifier entityNew, IObjectIdentifier? entityOld = null);
        List<HistoryEntry> Get(long entityId, EntityType personType);
    }
}
