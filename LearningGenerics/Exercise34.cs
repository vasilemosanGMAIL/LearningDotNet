using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGenerics
{
    internal class Exercise34
    {
        /*In the code, you will see three variables: someMethod1, someMethod2, and someMethod3.
         * Specify their types, so the code compiles. Do not use implicitly-typed variables (var).*/
        public void TestMethod()
        {
            /*your code goes here*/
            Func<int, bool, double> someMethod1 = Method1;
            /*your code goes here*/
            Func<DateTime> someMethod2 = Method2;
            /*your code goes here*/
            Action<string, string> someMethod3 = Method3;
        }

        public double Method1(int a, bool b) => 0;
        public DateTime Method2() => default(DateTime);
        public void Method3(string a, string b) { }
    }
}
