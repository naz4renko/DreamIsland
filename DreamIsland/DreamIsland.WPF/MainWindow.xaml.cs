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
using DreamIsland.Logic;
using DreamIsland.DataAccess;
using DreamIsland.UserInterface;
using System.Windows.Media.Effects;
using System.Media;

namespace DreamIsland.WPF
{
    public partial class MainWindow : Window
    {
        string attractions = "D:\\GITHUB\\DreamIsland\\DreamIsland.WPF\\bin\\Debug\\net7.0-windows\\Attractions.txt";
        string checkFile = "D:\\GITHUB\\\\DreamIsland\\DreamIsland.WPF\\bin\\Debug\\net7.0-windows\\Check.txt";
        string ticketTypes = "D:\\GITHUB\\\\DreamIsland\\DreamIsland.WPF\\bin\\Debug\\net7.0-windows\\TicketTypes.txt";

        WorkWithFile work = new WorkWithFile();
        MainController main = new MainController();
        Park myPark;
        Client mainClient;

        StartWindow startWindow = new StartWindow();

        public MainWindow()
        {
            InitializeComponent();
            myPark = work.InitializationPark(attractions, ticketTypes);
            Authorization authorization = new Authorization(myPark);
            UserController.Content = authorization;
            authorization.RequestClose += CloseMyControl;
            authorization.ClientAuthorised += Authorization_ClientAuthorised;
        }

        private void Authorization_ClientAuthorised(object? sender, ClientAuthorisedEventArgs e)
        {
                mainClient = e.CurrentClient;
                Info.Visibility = Visibility.Visible;
                Back.Visibility = Visibility.Visible;
                BuyTicket.Visibility = Visibility.Visible;
                CheckCart.Visibility = Visibility.Visible;
        }
        private void CloseMyControl()
        {
            UserController.Content = startWindow;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[0].Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            AttractionsInfo AtrInfo = new AttractionsInfo(myPark.Zones);
            UserController.Content = AtrInfo;
        }

        private void BuyTicket_Click(object sender, RoutedEventArgs e)
        {
            BuyTicketWindow buyTicketWindow = new BuyTicketWindow(mainClient,myPark);
            buyTicketWindow.ClientUpdate += Authorization_ClientAuthorised;
            UserController.Content = buyTicketWindow;
        }

        private void CheckCart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow(mainClient, checkFile);
            cartWindow.ClientUpdate += Authorization_ClientAuthorised;
            UserController.Content = cartWindow;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            UserController.Content = startWindow;
        }
    }
}
