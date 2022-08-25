using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file name : ");
            string fileName = Console.ReadLine();

            Console.Write("Where do you need to play : ");
            string deviceName = Console.ReadLine();

            IAudioService device = PickAudioDevice(deviceName);
            device.PlayAudio(fileName);
        }
        static IAudioService PickAudioDevice(string deviceName)
        {
            IAudioService audioDevice = null;

            switch(deviceName)
            {
                case "MyTunes": audioDevice = new MyTunes();break;
                case "MyPhone": audioDevice = new MyPhone(); break;
                case "VR": audioDevice = new MyVrHeadSet(); break;
            }

            return audioDevice;
        }
    }
}
