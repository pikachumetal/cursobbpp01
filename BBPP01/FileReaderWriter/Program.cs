using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new Biz.FileReaderWriter();
            var path = @"C:\Users\Pikachu\Desktop\code\cursobbpp01\BBPP01\FileReaderWriter\Files\text.txt";

            Console.Out.WriteLine(string.Format("Opening for write: {0}",path));
            if (!file.OpenFile(path, Biz.FileReaderWriterMode.Write)) {
                Console.Out.WriteLine("Error - closing...");
                return;
            }
        }
    }
}
