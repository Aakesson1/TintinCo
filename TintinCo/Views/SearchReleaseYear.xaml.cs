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
    /// Interaction logic for SearchReleaseYear.xaml
    /// </summary>
    public partial class SearchReleaseYear : Page
    {
        MainViewModel ComicVM;
        Frame Frame;
        public SearchReleaseYear()
        {
            InitializeComponent();
        }
        public SearchReleaseYear(Frame frame, MainViewModel comicVM)
        {
            InitializeComponent();
            this.Frame = frame;
            this.ComicVM = comicVM;
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            gridTable.DataContext = ComicVM.searchRepoReleaseYear(ReleaseYearMin.Text, ReleaseYearMax.Text);
        }

        private void backbtn_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new HomePage(Frame, ComicVM));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(new AddComic(this.Frame, this.ComicVM));
        }
    }
}
