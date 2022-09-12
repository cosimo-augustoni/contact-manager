using contact_manager.Models.Data.History;
using contact_manager.Presenters.History;

namespace contact_manager.Views.History
{
    public interface IHistoryDialog
    {
        public void SetPresenter(HistoryPresenter historyPresenter);
        void SetHistoryList(List<HistoryEntry> historyEntries);
    }
}
