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
        public void DisplayInfo()
        {
            Console.WriteLine("Nume: ", lastname);
            Console.WriteLine("Prenume: ", firstname);
            Console.WriteLine("Salariu: ", salary);
            Console.WriteLine("Numar zile disponibile: ", availebleDaysOff);
        }
    }
}
