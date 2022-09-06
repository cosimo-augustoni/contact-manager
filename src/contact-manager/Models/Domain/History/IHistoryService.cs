using contact_manager.Models.Data;
using contact_manager.Models.Data.History;

namespace contact_manager.Models.Domain.History
{
    public interface IHistoryService
    {
        void Add<T>(T personNew, T? personOld = null) where T : Person;
        List<HistoryEntry> Get(long personId, PersonType personType);
    }
}
