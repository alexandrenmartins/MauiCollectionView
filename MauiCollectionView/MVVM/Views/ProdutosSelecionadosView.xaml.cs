using MauiCollectionView.MVVM.ViewModels;

namespace MauiCollectionView.MVVM.Views;

public partial class ProdutosSelecionadosView : ContentPage
{
    public ProdutoViewModel ProdutoViewModel { get; }

    public ProdutosSelecionadosView(ProdutoViewModel vmCompartilhado)
    {
        InitializeComponent();
        ProdutoViewModel = vmCompartilhado;
        BindingContext = ProdutoViewModel;
    }
}