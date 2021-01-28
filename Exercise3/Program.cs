using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> md = new MyDictionary<int, string>();

            md.Add(1, "Test 1");
            md.Add(2, "Test 2");
            md.Add(3, "Test 3");

            Console.WriteLine(md[3]);
        }
    }
}