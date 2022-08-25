using System;
using System.Collections;

namespace CollectionsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arr = new ArrayList();

            //arr.Add("Bengaluru");
            //arr.Add("Chennei");
            //arr.Add("Mumbai");

            //////Console.WriteLine(arr.Count);

            //arr.Add("Kochi");
            //arr.Add("Trivandrum");

            //Console.WriteLine(arr.Count);

            ////arr.RemoveAt(3);
            //arr.Remove("Kochi");
            //arr.Insert(3, "Kolkata");

            //arr.Add(10);
            //arr.Add(50.50F);

            //Console.WriteLine(arr.Count);
            //foreach (var a in arr)
            //    Console.WriteLine(a);

            Hashtable hashtable = new Hashtable();
            hashtable.Add("Karnataka", "Bengaluru");
            hashtable.Add("Kerala", "Trivandrum");
            hashtable.Add("Tamil Nadu", "Chennei");

            hashtable["Kerala"] = "Tiruvanantapuram";

            foreach(var key in hashtable.Keys)
            {
                Console.WriteLine(key + ": " + hashtable[key]);
            }
        }
    }
}
