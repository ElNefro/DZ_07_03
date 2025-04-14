using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_07_03
{
    public interface ITransport
    {
        static string Type { get; }
        static double RentPrice { get; }
    }
}
