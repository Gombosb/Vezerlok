
using System.Windows;

namespace Vezerlok
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Kuldes(object sender, RoutedEventArgs e)
        //{
        //    string nev = Nev.Text;
        //    string jelszo = Jelszo.Password;
        //    string cookies = Cookies.IsChecked == true? "Elfogadva" : "Nincs elfogadva";
        //    string nem = "";

        //    if (Ferfi.IsChecked == true)
        //    {
        //        nem = "Férfi";
        //    }
        //    else if (No.IsChecked == true)
        //    {
        //        nem = "Nő";
        //    }
        //    else
        //    {
        //        MessageBox.Show("Válassz nemet!");
        //    }

        //        MessageBox.Show($"Név: {nev}\n" + $"Jelszó: {jelszo}\n" + $"Fetételek: {cookies}\n"
        //            + $"Nem: {nem}", "Beküldött adatok");

        //    Nev.Clear();
        //    Jelszo.Clear();
        //    Cookies.IsChecked = false;
        //}
    }
}
