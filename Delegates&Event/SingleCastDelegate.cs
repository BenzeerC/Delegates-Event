using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Event
{
    //declaration delegate
    
        public delegate int MyDelegate(int  x, int y);

        public class Calculation
        {
            public int Add(int a,int b)//Delegate 1
            {
                return a + b;
            }                                                  //Multicast delegate

          public int sub(int  a,int b)//Delegate 2
        {
            return a - b;
        }
        }
        public delegate void Delegate1(int id, string name, double salary);

        public class Test
        {
            public void AcceptDetails(int id,string name, double salary) 
            {
                Console.WriteLine($"{id} {name}  {salary}");
            }
        }
    
}
