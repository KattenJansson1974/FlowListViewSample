using Xamarin.Forms;

namespace FlowListViewSample
{
    public partial class MainPage : ContentPage
    {
        MainPageModel pageModel;
        public MainPage()
        {
            InitializeComponent();
            pageModel = new MainPageModel(this);
            BindingContext = pageModel;
        }
    }
}