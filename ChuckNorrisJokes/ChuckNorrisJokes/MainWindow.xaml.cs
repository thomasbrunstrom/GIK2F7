using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using System.Text.Json;
using Microsoft.Win32;
using System.Globalization;
using System.IO;

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

        private async void sendJson_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person()
            {
                FirstName = firstname.Text,
                LastName = lastname.Text
            };

            using (var client = new HttpClient())
            {
                using (var content = new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture)))
                {
                    var image = await File.ReadAllBytesAsync(filename.Text);
                    var shortImageName = System.IO.Path.GetFileName(filename.Text);
                    content.Add(new StreamContent(new MemoryStream(image)), "postImage", shortImageName);
                    content.Add(new StringContent("4"), "Id");
                    using (var message = await client.PostAsync("http://localhost:5000/img/", content))
                    {
                        var input = await message.Content.ReadAsStringAsync();
                        Person2 answer = JsonSerializer.Deserialize<Person2>(input);
                    }
                }
            }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Image { get; set; }
        }
        public class Person2
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string image { get; set; }
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";

            if (openFileDialog.ShowDialog() == true)
            {
                filename.Text = openFileDialog.FileName;
                //filename.Text = File.ReadAllText(openFileDialog.FileName);
            }
                
        }
    }
}
