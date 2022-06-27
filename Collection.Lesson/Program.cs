using System;
using System.Collections.Generic;

namespace Collection.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Traveller traveller1 = new Traveller("Bruno",40); 
            Traveller traveller2 = new Traveller("Diego",36);
            Traveller traveller3 = new Traveller("Damiano",23);
            Traveller traveller4 = new Traveller("Abreham",38);

            Viaggio travel = new Viaggio();// Creao l'oggetto Travel è la Contenitore
            travel.AddTraveller(traveller1);
            travel.AddTraveller(traveller2);
            travel.AddTraveller(traveller3);
            travel.AddTraveller(traveller4);
           
            foreach (var item in travel._viaggiatori)
            {  
                
                if (item._age > 36)
                {
                    Console.WriteLine(item._name);
                }
            }
        }
    }

    public class Viaggio // -> Viaggio n Viaggiatori
    {
        internal List<Traveller> _viaggiatori = new List<Traveller>(); // Collection

        public Viaggio()
        {

        }
        internal void AddTraveller(Traveller traveller)
        {
            _viaggiatori.Add(traveller);
         
        }

    }
    internal class Traveller
    {
        public string _name;
        public int _age; 

        public Traveller(string Name,int Age)
        {
            _name = Name;
            _age = Age; 
        }
    }
}
