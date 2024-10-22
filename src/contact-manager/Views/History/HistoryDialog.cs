﻿using contact_manager.Models.Data.History;
using contact_manager.Presenters.History;
using contact_manager.Views.History;

namespace contact_manager.Views
{
    public partial class HistoryDialog : Form, IHistoryDialog
    {
        private HistoryPresenter? _presenter;
        public HistoryDialog()
        {
            this.InitializeComponent();
        }

        public void SetPresenter(HistoryPresenter historyPresenter)
        {
            this._presenter = historyPresenter;
        }

        public void SetHistoryList(List<HistoryEntry> historyEntries)
        {
            var historyEntry = historyEntries.FirstOrDefault();

            this.LblTitel.Text = GetTitleText(historyEntry);

            foreach (var entry in historyEntries)
            {
                this.FlowLayoutPnlHistory.Controls.Add(this.CreateLabel(entry));
                this.FlowLayoutPnlHistory.Controls.Add(this.CreateNewListView(entry));
            }
        }

        private ListView CreateNewListView(HistoryEntry historyEntry)
        {
            var listView = new ListView
            {
                View = View.Details,
                GridLines = true,
                Width = this.FlowLayoutPnlHistory.Width - 20,
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

            SetListViewHeight(listView);

            return listView;
        }

        private Label CreateLabel(HistoryEntry historyEntry)
        {
            var mutationDate = historyEntry.TimeStamp.ToString("ddd dd.MM.yyyy HH:mm");
            var label = new Label
            {
                Text = $"Änderungsdatum: {mutationDate}\r\n" +
                $"Mutiert durch: {this._presenter?.GetUser(historyEntry.UserId)?.DisplayName}",
                AutoSize = true,
                Font = new Font(DefaultFont, FontStyle.Regular),
                Margin = new Padding() { Bottom = 10 }
            };
            return label;
        }

        private static ListViewItem CreateListViewItem(Difference difference)
        {
            var listViewItem = new ListViewItem(difference.PropertyName);
            listViewItem.UseItemStyleForSubItems = false;
            listViewItem.SubItems.Add(
                Convert.ToString(difference.ValueOld),
                DefaultForeColor, Color.White,
                new Font(DefaultFont, FontStyle.Strikeout)
                );
            listViewItem.SubItems.Add("--->");
            listViewItem.SubItems.Add(Convert.ToString(difference.ValueNew));
            return listViewItem;
        }

        private static string GetTitleText(HistoryEntry? historyEntry)
        {
            if (historyEntry != null)
            {

                return $"Änderungshistorie {historyEntry.EntityType.GetDisplayName()} Nr: {(historyEntry.EntityId).ToString().PadLeft(5, '0')}";
            }

            return "";
        }

        private static void SetListViewHeight(ListView listView)
        {
            var listViewItemsCount = listView.Items.Count;

            if (listViewItemsCount > 0)
            {
                var subItemHeight = listView.GetItemRect(0).Height;
                listView.Height = (subItemHeight * listViewItemsCount) + 45;
            }
        }
    }
}
