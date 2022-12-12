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
using TintinCo_.Views;

namespace TintinCo_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel ComicVM { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ComicVM = new MainViewModel();
            Frame.Navigate(new HomePage(Frame, ComicVM));
        }
        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
