using UdemyCourse.Exercise26;
namespace UdemyCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog("Lucky", "german shepherd", 40);
            Console.WriteLine(dog1.Describe());
            var dog2 = new Dog("Tina", "shar pei", 25);
            Console.WriteLine(dog2.Describe());
            /**********************/

            //upcasting - converting derived class into a base class
            UpcastDowncast upcastDowncast = new UU();
            //downcasting - converting base class into derived class
            //downcasting requires explicit cast
            UU downcasting = (UU)upcastDowncast;

            //Extention method
            var list = new List<int> { 1, 5, 10, 8, 12, 4, 5 };
            var result = list.TakeEverySecond();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }


}
