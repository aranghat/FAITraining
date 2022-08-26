
using System;
using System.IO;
using System.Net;

namespace FileIOBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var directoryList = new DirectoryInfo(@"D:\FATraining")
            //                                    .EnumerateDirectories("A*.*",SearchOption.AllDirectories);
            ////foreach (var dir in directoryList)
            ////    Console.WriteLine($"{dir.Name} {dir.FullName}");

            //var fileList = new DirectoryInfo(@"D:\FATraining")
            //                                     .EnumerateFiles("*.cs",SearchOption.AllDirectories);

            //foreach (var file in fileList)
            //    Console.WriteLine($"{file.Name} {file.Extension}  {file.Length}");

            //if (!Directory.Exists(@"D:\FATraining\Temp\MyNewFolder"))
            //    Directory.CreateDirectory(@"D:\FATraining\Temp\MyNewFolder");
            //else
            //    Console.WriteLine("Folder already exist");

            //if (!File.Exists(@"D:\FATraining\Temp\MyNewFolder\MyNotes.txt"))
            //    File.Create(@"D:\FATraining\Temp\MyNewFolder\MyNotes.txt");
            //else
            //    Console.WriteLine("File already exist");

            //File.WriteAllText(@"D:\FATraining\Temp\MyNewFolder\MyNotes.txt", "Hello This is a test");
            //File.AppendAllText(@"D:\FATraining\Temp\MyNewFolder\MyNotes.txt"
            //                    , "This is a new line\n");

            //var fileContents = File.ReadAllText(@"D:\FATraining\Temp\MyNewFolder\MyNotes.txt");
            //Console.WriteLine(fileContents);

            StreamWriter fileWriter = new StreamWriter(@"D:\FATraining\Temp\MyNewFolder\MyNotes.txt", true);
            fileWriter.WriteLine("Line 1 : Hello There");
            fileWriter.WriteLine("Line 2 : Hello There Again");

            fileWriter.Close();

            //StreamReader reader = new StreamReader(@"D:\FATraining\Temp\MyNewFolder\MyNotes.txt");
            //var content = reader.ReadToEnd();

            //Console.WriteLine(content);
            //reader.Close();

            WebClient client = new WebClient();
            var stream = client.OpenRead("https://www.ietf.org/rfc/rfc2616.txt");


            StreamReader reader = new StreamReader(stream);
            var content = reader.ReadToEnd();
            Console.WriteLine(content);

            var guid = Guid.NewGuid().ToString();
            StreamWriter write = new StreamWriter($@"D:\FATraining\Temp\MyNewFolder\{guid}.txt");
            write.WriteLine(content);
            write.Close();
        }
    }
}
