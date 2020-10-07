using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Text.Json.Serialization;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> lb1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitListBox()
        {
            lb1 = new List<Person> {
                new Person { Fornamn = "Thomas", Efternamn = "Brunström", Email = "tbn@du.se" },
                new Person { Fornamn = "Titti", Efternamn = "Hane", Email = "khe@du.se" },
                new Person { Fornamn = "Thomas", Efternamn = "Kvist", Email = "tkv@du.se" },
                new Person { Fornamn = "Alexander", Efternamn = "Karlsson", Email = "alk@du.se" },
                new Person { Fornamn = "Pär", Efternamn = "Eriksson", Email = "pei@du.se" },
            };
            ListBox1.Items.Clear();
            ListBox1.ItemsSource = lb1;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // using (WebClient wc = new WebClient())
            // {
                
            //     var json =  JsonSerializer.Deserialize<Joke>(wc.DownloadString("https://sv443.net/jokeapi/v2/joke/Any?type=single"));
            // }            
            InitListBox();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBox1.SelectedIndex != -1)
            {
                LblFornamn_Content.Content = lb1[ListBox1.SelectedIndex].Fornamn;
                LblEfterNamn_Content.Content = lb1[ListBox1.SelectedIndex].Efternamn;
                LblEpost_Content.Content = lb1[ListBox1.SelectedIndex].Email;
            }
            
        }
        
    }
    public class Person
    {
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string Email { get; set; }
    }

    [Serializable]
    public class Joke 
    {
        public bool error {get;set;}
        public string category {get;set;}
        public string type {get;set;}
        public string joke {get;set;}
        public Dictionary<string, bool> flags {get;set;}
        public int id {get;set;}
        public string lang {get;set;}
    }
}