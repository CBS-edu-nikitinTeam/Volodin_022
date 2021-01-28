using System;
using System.Collections;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add("Два");
            list.Add(DateTime.Parse("01/01/2021"));

            for (int i = 0; i < list.Capacity(); i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
