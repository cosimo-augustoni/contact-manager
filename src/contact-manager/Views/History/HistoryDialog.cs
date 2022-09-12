using contact_manager.Models.Data.History;
using contact_manager.Presenters.History;
using contact_manager.Views.History;

namespace contact_manager.Views
{
    public partial class HistoryDialog : Form, IHistoryDialog
    {
        private HistoryPresenter? _presenter;
        public HistoryDialog()
        {
            InitializeComponent();
        }

        public void SetPresenter(HistoryPresenter historyPresenter)
        {
            this._presenter = historyPresenter;
        }

        public void SetHistoryList(List<HistoryEntry> historyEntries)
        {
            var historyEntry = historyEntries.FirstOrDefault();

            this.LblTitel.Text = this.GetTitleText(historyEntry);

            foreach (var entry in historyEntries)
            {
                this.FlowLayoutPnlHistory.Controls.Add(CreateLabel(entry));
                this.FlowLayoutPnlHistory.Controls.Add(CreateNewListView(entry));
            }
        }

        private ListView CreateNewListView(HistoryEntry historyEntry)
        {
            var listView = new ListView
            {
                View = View.Details,
                GridLines = true,
                Width = this.FlowLayoutPnlHistory.Width - 40,
                Height = (int)(this.FlowLayoutPnlHistory.Height / 2),
                Margin = new Padding
                {
                    Bottom = 25
                },
            };

            listView.Columns.Add("Property", -2);
            listView.Columns.Add("Alter Wert", -2);
            listView.Columns.Add(" ", -2);
            listView.Columns.Add("Neuer Wert", -2);

            foreach (var difference in historyEntry.Diffs)
            {
                listView.Items.Add(CreateListViewItem(difference));
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            return listView;
        }

        private Label CreateLabel(HistoryEntry historyEntry)
        {
            var label = new Label
            {
                Text = $"Datum der Änderung: {historyEntry.TimeStamp.ToString("F")}",
                AutoSize = true,
                Font = new Font(Label.DefaultFont, FontStyle.Bold),
                Margin = new Padding() { Bottom = 10 }
            };
            return label;
        }

        private ListViewItem CreateListViewItem(Difference difference)
        {
            var listViewItem = new ListViewItem(difference.PropertyName);
            listViewItem.UseItemStyleForSubItems = false;
            listViewItem.SubItems.Add(
                Convert.ToString(difference.ValueOld),
                ListView.DefaultForeColor, Color.White,
                new Font(ListView.DefaultFont, FontStyle.Strikeout)
                );
            listViewItem.SubItems.Add("--->");
            listViewItem.SubItems.Add(Convert.ToString(difference.ValueNew));
            return listViewItem;
        }

        private string GetTitleText(HistoryEntry? historyEntry)
        {
            if (historyEntry != null)
            {

                return $"Änderungshistorie {historyEntry.EntityType.GetDisplayName()} Nr: {(historyEntry.EntityId).ToString().PadLeft(5, '0')}";
            }

            return "";
        }
    }
}
