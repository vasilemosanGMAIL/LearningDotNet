using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser
{
    public interface IUserInteractor
    {
        string ReadValidPath();
        void PrintMessage(string message);
        void PrintError(string message);
    }
}
