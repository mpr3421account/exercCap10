using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercCap10.Entities
{
    internal class Company : TaxPayer
    {
        public Company(string name, double anualIncome, int numberOfEmplyees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmplyees;
        }

        public int NumberOfEmployees { get; set; }

        public override double Tax()
        {
            if(NumberOfEmployees < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
