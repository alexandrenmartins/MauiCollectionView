using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView.MVVM.Models;

public class Produto : INotifyPropertyChanged
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Imagem { get; set; }
    public int Estoque { get; set; }

    private bool _emOferta;

    public bool EmOferta
    {
        get => _emOferta;
        set
        {
            if (_emOferta != value)
            {
                _emOferta = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}