using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace BinarySerializationAnalysis
{
    static class Program
    {
        static void Main()
        {

            //create a new Dummy Class
            DummyClass test = new DummyClass();

            //set some properties
            test.someList = new List<int>();
            test.someList.Add(1);
            test.someList.Add(2);
            test.someList.Add(3);
            test.someString = "Some Value";

            //set up a recursive reference
            test.subObject = test;

            //set up our serializer/formatter and analyser
            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            BinarySerializationStreamAnalyzer analyzer = new BinarySerializationStreamAnalyzer();

            using (Stream stream = new MemoryStream())
            {
                //serialize the object to a new memory stream
                formatter.Serialize(stream, test);

                //reset the stream to the start
                stream.Position = 0;

                //analyse the binary serialization stream
                analyzer.Read(stream);
            }

            //output the results to the console
            Console.Write(analyzer.Analyze());
            Console.WriteLine();
            Console.Write("Press any key to exit");
            Console.ReadKey();

        }
    }
}
