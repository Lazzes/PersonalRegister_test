using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonalRegister_test
{
    public class Ovrigaarbetare: Arbetare
    {
        private String name { get; set; }
        private String enamn { get; set; }
        private int jobbid { get; set; }

        public Ovrigaarbetare (String namn, String efternamn, int id) : base ( namn, efternamn, id)
        {
            name = namn;
            enamn = efternamn;
            jobbid = id;

        }

        public String getNamn()
        {
            return getNamn ();
        }

        public String getEfternamn()
        {
            return getEfternamn();
        }

        public String getFullnamn()
        {
            return getFullnamn();
        }

        public int getId()
            {
                return getId();
            }

        public String getArbetare()
            {
                return getArbetare();
            }


        public String getDescription()
            {
                return "Ovriga";
            }
    }
}
