using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask7._12
{
    public class Drug
    {
        public static int IdCounter;
        public int Id;
        public string Name;
        public TypeDrug Type;
        public int Price;
        public int Count;

        public override string ToString()
        {
            return $"{Id} {Name} {Type} {Price} {Count}";


        }
        public Drug()
        {
            IdCounter++;
            Id = IdCounter;
        }
        
    }
}
