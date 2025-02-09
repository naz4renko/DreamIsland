using DreamIsland.Logic;
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

namespace DreamIsland.WPF
{
    /// <summary>
    /// Логика взаимодействия для AttractionsInfo.xaml
    /// </summary>
    public partial class AttractionsInfo : UserControl
    {
        List<Zone> workingZones = new List<Zone>();
        public AttractionsInfo(List<Zone> zones)
        {
            InitializeComponent();
            FirstZoneLabel.Text = zones[0].name;
            foreach(var item in zones[0].attractions)
            {
                FirstZoneList.Text += item.Name + " " + Convert.ToString(item.Price) + " руб." +"\n";
            }

            SecondZoneLabel.Text = zones[1].name;
            foreach (var item in zones[1].attractions)
            {
                SecondZoneList.Text += item.Name + " " + Convert.ToString(item.Price) + " руб." + "\n";
            }

            ThirdZoneLabel.Text = zones[2].name;
            foreach (var item in zones[2].attractions)
            {
                ThirdZoneList.Text += item.Name + " " + Convert.ToString(item.Price) + " руб." + "\n";
            }

            FourthZoneLabel.Text = zones[3].name;
            foreach (var item in zones[3].attractions)
            {
                FourthZoneList.Text += item.Name + " " + Convert.ToString(item.Price) + " руб." + "\n";
            }
        }
    }
}
