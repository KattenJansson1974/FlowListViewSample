using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FlowListViewSample
{
    public class MainPageModel : BindableObject
    {
        private MainPage mainPage;

        public MainPageModel(MainPage mainPage)
        {
            this.mainPage = mainPage;
            AddItems();
        }

        private void AddItems()
        {
            for (int i = 0; i < 20; i++)
                Items.Add(string.Format("List Item at {0}", i));
        }

        private ObservableCollection<string> _items = new ObservableCollection<string>();
        public ObservableCollection<string> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    mainPage.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }
    }
}
