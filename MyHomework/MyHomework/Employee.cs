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

        public Employee(string nume, string prenume, DateTime dataNastere, DateTime dataAngajare, decimal salariu, int DaysOff)
        {
            lastname = nume;
            firstname = prenume;
            dateOfBirth = dataNastere;
            dateOfEmployement = dataAngajare;
            salary = salariu;
            availebleDaysOff = DaysOff;
        }
        public void DisplayInfo(Employee a)
        {
            Console.WriteLine("Nume: ", a.lastname);
            Console.WriteLine("Prenume: ", a.firstname);
            Console.WriteLine("Salariu: ", a.salary);
            Console.WriteLine("Numar zile disponibile: ", a.availebleDaysOff);
        }

        private int SubstractDays()
        {

        }
    }
}
