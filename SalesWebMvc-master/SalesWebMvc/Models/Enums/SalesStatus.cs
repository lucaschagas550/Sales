using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.Enums
{
    public enum SalesStatus : int // por ser um tipo enumerado herda de int
    {
        Pending = 0,
        Bilded = 1,
        Canceled = 2
    }
}
