using MauiCollectionView.MVVM.Views;

namespace MauiCollectionView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAvancar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProdutoView());
        }
    }
}