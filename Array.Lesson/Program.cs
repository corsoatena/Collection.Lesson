using System;

namespace Array.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[6];
            MyArray[0] = 10;
            MyArray[1] = 11;
            MyArray[2] = 12;
            MyArray[3] = 13;
            MyArray[4] = 14;
            MyArray[5] = 15;

           
            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = 0; j < MyArray.Length; j++)
                {
                    Console.WriteLine(MyArray[j]); // -> ultimo N  == 5
                                                   //i++
                }
            }
            
        }
    }
    internal class Person
    {

    }
}
