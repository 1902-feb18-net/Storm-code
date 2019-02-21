using System.Xml.Serialization;

namespace SerializationAndAsync
{
    public class Person
    {
        [XmlAttribute]
        public int ID { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }
    }
}
