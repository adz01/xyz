using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee : Person
    {
        DateTime dateOfEmployement { get; set; }
        decimal salary { get; set; }
        int availebleDaysOff { get; set; }
    }
}
