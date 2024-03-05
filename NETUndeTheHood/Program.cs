using System.Collections;

namespace NETUndeTheHood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Unde The Hood");

            var variousObjects = new List<object>//behaves like ArrayList
            {//each value type inside List of object of ArrayList must be boxed
                1,
                1.5m,
                new DateTime(2024, 6, 1),
                "hello",
                new Person {Name = "A"}
            };

            foreach (object variousObject in variousObjects)
            {
                Console.WriteLine(variousObject.GetType().Name + ": " + variousObject);
            }

            var numbers1 = new List<int> { 1, 2, 3, 4, 5 };//Here NO boxing is performed, data is stored in array of ints
            var numbers2 = new ArrayList { 1, 2, 3, 4, 5 };//here we have 5 boxing operations

            var numbers3 = new List<IComparable<int>> { 1, 2, 3, 4, 5 };//here we have 5 boxing operations, because IComparable is a reference type

            List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5 };
            object asObject = numbers4;
            /*Correct. Boxing happens when we wrap a value type in a reference type. Here, we assign a List object to a variable of object type,
            * but List is a reference type, so no boxing needs to happen. If "numbers" was, for example, an int, it would have to be boxed.*/

            //Dispose method
            
            const string filePath = "file.txt";
            using (var writer = new FileWriter(filePath))
            {
                writer.Write("some text");
                writer.Write("some other text");
                //writer.Dispose(); no needed with using synthax
            }
            /*Using is a sintactic sugar over: 
             var writer = new FileWriter(filePath);
             try{
                writer.Write("some text");
                writer.Write("some other text");
               }
            finally {
                      writer.Dispose();
                    }
             */


            var reader = new SpecificLineFromTextFileReader(filePath);
            var third = reader.ReadLineNumber(3);
            var fourth = reader.ReadLineNumber(4);
            Console.WriteLine("third line is: " + fourth);
            reader.Dispose();

            const string CSVpath = @"C:\Users\vasile.mosan\Downloads\dummy.csv";
            var data = new CsvReader().Read(CSVpath);



            Console.ReadLine();
        }

    }

    class Person
    {
        public string Name { get; init; }
    }

}
