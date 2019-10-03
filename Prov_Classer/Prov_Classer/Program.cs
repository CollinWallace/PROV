using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Classer
{
    class Bok //Skapar en class
    {
        int price = 200;
        string name = "Call Of Cthulhu";
        int rarity = 100;
        string catagory = "Fiction";
        int actualValue;
        bool cursed;
        Random generator; 

        public void print() //Här skapar jag en public metod
        {
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Rarity " + rarity);
            Console.WriteLine("Catagory: " + catagory);
            //I metoden skriver jag flera console.writeline för att sedan kunna tillkalla den utanför classen och skriva ut allt som står med "PrintInfo"
        }
    }

    class Kund //Skapar en class för kunder
    {
        public void Kunder () //Skapar en public metod för en list
        {
            List<string> kundLista = new List<string>();
            string kundAntal = ""; //Stringen är lika med användarens input.
            kundAntal = Console.ReadLine();

            //Jag försöker skapa en lista där användaren kommer att kunna skriva in ett nummer och som sen baserat på det numret skapar platser i en lissta.

        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- GAME START ---");
            Console.WriteLine("Skriv in det antal kunder du vill ha med i spelet:");

            Kund KundAntal = new Kund(); //Här tillkallar jag classen in i Main.
            KundAntal.Kunder();
            KundAntal.Add(KundAntal); //Jag försökte göra så att det som skrivs adderas in i listan, men han tyvärr inte göra klart det.

            Bok PrintInfo = new Bok(); //Tillkallar classen Bok in till Main
            PrintInfo.print(); //Sedan skriver jag ut allt som finns i metoden "Print"
            Console.ReadLine();



        }
    }
}
