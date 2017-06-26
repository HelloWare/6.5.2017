using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakePicture_InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Photographer photographer = new Photographer();
            Camera camera = new Camera();
            Phone phone = new Phone();
            IPad ipad = new IPad();
            photographer.TakeAPicOnDevice(camera);
            photographer.TakeAPicOnDevice(phone);
            photographer.TakeAPicOnDevice(ipad);
        }
    }


    public interface IPhotoDevice
    {
       void TakePic();
    }


    class Photographer
    {
        public void TakeAPicOnDevice(IPhotoDevice device)
        {
            device.TakePic();
        }
    }

    class Phone : IPhotoDevice
    {
        public void TakePic()
        {
            Console.WriteLine("take a pic on phone");
        }
        public void Call()
        {
            Console.WriteLine("phone is calling");
        }
    }
    class Camera:IPhotoDevice
    {
        public void TakePic()
        {
            Console.WriteLine("take a pic on camera");
        }
    }
    class IPad : IPhotoDevice
    {
        public void TakePic()
        {
            Console.WriteLine("take a pic on ipad");
        }
    }

}
