using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister_test
{
    public class ArbetsMyror : Arbetare
    {
        private String fnamn { get; set; }
        private String enamn { get; set; }
        private int jobbid { get; set; }
        

        public String getFullnamn()
        {
            return getFullnamn();
        }

        public ArbetsMyror(String name, String efternamn, int id) : base(name, efternamn, id)
        {
            fnamn = name;
            enamn = efternamn;
            jobbid = id;
           
        }


        public String getName()
        {
            return getName();
        }

     
        public String getEfternamn()
        {
            return getEfternamn();
        }

        
        public int getId()
        {
            return getId();
        }



        //method

 
         public String getDescription()
        {
            return "Myror";
        }

       
        public String getArbetstyp()
        {
            return getArbetstyp();
        }

        
        public String getArbetare()
        {
            return getArbetare();
        }
    }
}
