using HelloWorld;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //Overflow check i.e. when exceed the boundaries of a data type
            checked
            {
                byte number = 255;
                number -= 1;
                Console.WriteLine(number);
            }
            //
            int numba = 46;
            float totalPrice = 20.95f;
            Console.WriteLine(totalPrice);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);//string {0} is replaced by byte.MinValue similarly for {1}
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            Console.WriteLine("/* **********strings ********/");
            string userName = "Vasile", lastName = "Mosan";
            string name = string.Format("{0} {1}", userName, lastName); Console.WriteLine(name);
            // Verbatim Strings
            string path = @"c:\projects\project1\folder1"; Console.WriteLine(path);
            var text = @"Hi John
Look into the following paths
C:\folder1\folder2
C:\folder3\folder4"; Console.WriteLine(text);
            //formating strings
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names); Console.WriteLine(formattedNames);

            Console.WriteLine("/* **********enums ********/");
            //need to cast in order to display enum's value
            var method = ShippingMethod.Express; Console.WriteLine((int)method);
            // will display enum with value = 2 i.e. RegisteredAirMail
            var methodId = 2; Console.WriteLine((ShippingMethod)methodId);
            //will display the enum name not its value i.e Express
            Console.WriteLine(method.ToString());
            //convert enum to string
            var methodName = "Express"; var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

            Console.WriteLine("/* ********** reference types and value types ********/");
            //reference types
            int a = 10; int b = a; b++; Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            Console.WriteLine("/**********Working with Time***********/");
            /* Time span */
            //value types
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);
            //Properties

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine("/**********Working with files***********/");
            Files.WorkWithFiles();
            Files.NumberOfWordsInFile();
            Files.DisplayLongestWordInFile();

            var person = new Person();
            var p = person.Parse("John");
            person.Name = "John";
            person.Introduce("Mosh");

            Console.WriteLine("/**********Working with Access Modifiers ***********/");
            var access = new AccessModifiers(new DateTime(1982, 1, 1));
            Console.WriteLine(access.Age);
            Console.WriteLine(person.Name = "Borea");

            Console.WriteLine("/**********Working with Indexers***********/");
            var indexers = new Indexers();
            indexers["name"] = "Sofia";
            Console.WriteLine(indexers["name"]);

            Console.WriteLine("/**********CLASSES - Exercises***********/");
            var watch = new Stopwatch();
            watch.Start();

            Thread.Sleep(2000);
            watch.Stop();

            Console.WriteLine("/**********INHERITANCE - Exercises***********/");
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();

            Console.WriteLine("/**********POLYMORPHISM - Exercises***********/");
            var OracleConnection = new OracleConnection("test connection");
            OracleConnection.Open();

            Console.WriteLine("/**********INTERFACES - Exercises***********/");

            var engine = new Workflow();
            engine.Add(new Activity1());
            engine.Add(new Activity2());
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(engine);

        }
        // a list of related constants can be put in the enum
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }


    }
}