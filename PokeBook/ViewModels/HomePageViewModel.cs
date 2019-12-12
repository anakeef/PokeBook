using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBook.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private int _counter;
        public ObservableCollection<string> Pokemon { get; } = new ObservableCollection<string>();

        public int Counter
        {
            get { return _counter; }
            set
            {
                if (_counter != value)
                {
                    _counter = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
