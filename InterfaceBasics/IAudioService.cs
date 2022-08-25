using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasics
{
    public interface IDeviceInfoService
    {
        string DeviceName { get;  }
        string SerialNo { get;  }
    }

    public interface IAudioService
    {
        void PlayAudio(string fileName);
        void StopAudio();
    }

    public interface IVideoService
    {
        void PlayMedia(string fileName);
        void StopMedia();
    }

    public class MyTunes : IDeviceInfoService, IAudioService
    {
        private string fileName = "";

        public string DeviceName { get { return "MYTUNES ";  } }

        public string SerialNo { get { return "SN:123456"; } }

        public void PlayAudio(string fileName)
        {
            this.fileName = fileName;
            Console.WriteLine($"MyTunes : Playing audio from file {fileName}");
        }

        public void StopAudio()
        {
            if (fileName.Length > 0)
            {
                Console.WriteLine($"My Tunes :Stopping file {fileName}");
                fileName = "";

            }
            else
                Console.WriteLine("No file is playing");
        }
    }

    public class MyPhone : IAudioService, IVideoService
    {
        private string fileName = "";
        public void PlayAudio(string fileName)
        {
            this.fileName = fileName;
            Console.WriteLine($"MyPhone : Playing audio from file {fileName}. Touch to stop");
        }

        public void PlayMedia(string fileName)
        {
            Console.WriteLine($"Playing Video {fileName}");
        }

        public void StopAudio()
        {
            if (fileName.Length > 0)
            {
                Console.WriteLine($"My Tunes :Stopping file {fileName}");
                fileName = "";

            }
            else
                Console.WriteLine("No file is playing");
        }

        public void StopMedia()
        {
            Console.WriteLine($"Stopping Video {fileName}");
        }
    }

    public class MyVrHeadSet : IAudioService, IVideoService
    {
        public void PlayAudio(string fileName)
        {
            Console.WriteLine("Playing in VR");
        }

        public void PlayMedia(string fileName)
        {
            throw new NotImplementedException();
        }

        public void StopAudio()
        {
            throw new NotImplementedException();
        }

        public void StopMedia()
        {
            throw new NotImplementedException();
        }
    }
}
