using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindItem("Bruno");
        }
        static void FindItem(string Name)
        {
             //Char[] mystring = "BrunoMars".ToCharArray();
             string[] parts =  new string[10];
             parts[0] = "Bruno";
             //parts[1] = "Laura";

             string[] items = { "BrunoFerreira", "BrunoMars", "Elena", "Fabio" };
             string[] myVariable = parts.Where(item => item != null).ToArray();


        }
    }
}

