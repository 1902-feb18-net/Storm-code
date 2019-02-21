using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationAndAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>()
            {
                new Person
                {
                    ID = 1,
                    Name = "Storm",
                    Address = new Address
                    {
                        Street = "905 wildwood",
                        City = "Anna",
                        State = "TX"
                    }
                },
                new Person
                {
                    ID = 2,
                    Name = "TheCoolerStorm",
                    Address = new Address
                    {
                        Street = "MoonLN",
                        City = "MoonVille",
                        State = "TheMoon"
                    }
                }
            };
            //string newline = "/n";

            string filename = @"C:\revature\Storm - code\thisright.xml";

            SerializAsXMLToFile(filename, persons);



            JsonConvert.DeserializeObject<List<Person>>(File.ReadAllTextAsync(filename).Result);
        }

        private static void SerializAsXMLToFile(string filename, List<Person> persons)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));

            FileStream filestream = null;

            try
            {
                filestream = new FileStream(filename, FileMode.Create);
                serializer.Serialize(filestream, persons);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                filestream?.Dispose();
            }
        }


        private static async Task<List<Person>> DeserializAsXMLFromFile(string filename)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));

            using (var memorystream = new MemoryStream())
            {
                using (var filestream = new FileStream(filename, FileMode.Open))
                {
                    Task copying = filestream.CopyToAsync(memorystream);
                    await copying;
                }
                memorystream.Position = 0;

                return (List<Person>)serializer.Deserialize(memorystream);
            }
        }
    }
}
