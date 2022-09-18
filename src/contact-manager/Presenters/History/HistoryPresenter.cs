using contact_manager.Models.Data.History;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.History;
using contact_manager.Views.History;

namespace contact_manager.Presenters.History
{

    public class HistoryPresenter
    {
        private readonly IHistoryDialog _historyDialog;
        private readonly IHistoryService _historyService;
        private readonly IUserService _userService;

        public HistoryPresenter(IHistoryDialog historyDialog, IHistoryService historyService, IUserService userService)
        {
            this._historyService = historyService;
            this._historyDialog = historyDialog;
            this._userService = userService;
            this._historyDialog.SetPresenter(this);
        }

        public void LoadPerson(long id, EntityType personType)
        {
            var historyEntries = _historyService.Get(id, personType);
            this._historyDialog.SetHistoryList(historyEntries);
        }

        public User? GetUser(int userId)
        {
            return this._userService.Get(userId);
        }
    }
}
