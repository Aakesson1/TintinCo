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
using TintinCo_.Model;
using TintinCo_.ViewModels;

namespace TintinCo_.Views
{
    /// <summary>
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddComic : Page
    {
        MainViewModel ComicVM;
        Frame Frame;
        public AddComic()
        {
            InitializeComponent();
        }
        public AddComic(Frame frame, MainViewModel dogVM)
        {
            InitializeComponent();
            this.Frame = frame;
            this.ComicVM = dogVM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Comic comic = new Comic();
            comic.Title = Titletb.Text;
            comic.ReleaseYear = int.Parse(ReleaseYeartb.Text);
            comic.Amount = int.Parse(Amounttb.Text);
            comic.Request = Requesttb.Text;
            comic.QualityColor = QualityColortb.Text;
            comic.Price = int.Parse(Pricetb.Text);
            comic.Description = Descriptiontb.Text;
            ComicVM.AddComicToRepo(comic);
            MessageBox.Show("Comic Saved", "Saved", MessageBoxButton.OK);

        }

        private void Backbtn_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new HomePage(Frame, ComicVM));
        }
    }
}
