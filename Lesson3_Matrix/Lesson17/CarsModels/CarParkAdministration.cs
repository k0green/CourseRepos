using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml;

namespace Lesson15_CarCompany.Models
{
    [Serializable]
    internal class CarParkAdministration : ICloneable
    {
        public List<ICarTemplate> _cars = new List<ICarTemplate>();
        public List<ICarTemplate> _machins = new List<ICarTemplate>();

        public event NotificationHandler? Notify;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fstream = new FileStream("CarsPark.txt", FileMode.OpenOrCreate);
        XmlDocument xmldoc = new XmlDocument();

        public void Add(ICarTemplate carTemplat)
        {

            _cars.Add(carTemplat);

            xmldoc.Load("CarPark.xml");

            XmlElement? xRoot = xmldoc.DocumentElement;

            XmlElement carElement = xmldoc.CreateElement("car");
            XmlAttribute companyAttr = xmldoc.CreateAttribute("company");
            XmlElement modelElem = xmldoc.CreateElement("model");
            XmlElement idElem = xmldoc.CreateElement("id");

            XmlText companyText = xmldoc.CreateTextNode(carTemplat.Company);
            XmlText modelText = xmldoc.CreateTextNode(carTemplat.Model);
            XmlText idText = xmldoc.CreateTextNode(Convert.ToString(carTemplat.Id));

            companyAttr.AppendChild(companyText);
            modelElem.AppendChild(modelText);
            idElem.AppendChild(idText);

            carElement.Attributes.Append(companyAttr);
            carElement.AppendChild(modelElem);
            carElement.AppendChild(idText);
            xRoot?.AppendChild(carElement);

            xmldoc.Save("CarPark.xml");

            bf.Serialize(fstream, carTemplat);

            var jser = JsonSerializer.Serialize(carTemplat);
            File.WriteAllText("Cars.txt", jser);

            Notify?.Invoke($"Car was add");
        }

        public object Clone() => MemberwiseClone();

        public void PrintAll()
        {
            fstream.Position = 0;
            ICarTemplate storage = (ICarTemplate)bf.Deserialize(fstream);
            _machins.Add(storage);
            Notify?.Invoke("Display all cars in park:\n\n");

            foreach (var l in _machins)
            {
                Console.WriteLine($"{l.GetType().Name}::  {l.GetDisplayData()}");
            }
        }
        public void RemoveCar()
        {
            int i = 0;
            PrintAll();
            foreach (var l in _machins)
            {
                Console.WriteLine($"{i}. {l.GetDisplayData()}");
                i++;
            }
            Console.WriteLine("enter num of car to remove");
            int num = Convert.ToInt32(Console.ReadLine());
            _machins.RemoveAt(num);

            File.Delete("CarPark.txt");
            bf.Serialize(fstream, _machins);
            Notify?.Invoke("Car was remove");
        }
        public void FinishProgWork() { }
        public void PrintLogos() { }
        public delegate void NotificationHandler(string msg);
    }
}