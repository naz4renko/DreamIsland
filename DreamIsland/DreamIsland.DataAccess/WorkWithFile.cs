using DreamIsland.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.DataAccess
{
    public class WorkWithFile
    {
        string[] dbAttractions;
        string[] dbTicketsInfo;
        List<Zone> dbZones;
        List<Attraction> dbAllSimpleAtr;
        public string[] DbAttractions
        {
            get { return dbAttractions; }
        }
        public string[] DbTicketsInfo
        {
            get { return dbTicketsInfo; }
        }
        public WorkWithFile()
        {
        }
        public static string[] ReadFile(string filePath)
        {
            string[] text = File.ReadAllLines(filePath);
            return text;
        }
        public Park InitializationPark(string fileWithAtr, string fileWithTickets)
        {
            dbTicketsInfo = ReadFile(fileWithTickets);
            dbAttractions = ReadFile(fileWithAtr);
            dbZones = CreateCatalog(dbAttractions);
            dbAllSimpleAtr = CreateListOfSimpleAttraction(dbAttractions);
            return new Park(dbZones, dbTicketsInfo, dbAllSimpleAtr);
        }
        public static List<Zone> CreateCatalog(string[] file)
        {
            List<Zone> zones = new List<Zone>();
            Zone currentZone = null;
            foreach (string line in file)
            {
                if (line.StartsWith("#"))
                {
                    currentZone = new Zone { name = line.Substring(1).Trim() };
                    zones.Add(currentZone);
                }
                else if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] attrDetails = line.Split(",");
                    if (attrDetails.Length == 3 && int.TryParse(attrDetails[1].Trim(), out int price) && int.TryParse(attrDetails[2].Trim(), out int age))
                    {
                        Attraction attraction = new(attrDetails[0].Trim(), price, age);
                        currentZone?.AddAttraction(attraction);
                    }
                }
            }
            return zones;
        }
        public static List<Attraction> CreateListOfSimpleAttraction(string[] file)
        {
            List<Attraction> attractionList = new List<Attraction>();
            foreach (string line in file)
            {
                if (!line.StartsWith("#"))
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] attrDetails = line.Split(",");
                        if (attrDetails.Length == 3 && int.TryParse(attrDetails[1].Trim(), out int price) && int.TryParse(attrDetails[2].Trim(), out int age))
                        {
                            Attraction attraction = new(attrDetails[0].Trim(), price, age);
                            attractionList.Add(attraction);
                        }
                    }
                }

            }
            return attractionList;
        }
        public void SaveCheckInFile(Order order, string args)
        {
            using (StreamWriter str = new StreamWriter(args, false))
            {
                str.WriteLine($"Клиент: {order.ClientName} \nВозраст: {order.ClientAge}");
                foreach (var item in order.Tickets)
                {
                    str.WriteLine($"Наименование билета: {item.Type}, Цена: {item.Price}");
                }
                str.WriteLine($"Итого: {order.TotalPrice}");
            }
        }
    }
}
