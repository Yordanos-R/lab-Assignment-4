using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm
{
    internal class Class1
    {
        public static List<Class1> c = new List<Class1>();
        public static List <String> checkedBox = new List<string>();

        public string objName { get; set; }
        public string fName { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }
        public string dob { get; set; }
        public string dor { get; set; }
        public string phone { get; set; }
       
        
        public void save() 
        {
          
            c.Add(this);
            Console.WriteLine("Saved successfully!");
        }

        public static List<Class1> getall()
        {
            return c;
        }


    }
}
