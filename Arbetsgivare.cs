using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister_test
{ 
    public class Arbetsgivare
    {
        private int id { get; set; }    

        public Arbetsgivare(int id)
        {
            this.id = id;
        }   

        public int getId() 
        { 
            return id; 
        }

         public List<string> manageLista()
        { 
            return new List<string> ();
        } 
           
    }
}
