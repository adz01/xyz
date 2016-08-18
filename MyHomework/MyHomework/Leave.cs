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
        public class Employee : Person
        {
            DateTime dateOfEmployement { get; set; }
            decimal salary { get; set; }
            int availableDaysOff { get; set; }

            public Employee(string nume, string prenume, DateTime dataNastere, DateTime dataAngajare, decimal salariu, int DaysOff)
            {
                lastname = nume;
                firstname = prenume;
                dateOfBirth = dataNastere;
                dateOfEmployement = dataAngajare;
                salary = salariu;
                availableDaysOff = DaysOff;
            }
            public void DisplayInfo(Employee a)
            {
                Console.WriteLine("Nume: ", a.lastname);
                Console.WriteLine("Prenume: ", a.firstname);
                Console.WriteLine("Salariu: ", a.salary);
                Console.WriteLine("Numar zile disponibile: ", a.availableDaysOff);
            }

            private int SubstractDays(Leave a)
            {
                availableDaysOff = availableDaysOff - a.duration;
                return availableDaysOff;
            }

            public void AddNewLeave(Leave a)
            {
                availableDaysOff = SubstractDays(a);
            }

            public void NegativeLeaveDays(Leave a)
            {

                int d = SubstractDays(a);
                if (d < a.duration)
                    throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
            }
        }

        public Leave(DateTime dataInceput, int durata, string motiv)
        {
            startingDate = dataInceput;
            duration = durata;
            leaveType = motiv;
        }
    }
}
