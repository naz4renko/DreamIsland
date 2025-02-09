using DreamIsland.Logic;
using DreamIsland.UserInterface;
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

namespace DreamIsland.WPF
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : UserControl
    {
        public Client client;
        Park authPark;
        public event Action RequestClose;

        public event EventHandler<ClientAuthorisedEventArgs> ClientAuthorised;

        public Authorization(Park myPark)
        {
            InitializeComponent();
            authPark = myPark;
        }
            
        private void ComfirmAuhorization_Click(object sender, RoutedEventArgs e)
        {

            EnterAge.ToolTip = string.Empty;
            EnterAge.Background = Brushes.Transparent;

            EnterName.ToolTip = string.Empty;
            EnterName.Background = Brushes.Transparent;

            string name = EnterName.Text;
            int age;
            if ((int.TryParse(EnterAge.Text, out age) && Verification.IsCorrectAge(age)) && (Verification.IsCorrectName(name)))
            {
                client = authPark.CreateClient(name, age);
                ClientAuthorised?.Invoke(this, new ClientAuthorisedEventArgs() { CurrentClient = client });
                RequestClose?.Invoke();
            }
            else
            {
                if ( (!int.TryParse(EnterAge.Text, out age) || !Verification.IsCorrectAge(age)) && Verification.IsCorrectName(name))
                {
                    EnterAge.ToolTip = "Это поле введено неверно!";
                    EnterAge.Background = Brushes.Tomato;
                }
                else if (!Verification.IsCorrectName(name) && (int.TryParse(EnterAge.Text, out age) && Verification.IsCorrectAge(age)))
                {
                    EnterName.ToolTip = "Это поле введено неверно!";
                    EnterName.Background = Brushes.Tomato;
                }
                else if( ( (!int.TryParse(EnterAge.Text, out age) || !Verification.IsCorrectAge(age) ) && (!Verification.IsCorrectName(name))))
                {
                    EnterName.ToolTip = "Это поле введено неверно!";
                    EnterName.Background = Brushes.Tomato;
                    EnterAge.ToolTip = "Это поле введено неверно!";
                    EnterAge.Background = Brushes.Tomato;
                }    
            }
        }

    }
}
