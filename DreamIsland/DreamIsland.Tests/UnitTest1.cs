using DreamIsland.Logic;
using NuGet.Frameworks;
using System.Net.Sockets;
using System.Xml.Serialization;

namespace DreamIsland.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void For_Ticket_Type_1_Returns_All_Inclusive_Ticket()
        {
            //arrange
            int ticketType = 1;
            Ticket ticket = new Ticket("Всё включено", 2500);
            Cart cart = new Cart();
            //act
            var actual = cart.TakeGeneralTicket(ticketType);
            //assert
            Assert.Equal(ticket.Price, actual.Price);
            Assert.Equal(ticket.Type, actual.Type);
        }

        [Fact]
        public void For_Ticket_Type_2_Return_Exception()
        {
            int ticketType = 2;
            Cart cart = new Cart();

            Assert.Throws<UserWrongException>(() => cart.TakeGeneralTicket(ticketType));
        }

        [Fact]
        public void For_Ticket_Type_3_Returns_Student_Ticket()
        {
            //arrange
            int ticketType = 3;
            Ticket ticket = new Ticket("Студенческий", 1500);
            Cart cart = new Cart();
            //act
            var actual = cart.TakeGeneralTicket(ticketType);
            //assert
            Assert.Equal(ticket.Price, actual.Price);
            Assert.Equal(ticket.Type, actual.Type);
        }

        [Fact]
        public void For_Ticket_Type_4_Returns_Family_Ticket()
        {
            //arrange
            int ticketType = 4;
            Ticket ticket = new Ticket("Семейный", 5500);
            Cart cart = new Cart();
            //act
            var actual = cart.TakeGeneralTicket(ticketType);
            //assert
            Assert.Equal(ticket.Price, actual.Price);
            Assert.Equal(ticket.Type, actual.Type);
        }

        [Fact]
        public void Add_Tickets_And_Get_Price()
        {
            //arrange
            Ticket ticket_1 = new Ticket("Американские горки", 800);
            Ticket ticket_2 = new Ticket("Силомер", 600);
            Ticket ticket_3 = new Ticket("Карусель", 550);
            int expected = 1950;

            Cart cart = new Cart();
            cart.AddTicket(ticket_1);
            cart.AddTicket(ticket_2);
            cart.AddTicket(ticket_3);
            //act
            int actual = cart.GetTotalPrice();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_Tickets_And_Remove_1_Ticket_And_Get_Price()
        {
            //arrange
            Ticket ticket_1 = new Ticket("Американские горки", 800);
            Ticket ticket_2 = new Ticket("Силомер", 600);
            Ticket ticket_3 = new Ticket("Карусель", 550);
            int expected = 1350;

            Cart cart = new Cart();
            cart.AddTicket(ticket_1);
            cart.AddTicket(ticket_2);
            cart.AddTicket(ticket_3);
            cart.RemoveTicket(2);
            //act
            int actual = cart.GetTotalPrice();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Remove_First_Ticket_When_Cart_Is_Empty()
        {
            Cart cart = new Cart();

            Assert.Throws<UserWrongException>(() => cart.RemoveTicket(1));
        }

        [Fact]
        public void Remove_4th_Ticket_When_There_Are_Only_3_In_The_Cart()
        {
            //arrange
            Ticket ticket_1 = new Ticket("Американские горки", 800);
            Ticket ticket_2 = new Ticket("Силомер", 600);
            Ticket ticket_3 = new Ticket("Карусель", 550);
            Cart cart = new Cart();
            cart.AddTicket(ticket_1);
            cart.AddTicket(ticket_2);
            cart.AddTicket(ticket_3);
            //act && assert
            Assert.Throws<UserWrongException>(() => cart.RemoveTicket(4));
        }

        [Fact]
        public void Create_Client_With_Park_Method_Create_Client()
        {
            //arrange
            Client actual = new Client("Влад", 20);
            List<Zone> zones = null;
            string[] tickets = null;
            List<Attraction> attractions = null;
            Park park = new Park(zones, tickets, attractions);
            //act
            Client expected = park.CreateClient("Влад", 20);
            //assert
            Assert.Equal(actual.Name, expected.Name);
            Assert.Equal(actual.Age, expected.Age);
        }

        [Fact]
        public void Get_Available_Attractions_For_18_yo_Client()
        {
            //arrange
            int age = 18;
            List<Zone> zones = null;
            string[] tickets = null;

            Attraction atr1 = new Attraction("Горки", 600, 18);
            Attraction atr2 = new Attraction("Ледяная карусель", 400, 8);
            Attraction atr3 = new Attraction("Летающий корабль", 950, 12);
            Attraction atr4 = new Attraction("Адреналин", 700, 18);
            List<Attraction> attractions = new List<Attraction> { atr1, atr2, atr3, atr4 };

            Park park = new Park(zones, tickets, attractions);

            List<Attraction> actual = new List<Attraction> { atr1, atr4 };

            //act
            List<Attraction> expected = park.GetAvailableAttractions(age);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Get_Available_Attractions_For_10_yo_Client()
        {
            //arrange
            int age = 10;
            List<Zone> zones = null;
            string[] tickets = null;

            Attraction atr1 = new Attraction("Горки", 600, 18);
            Attraction atr2 = new Attraction("Ледяная карусель", 400, 8);
            Attraction atr3 = new Attraction("Летающий корабль", 950, 12);
            Attraction atr4 = new Attraction("Адреналин", 700, 18);
            List<Attraction> attractions = new List<Attraction> { atr1, atr2, atr3, atr4 };

            Park park = new Park(zones, tickets, attractions);

            List<Attraction> actual = new List<Attraction> { atr2 };

            //act
            List<Attraction> expected = park.GetAvailableAttractions(age);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Choise_1st_Attraction_In_List_With_Available_Attraction_And_Get_Ticket_With_This_Attraction()
        {
            //arrange
            int userInput = 4;
            List<Zone> zones = null;
            string[] tickets = null;

            Attraction atr1 = new Attraction("Горки", 600, 18);
            Attraction atr2 = new Attraction("Ледяная карусель", 400, 8);
            Attraction atr3 = new Attraction("Летающий корабль", 950, 12);
            Attraction atr4 = new Attraction("Адреналин", 700, 18);
            List<Attraction> attractions = new List<Attraction> { atr1, atr2, atr3, atr4 };

            Park park = new Park(zones, tickets, attractions);
            
            Ticket expected = new Ticket("Адреналин", 700);
            //act
            Ticket actual = park.ChooseAttractionFromList(attractions, userInput);
            //assert
            Assert.Equal(expected.Type, actual.Type);
            Assert.Equal(expected.Price, actual.Price);
        }

        [Fact]
        public void Add_Attractions_In_Zone()
        {
            //arrange
            Zone zone = new Zone();
            Attraction atr1 = new Attraction("Горки", 600, 18);
            Attraction atr2 = new Attraction("Ледяная карусель", 400, 8);
            Attraction atr3 = new Attraction("Летающий корабль", 950, 12);

            //act
            zone.AddAttraction(atr1);
            zone.AddAttraction(atr2);
            zone.AddAttraction(atr3);

            //assert
            Assert.Equal(3, zone.attractions.Count);
        }
    }
}