using System;
using System.Collections.Generic;


namespace GenericCollectionsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> cities = new List<string>();
            //List<int> marks = new List<int>();

            //cities.Add("Bengaluru");
            //cities.Add("Chennei");
            //cities.AddRange(new string[] { "Kolkata", "Mumbai", "Kochi" });


            //foreach (var city in cities)
            //    Console.WriteLine(city);

            //Dictionary<string, int> marks = new Dictionary<string, int>();
            //marks.Add("Maths", 60);
            //marks.Add("Science", 70);
            //marks.Add("English", 80);

            //int marksForEnglish = marks["English"];
            //Console.WriteLine(marksForEnglish);

            //if (marks.ContainsKey("English"))
            //    Console.WriteLine("Marks for english is already added");

            //foreach (var key in marks.Keys)
            //    Console.WriteLine($"Subject : {key}, Marks : {marks[key]}");

            //Dictionary<string, Dictionary<string, int>> studentMarks 
            //    = new Dictionary<string, Dictionary<string, int>>();

            //SortedDictionary<string, int> studentMarks = new SortedDictionary<string, int>();
            //studentMarks.Add("Sree", 80);
            //studentMarks.Add("Bill", 90);
            //studentMarks.Add("Zack", 95);

            ////foreach (var keyValuePair in studentMarks)
            ////    Console.WriteLine($"Name : {keyValuePair.Key} " +
            ////        $", Marks : {keyValuePair.Value}");

            //SortedSet<string> studentNames = new SortedSet<string>();
            //studentNames.Add("Sree");
            //studentNames.Add("Emma");
            //studentNames.Add("Bill");
            //studentNames.Add("John");

            //foreach (var name in studentNames.Reverse())
            //    Console.WriteLine(name);

            //Stack<string> parcels = new Stack<string>();

            //parcels.Push("Parcel 1");
            //parcels.Push("Parcel 2");
            //parcels.Push("Parcel 3");

            //Console.WriteLine(parcels.Pop());
            //Console.WriteLine("---------------");

            //foreach (var p in parcels)
            //    Console.WriteLine(p);

            Queue<string> movieLine = new Queue<string>();
            movieLine.Enqueue("User 1");
            movieLine.Enqueue("User 2");
            movieLine.Enqueue("User 3");

            Console.WriteLine(movieLine.Dequeue());
            Console.WriteLine("--------------------------");

            foreach (var m in movieLine)
                Console.WriteLine(m);


        }
    }
}
