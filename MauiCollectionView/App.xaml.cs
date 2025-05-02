using MauiCollectionView.MVVM.Views;

namespace MauiCollectionView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ContatosView();
            MainPage = new CollectionWithHeaderView();
            
            //MainPage = new NavigationPage(new MainPage());
        }
    }
}