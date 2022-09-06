using contact_manager.Models.Data.History;
using contact_manager.Models.Domain.History;
using contact_manager.Views.History;

namespace contact_manager.Presenters.History
{

    public class HistoryPresenter
    {
        private readonly IHistoryDialog _historyDialog;
        private readonly IHistoryService _historyService;

        public HistoryPresenter(IHistoryDialog historyDialog, IHistoryService historyService)
        {
            this._historyService = historyService;
            this._historyDialog = historyDialog;
            this._historyDialog.SetPresenter(this);
        }

        public void LoadPerson(long id, PersonType personType)
        {
            var historyEntries = _historyService.Get(id, personType);
            this._historyDialog.SetHistoryList(historyEntries);
        }
    }
}
