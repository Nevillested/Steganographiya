using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Steganographiya
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = Image.FromFile(@"путь");
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] b = memoryStream.ToArray();
            Console.WriteLine("Hello World!");
        }
    }
}
