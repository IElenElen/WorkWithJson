using System.ComponentModel.Design;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WorkWithJson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Json - ćwiczenia");
            Console.WriteLine();
            Console.WriteLine("Cmd w poleceniu w windows i tworzę dane po Users > U mnie np. echo odstęp {w cudzysłowiach teksty}");
            Console.WriteLine(@"po nawiasie > ścieżka aż do Destop i \ dane.json");
            Console.WriteLine("Plik json utworzony na pulpicie.");
            Console.WriteLine();
            Console.WriteLine("Teraz chcemy plik json odczytać. Warto skorzystać z nazwy obiektu we właściwościach.");

            //odczyt pliku
            string filePath = @"C:\Users\Ilka\Desktop\dane.json"; //ścieżka
            string fileContent = File.ReadAllText(filePath); //odczytanie

            dynamic? data = JsonConvert.DeserializeObject<dynamic>(fileContent);

            if (data != null)
            {
                foreach (var obiekt in data)
                {
                    Console.WriteLine(obiekt);
                }
            }
            else
            {
                Console.WriteLine("Pusty plik.");
            }
            //kolejny etap: edycja pliku
        }
    }
}
