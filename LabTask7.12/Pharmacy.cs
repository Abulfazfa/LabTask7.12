using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace LabTask7._12
{
    public class Pharmacy
    {
        public static int Id;
        public string Name;
        public Drug[] Drugs = new Drug[0];

        public Pharmacy()
        {
            SetDrug();
            Id++;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
        public void AddDrug(Drug drug)
        {
            
            Array.Resize(ref Drugs, Drugs.Length + 1);
            Drugs[Drugs.Length - 1] = drug;
        }
        public void DrugList()
        {
            foreach (var item in Drugs)
            {
                Console.WriteLine(item.Name);

            }
            
        }
        public void SaleDrug(string drugName, int drugCount, int money)
        {
            
            int sale = 0;
            foreach (var item in Drugs)
            {
                
                if (item.Name == drugName && item.Count >= drugCount && item.Price == money)
                {
                    sale = 1;
                    item.Count -= drugCount;
                }
                 
            }
            if (sale == 1)
            {
                Console.WriteLine("Sale");

            }
            else
            {
                Console.WriteLine("Not Sale");
            }
        }
        public void SetDrug()
        {
            TypeDrug typeDrug1 = new TypeDrug();
              typeDrug1.TypeName = "type1";
            TypeDrug typeDrug2 = new TypeDrug();
              typeDrug2.TypeName = "type2";
            TypeDrug typeDrug3 = new TypeDrug();
              typeDrug3.TypeName = "type3";

            Drug drug1 = new Drug();
              drug1.Name = "A";
              drug1.Count = 2;
              drug1.Price = 21;
              drug1.Type = typeDrug1;
            Drug drug2 = new Drug();
              drug2.Name = "B";
              drug2.Count = 2;
              drug2.Price = 22;
              drug2.Type = typeDrug2;
            Drug drug3 = new Drug();
              drug3.Name = "C";
              drug3.Count = 2;
              drug3.Price = 23;
              drug3.Type = typeDrug3;

            AddDrug(drug1);
            AddDrug(drug2);
            AddDrug(drug3);
            

        }
    }
}
