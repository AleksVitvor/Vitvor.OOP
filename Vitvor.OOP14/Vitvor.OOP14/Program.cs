using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Vitvor.OOP14
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviation aviation = new Aviation(600);
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream fs= new FileStream("aviation.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, aviation);
            }
            using (FileStream fs = new FileStream("aviation.dat", FileMode.OpenOrCreate))
            {
                Aviation newaviation = (Aviation)formatter.Deserialize(fs);
                Console.WriteLine(newaviation.ToString());
            }
            SoapFormatter soap = new SoapFormatter();
            using (FileStream fs = new FileStream("aviation.soap", FileMode.OpenOrCreate))
            {
                soap.Serialize(fs, aviation);
            }
            using (FileStream fs = new FileStream("aviation.soap", FileMode.OpenOrCreate))
            {
                Aviation newaviation1 = (Aviation)soap.Deserialize(fs);
                Console.WriteLine(newaviation1.ToString());
            }
            XmlSerializer xml = new XmlSerializer(typeof(Aviation));
            using (FileStream fs = new FileStream("aviation.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, aviation);
            }
            using (FileStream fs = new FileStream("aviation.xml", FileMode.OpenOrCreate))
            {
                Aviation newaviation2 = (Aviation)xml.Deserialize(fs);
                Console.WriteLine(newaviation2.ToString());
            }
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Aviation));
            using (FileStream fs = new FileStream("aviation.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, aviation);
            }
            using (FileStream fs = new FileStream("aviation.json", FileMode.OpenOrCreate))
            {
                Aviation newaviation3 = (Aviation)jsonSerializer.ReadObject(fs);
                Console.WriteLine(newaviation3.ToString());
            }
            Aviation[] aviations = new Aviation[] {
            new Aviation(500),
            new Aviation(500),
            new Aviation(500),
            new Aviation(500),
            new Aviation(500),
            new Aviation(700)
            };
            BinaryFormatter formatters = new BinaryFormatter();
            using (FileStream fs = new FileStream("aviations.dat", FileMode.OpenOrCreate))
            {
                formatters.Serialize(fs, aviations);
            }
            using (FileStream fs = new FileStream("aviations.dat", FileMode.OpenOrCreate))
            {
                Aviation[] newaviations = (Aviation[])formatters.Deserialize(fs);
                Console.WriteLine(newaviations.ToString());
            }
            SoapFormatter soaps = new SoapFormatter();
            using (FileStream fs = new FileStream("aviations.soap", FileMode.OpenOrCreate))
            {
                soaps.Serialize(fs, aviations);
            }
            using (FileStream fs = new FileStream("aviations.soap", FileMode.OpenOrCreate))
            {
                Aviation[] newaviations1 = (Aviation[])soaps.Deserialize(fs);
                Console.WriteLine(newaviations1.ToString());
            }
            XmlSerializer xmls = new XmlSerializer(typeof(Aviation[]));
            using (FileStream fs = new FileStream("aviations.xml", FileMode.OpenOrCreate))
            {
                xmls.Serialize(fs, aviations);
            }
            using (FileStream fs = new FileStream("aviations.xml", FileMode.OpenOrCreate))
            {
                Aviation[] newaviations2 = (Aviation[])xmls.Deserialize(fs);
                Console.WriteLine(newaviations2.ToString());
            }
            DataContractJsonSerializer jsonSerializers = new DataContractJsonSerializer(typeof(Aviation[]));
            using (FileStream fs = new FileStream("aviations.json", FileMode.OpenOrCreate))
            {
                jsonSerializers.WriteObject(fs, aviations);
            }
            using (FileStream fs = new FileStream("aviations.json", FileMode.OpenOrCreate))
            {
                Aviation[] newaviations3 = (Aviation[])jsonSerializers.ReadObject(fs);
                Console.WriteLine(newaviations3.ToString());
            }
            XmlDocument document = new XmlDocument();
            document.Load("aviations.xml");
            XmlElement xRoot = document.DocumentElement;
            XmlNode node = xRoot.SelectSingleNode("Aviation[_Wingspan='500']");
            XmlNode node1 = xRoot.SelectSingleNode("Aviation[_Wingspan='700']");
            Console.WriteLine(node.OuterXml);
            Console.WriteLine(node1.OuterXml);
            XDocument document1 = XDocument.Load("aviations.xml");
            XElement element = document1.Element("ArrayOfAviation");
            var items = from xe in element.Elements("Aviation") where xe.Element("_Wingspan").Value == "500" select xe;
            using (StreamWriter fs = new StreamWriter("aviationss.xml"))
            {
                foreach (XElement xe in items)
                {
                    fs.WriteLine(xe);
                }
            }
            Console.ReadLine();
        }
    }
}
