using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokeBook.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            this.DataContext = new ViewModels.HomePageViewModel();
        }

        public ViewModels.HomePageViewModel ViewModel => DataContext as ViewModels.HomePageViewModel;

        private string[] options = new string[] { "Eevee", "Charmander", "Ivysaur", "Pikachu" };
        private Random random = new Random();

        private void IncrementClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Pokemon.Add(options[random.Next(0, options.Length)]);
        }
    }
}
