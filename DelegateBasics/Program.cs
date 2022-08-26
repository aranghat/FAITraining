using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateBasics
{
    class Program
    {
        //delegate void Print(string message);
        delegate void Callback(string fileName);
        delegate string ModifyMessage(string message);
        static void Main(string[] args)
        {
            Func<string, string> funcModify = ModifyWithDateTime;

            Console.WriteLine(funcModify("Hello World"));

            Action<string> callback = SentFileByEmail;
            callback += PlayMusic;

            //Callback callback = SentFileByEmail;
            //callback += PlayMusic;
            //callback += ShowImageInGallery;
            callback += delegate(string fileName) { Console.WriteLine($"Log Entry : {fileName}"); };


            callback -= PlayMusic;

            DownloadFile("mymusic.mp3",callback);
        }

        static string ModifyWithDateTime(string message)
        {
            return $"{DateTime.Now} {message}";
        }

        static string ModifyWithDateTimeToUpperCase(string message)
        {
            return  $"{DateTime.Now} {message}".ToUpper();
        }

        static void PlayMusic(string fileName)
        {
            Console.WriteLine($"Staring music {fileName}");
        }

        static void SentFileByEmail(string fileName)
        {
            Console.WriteLine($"Sending my mail {fileName}");
        }

        static void ShowImageInGallery(string fileName)
        {
            Console.WriteLine($"Opening Gallery {fileName}");
        }

        static void DownloadFile(string fileName,Action<string> callback)
        {
            Console.WriteLine($"Starting to download {fileName}");
            Thread.Sleep(3000);
            Console.WriteLine($"File Downloaded");

            callback(fileName);

        }


        //static void GetAndShowMessage(Print print)
        //{
        //    var message = Console.ReadLine();
        //    print(message);
        //}

        //static void DisplayMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}

        //static void DisplayMessageWithTime(string message)
        //{
        //    Console.WriteLine($"{DateTime.Now}  {message}");
        //}

        //static string CreateMessage(string message)
        //{
        //    return "";
        //}
    }
}
