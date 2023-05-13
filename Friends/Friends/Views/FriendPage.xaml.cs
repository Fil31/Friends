using MVV_topolja.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVV_topolja.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendPage : ContentPage
    {
        public FriendViewModel ViewModel { get; private set; }
        public FriendPage(FriendViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            BindingContext = ViewModel;
        }
    }
}