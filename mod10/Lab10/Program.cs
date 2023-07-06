using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Books books = new Books();
            // Сериализация books

            Stream stream = File.Create("books.xml");
            SoapFormatter serializer = new SoapFormatter(); serializer.Serialize(stream, books);
            stream.Dispose();


            // Десериализация books

        }
    }
}
