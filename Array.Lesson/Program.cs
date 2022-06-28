using System;
using System.Collections.Generic;

namespace Array.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Viaggio travel =new Viaggio();

            Traveller[] Travellers = new Traveller[10] //candidati per un viaggio
            {
                new Traveller("Bruno",40),
                new Traveller("Diego",36),
                new Traveller("Damiano",40),
                new Traveller("Abreham",36),
                new Traveller("Michele",40),
                new Traveller("Alex",36),
                new Traveller("Mario",40),
                new Traveller("Angelo",36),
                new Traveller("Elisa",40),
                new Traveller("Laura",36)

            };

            int counter = 0;

            while (counter < travel._viaggiatori.Length)
            {
                travel.AddTraveller(Travellers[counter]);
                counter++;//6
            } //esce dal ciclo se counter == 6

            foreach (var item in travel._viaggiatori)
            {
                Console.WriteLine(item._name);
            }
        }
    }

    public class Viaggio // -> Viaggio n Viaggiatori
    {   
        const int _viaggiatoriNumbers = 6;
        
        int counter = 0;
        internal Traveller[] _viaggiatori = new Traveller[_viaggiatoriNumbers];

        public Viaggio()
        {

        }
        internal void AddTraveller(Traveller traveller)
        {
            if (counter < _viaggiatori.Length)
            {
                _viaggiatori[counter] = traveller;
                counter++; 
            }
        }

    }
    internal class Traveller
    {
        public string _name;
        public int _age;

        public Traveller(string Name, int Age)
        {
            _name = Name;
            _age = Age;
        }
    }
}
