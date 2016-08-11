using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Leave
    {
        public DateTime startingDate { get; set; }
        public int duration { get; set; }
        public string leaveType { get; set; }
        public string employee { get; set; }

        public Leave(DateTime dataInceput, int durata, string motiv, string angajat)
        {
            startingDate = dataInceput;
            duration = durata;
            leaveType = motiv;
            employee = angajat;
        }
    }
}
