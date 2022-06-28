using System;

namespace Array.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Traveller traveller1 = new Traveller("Bruno", 40);
            Traveller traveller2 = new Traveller("Diego", 36);
            Traveller traveller3 = new Traveller("Damiano", 23);
            Traveller traveller4 = new Traveller("Abreham", 38);
            Traveller traveller5 = new Traveller("michele", 34);
            Traveller traveller6 = new Traveller("Alex", 21);
            Traveller traveller7 = new Traveller("Mario", 30);

            Viaggio travel = new Viaggio();// Creao l'oggetto Travel è la Contenitore
            travel.AddTraveller(traveller1);
            travel.AddTraveller(traveller2);
            travel.AddTraveller(traveller3);
            travel.AddTraveller(traveller4);
            travel.AddTraveller(traveller5);
            travel.AddTraveller(traveller6);
            travel.AddTraveller(traveller7);

            for (int i = 0; i < travel._viaggiatori.Length; i++)
            {
                Console.WriteLine(travel._viaggiatori[i]._name);//5 null
            }

              //System.NullReferenceException: 'Object reference not set to an instance of an object.'

              //travel._viaggiatori[5] was null.


            //foreach (var item in travel._viaggiatori)
            //{

            //    if (item._age > 36)
            //    {
            //        Console.WriteLine(item._name);
            //    }
            //}
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
            _viaggiatori[counter] = traveller; //0          
            counter++; 
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
