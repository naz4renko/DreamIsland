using DreamIsland.DataAccess;
using DreamIsland.Logic;
using DreamIsland.UserInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : UserControl
    {
        Client client2;
        Ticket workingTicket = null;
        List<Ticket> tickets = new List<Ticket>();
        WorkWithFile work = new WorkWithFile();
        string workingCheck = null;

        public event EventHandler<ClientAuthorisedEventArgs> ClientUpdate;
        public CartWindow(Client client, string checkFile)
        {
            InitializeComponent();
            client2 = client;
            workingCheck = checkFile;
            CartDataGrid.ItemsSource = client2.Cart.GetTickets();
        }

        private void RemoveTicket_Click(object sender, RoutedEventArgs e)
        {
            if (CartDataGrid.SelectedItem != null)
            {
                int index = CartDataGrid.Items.IndexOf(CartDataGrid.SelectedItem);
                client2.Cart.RemoveTicket(index+1);

            }
            CartDataGrid.ItemsSource = null;
            CartDataGrid.ItemsSource = client2.Cart.GetTickets();
            ClientUpdate?.Invoke(this, new ClientAuthorisedEventArgs() { CurrentClient = client2 });
        }

        private void ComfirmCart_Click(object sender, RoutedEventArgs e)
        {
            DialogStack.Visibility = Visibility.Visible;
        }

        private void Comfirm_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order(client2);
            Check check = new Check(order);
            DialogStack.Visibility = Visibility.Collapsed;
            CheckWindow.Visibility = Visibility.Visible;
            ClientName.Text = check.ClientName;
            ClientAge.Text = Convert.ToString(check.ClientAge);
            EndedListOfTickets.ItemsSource = check.Tickets;
            ClientTotalPrice.Text = Convert.ToString(check.TotalPrice);
            work.SaveCheckInFile(order, workingCheck);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogStack.Visibility = Visibility.Collapsed;
        }
    }
}
