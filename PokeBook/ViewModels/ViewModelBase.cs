using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBook.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

    }

    protected void OnPropetyChanged([CallerMemberName] string proptertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropetyChangedEventArgs(propertyName));

    }
}
