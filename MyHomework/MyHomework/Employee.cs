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
        
        private int SubstractDays(Employee b, Leave a)
        {
            b.availableDaysOff = b.availableDaysOff - a.duration;
            return b.availableDaysOff;
        }

        public void AddNewLeave(Employee b, Leave a)
        {
            b.availableDaysOff = SubstractDays(b, a);
        }

        public void NegativeLeaveDays(Employee b, Leave a)
        {
           
            int d = SubstractDays(b, a);
            if (d < a.duration)
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
        }
    }
}
