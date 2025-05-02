using MauiCollectionView.MVVM.ViewModels;

namespace MauiCollectionView.MVVM.Views;

public partial class CollectionWithHeaderView : ContentPage
{
    public ProdutoViewModel ProdutoViewModel { get; }
    public CollectionWithHeaderView()
	{
		InitializeComponent();
        ProdutoViewModel = new ProdutoViewModel();
        BindingContext = ProdutoViewModel;
    }
}