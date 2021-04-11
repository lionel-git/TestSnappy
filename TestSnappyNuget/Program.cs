using Snappy;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSnappyNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.OpenWrite("mydata.sz");
            var compressor = new SnappyStream(file, CompressionMode.Compress);
            var writer = new StreamWriter(compressor);
            writer.WriteLine("Hello World!");
        }
    }
}
