using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister_test
{
    internal class Lista1
    {
        List<string> Fruits = new List<string>();

        // Adding elements to the Fruits list
        Fruits.Add("Apple");    
        Fruits.Add("Banana");
        Fruits.Add("Mango");     

      // Printing the list
      Fruits.ForEach(System.Console.WriteLine);
    }
}
