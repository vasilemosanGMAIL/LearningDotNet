using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLINQ
{
    internal class Exercise38
    {
        public static int CountListsContainingZeroLongerThan(int length, List<List<int>> listsOfNumbers) =>
                            listsOfNumbers.Count(list => list.Contains(0) && list.Count() > length);
        /*We use the Count method to count the number of lists that meet the following criteria:
        they contain zero, which we check with the Contains method
        they are longer than the given length, which we check with the Count method*/
    }
}
