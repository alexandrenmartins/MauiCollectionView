using MauiCollectionView.MVVM.ViewModels;

namespace MauiCollectionView.MVVM.Views;

public partial class ProdutoView : ContentPage
{
    public ProdutoViewModel ProdutoViewModel { get; }

    public ProdutoView()
    {
        InitializeComponent();
        ProdutoViewModel = new ProdutoViewModel();
        BindingContext = ProdutoViewModel;
    }

    private void btnAvancar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProdutosSelecionadosView(ProdutoViewModel));
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var anterior = e.PreviousSelection;
        var atual = e.CurrentSelection;
        var obj = (sender as CollectionView).SelectedItem;
    }
}