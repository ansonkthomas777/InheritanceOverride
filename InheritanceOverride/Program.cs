using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOverride
{
    class Program
    {

        public class CityBaseClass
        {
            public string cityforbaseclass;
           public  CityBaseClass()
            {
                cityforbaseclass = "New Jersey";
            }
            public virtual void Details()
            {

                Console.Write(cityforbaseclass);
            }
        }
        public class CityDerivedClass:CityBaseClass
        {
            string cityforderived;
            public CityDerivedClass()
            {
                cityforderived = "Philadelphia";
            }
            public override void Details()
            {
                Console.Write("Base class city="+cityforbaseclass+"\n ");
                Console.Write("Derived class city="+cityforderived);
            }
        }
        static void Main(string[] args)
        {
            CityDerivedClass c1 = new CityDerivedClass();
            c1.Details();
            Console.ReadLine();
        }
        
    }
}
