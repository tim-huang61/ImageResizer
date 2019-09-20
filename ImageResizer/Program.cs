using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var sourcePath = Path.Combine(Environment.CurrentDirectory, "images");
            var destinationPath = Path.Combine(Environment.CurrentDirectory, "output");

            var imageProcess = new ImageProcess();

            imageProcess.Clean(destinationPath);

            var sw = new Stopwatch();
            sw.Start();
            await imageProcess.ResizeImages(sourcePath, destinationPath, 2.0);
            sw.Stop();

            Console.WriteLine($"花費時間: {sw.ElapsedMilliseconds} ms");
            Console.Read();
        }
    }
}