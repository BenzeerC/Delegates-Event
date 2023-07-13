using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates_Event.SingleCastDelegate;

namespace Delegates_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            MyDelegate myDelegate= new MyDelegate(calculation.Add);// add the ref Add
           
            //add delegate by using (+=) 
            myDelegate += new MyDelegate(calculation.sub);//Add ref Sub

            //Remove delegate by using (-=)
            myDelegate -= new MyDelegate(calculation.sub);
                 

            Delegate[] list = myDelegate.GetInvocationList();
            
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);

                Console.WriteLine(item.DynamicInvoke(45,22));//call methods from invocation list
            }


        }
    }
}
