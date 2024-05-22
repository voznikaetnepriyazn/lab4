using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Bakery
    {
        public string FlourGrade {  get; set; }
        public decimal Cost { get; set; }
        public Bakery(string flourGrade, decimal cost) 
        { 
            FlourGrade = flourGrade ?? throw new ArgumentNullException(nameof(FlourGrade));
            Cost = cost;
        }
    }
}
