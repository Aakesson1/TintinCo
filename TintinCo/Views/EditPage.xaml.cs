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
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        MainViewModel ComicVM;
        Frame Frame;
        private Comic comic;
        public EditPage()
        {
            InitializeComponent();
        }
        public EditPage(Frame frame, MainViewModel comicVM, Comic comic)
        {
            InitializeComponent();
            this.Frame = frame;
            this.ComicVM = comicVM;

            this.Titletb.Text = comic.Title;
            this.Amounttb.Text = comic.Amount.ToString();
            this.Requesttb.Text = comic.Request;
            this.Pricetb.Text = comic.Price.ToString();
            this.QualityColortb.Text = comic.QualityColor;
            if (comic.Description != null)
            {
                this.Descriptiontb.Text = comic.Description.ToString();
            }
            this.ReleaseYeartb.Text = comic.ReleaseYear.ToString();
            this.comic = comic;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Comic tempComic = new Comic();
            tempComic.ID = comic.ID;
            tempComic.Title = Titletb.Text;
            tempComic.Request = Requesttb.Text;
            tempComic.Description = Descriptiontb.Text;
            tempComic.Price= int.Parse(Pricetb.Text.ToString());
            tempComic.QualityColor = QualityColortb.Text;
            tempComic.Amount = int.Parse(Amounttb.Text.ToString());
            tempComic.ReleaseYear = int.Parse(ReleaseYeartb.Text.ToString());
            ComicVM.UpdateComicInRepo(tempComic);
            MessageBox.Show("Comic updated", "Updated");
            
        }

        private void Backbtn_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new SearchReleaseYear(Frame, ComicVM));
        }
    }
}
