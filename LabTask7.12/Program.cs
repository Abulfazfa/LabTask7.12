using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LabTask7._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.Name = "Ali";
            pharmacy.SaleDrug("A", 1, 21);
            pharmacy.SaleDrug("A", 1, 21);
            pharmacy.SaleDrug("A", 1, 21);

            pharmacy.SaleDrug("B", 2, 22);
            pharmacy.SaleDrug("B", 1, 22);
            

            pharmacy.SaleDrug("C", 2, 23);
            pharmacy.SaleDrug("C", 1, 23);

            pharmacy.DrugList();
            Console.WriteLine(pharmacy.ToString()); 



        }

    }
  
}
