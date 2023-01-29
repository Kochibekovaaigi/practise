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
using инопланетянин;

namespace космос
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Alien> ListOfAlines = new List<Alien>();

        private void alienbt_Click(object sender, RoutedEventArgs e)
        {
            Alien alien = new Alien();
            alien.Name = Convert.ToString(alienName.Text);
            alien.Planet = Convert.ToString(alienPlanet.Text);
            alien.Minheight = Convert.ToDouble(alienMinH.Text);
            alien.Maxheight = Convert.ToDouble(alienMaxH.Text);
            alien.Height = Convert.ToDouble(alienHeight.Text);
            ListOfAlines.Add(alien);
        }

        private void humanoidbt_Click(object sender, RoutedEventArgs e)
        {
            Humanoid humanoid = new Humanoid();
            humanoid.Name = Convert.ToString(humName.Text);
            humanoid.Planet = Convert.ToString(humPlanet.Text);
            humanoid.Minheight = Convert.ToDouble(humMinH.Text);
            humanoid.Maxheight = Convert.ToDouble(humMaxH.Text);
            humanoid.Height = Convert.ToDouble(humHeight.Text);
            humanoid.Weight = Convert.ToDouble(humWeight.Text);
            ListOfAlines.Add(humanoid);
        }

        private void reptiloidbt_Click(object sender, RoutedEventArgs e)
        {
            Reptiloid reptiloid = new Reptiloid();
            reptiloid.Name = Convert.ToString(repName.Text);
            reptiloid.Planet = Convert.ToString(repPlanet.Text);
            reptiloid.Minheight = Convert.ToDouble(repMinH.Text);
            reptiloid.Maxheight = Convert.ToDouble(repMaxH.Text);
            reptiloid.Height = Convert.ToDouble(repHeight.Text);
            reptiloid.NumOfTails = Convert.ToInt32(repNumOfTails.Text);
            ListOfAlines.Add(reptiloid);
        }

        private void alienshow_Click(object sender, RoutedEventArgs e)
        {
            AliensList.Content = "";
            foreach (Alien a in ListOfAlines)
                AliensList.Content += a.Info() + "\n";
        }

    }
}
