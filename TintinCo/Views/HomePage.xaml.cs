using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TintinCo_.ViewModels;

namespace TintinCo_.Views
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        Frame Frame;
        MainViewModel ComicVM;
        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(Frame frame1, MainViewModel comicVM)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.ComicVM = comicVM;
        }

        private void SearchReleaseYearbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(new SearchReleaseYear(this.Frame, this.ComicVM));
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(new AddComic(this.Frame, this.ComicVM));
        }
    }
}
