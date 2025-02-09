using DreamIsland.Logic;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
using DreamIsland.Logic;
using DreamIsland.UserInterface;
using System.Collections.ObjectModel;
using System.Threading;

namespace DreamIsland.WPF
{
    /// <summary>
    /// Логика взаимодействия для BuyTicketWindow.xaml
    /// </summary>
    public partial class BuyTicketWindow : UserControl
    {
        Client client1;
        Park myPark;
        Ticket workingTicket = null;
        List<Ticket> tickets = new List<Ticket>();
        public ObservableCollection<Attraction> AttractionsCollection { get; set; }
        public event EventHandler<ClientAuthorisedEventArgs> ClientUpdate;


        public BuyTicketWindow(Client client,Park park)
        {
            InitializeComponent();
            client1 = client;
            myPark = park;
        }

        private void AllInclusiveButton_Click(object sender, RoutedEventArgs e)
        {
            workingTicket = client1.Cart.TakeGeneralTicket(1);
            DialogStack.Visibility = Visibility.Visible;
        }

        private void SimpleAttractionButton_Click(object sender, RoutedEventArgs e)
        {
            AttractionsCollection = new ObservableCollection<Attraction>();
            List<Attraction> attractions = myPark.GetAvailableAttractions(client1.Age);
            foreach (Attraction attraction in attractions)
            {
                AttractionsCollection.Add(attraction);
            }

            this.DataContext = this;

            SimpleAttractionStackPanel.Visibility = Visibility.Visible;

        }

        private void StudentTicketButton_Click(object sender, RoutedEventArgs e)
        {
            if (client1.Age >= 15)
            {
                workingTicket = client1.Cart.TakeGeneralTicket(3);
                DialogStack.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("ВАМ НЕДОСТУПЕН ДАННЫЙ БИЛЕТ");
            }

        }

        private void FamilyTicketButton_Click(object sender, RoutedEventArgs e)
        {
            workingTicket = client1.Cart.TakeGeneralTicket(4);
            DialogStack.Visibility = Visibility.Visible;

        }

        private void AddAttraction_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, выбран ли элемент в DataGrid
            if (SimpleAttracionDG.SelectedItem != null)
            {
                // Приведение выбранного элемента к типу Attraction
                Attraction selectedAttraction = (Attraction)SimpleAttracionDG.SelectedItem;

                // Теперь вы можете использовать свойства selectedAttraction
                workingTicket = new Ticket(selectedAttraction.Name, selectedAttraction.Price);
            }
            DialogStack.Visibility = Visibility.Visible;
        }

        private void Comfirm_Click(object sender, RoutedEventArgs e)
        {
            client1.Cart.AddTicket(workingTicket);
            DialogStack.Visibility = Visibility.Collapsed;
            SimpleAttractionStackPanel.Visibility = Visibility.Collapsed;

            ClientUpdate?.Invoke(this, new ClientAuthorisedEventArgs() { CurrentClient = client1 });
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            workingTicket = null;

            DialogStack.Visibility = Visibility.Collapsed;
            SimpleAttractionStackPanel.Visibility = Visibility.Collapsed;

        }
    }
}
