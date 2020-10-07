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

namespace ChuckNorrisJokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceLayer Sl;
        public MainWindow()
        {
            InitializeComponent();
            Sl = new ServiceLayer();
        }

        private void Btn_FetchJoke_Click(object sender, RoutedEventArgs e)
        {
            var joke = Sl.GetJoke<ChuckNorrisJoke>();
            TxtBlk_JokeHolder.Text = joke.GetJoke();
            Uri resourceUri = new Uri(joke.ImgUrl(), UriKind.Absolute);
            Img.Source = new BitmapImage(resourceUri);
        }

        private void Btn_CatFact_Click(object sender, RoutedEventArgs e)
        {
            var joke = Sl.GetJoke<CatFacts>();
            TxtBlk_JokeHolder.Text = joke.GetJoke();
        }

        private void Btn_GetRandomCat_Click(object sender, RoutedEventArgs e)
        {
            var cat = Sl.GetJoke<RandomCat>();
            Uri resourceUri = new Uri(cat.ImgUrl(), UriKind.Absolute);
            Img.Source = new BitmapImage(resourceUri);
        }

    }
}
