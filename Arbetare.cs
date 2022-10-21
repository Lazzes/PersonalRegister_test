using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister_test
{
    public class Arbetare : Arbetsgivare
    {

        private String name { get; set; }
        private String efternamn { get; set; }
        private int id { get; set; }

        public Arbetare (string name, string efternamn, int id) : base (id)
        {
            this.name = name;
            this.efternamn = efternamn;
            this.id = id;
            
        }


        public String getName()
        {
            return name;
        }
        public String getEfternamn()
        {
            return efternamn;
        }

        // get id
        public int getId()
        {
            return id;
        }


        public static bool isArbetareHasSkor()
        {
            Console.WriteLine("Vill du skkyd Skor , svara 1 för jaa eller 0 för nej Tack!");
            int  input;
            input = Convert.ToInt32(Console.ReadLine ());

         
            if (input == 1)
            {
                Console.WriteLine("Tack ! du har skor nu");
                return true;
            }
            else if (input == 0)
            {
                Console.WriteLine("Tack ! du har  inga skor nu");
                return false;
            }
            else
            {
                Console.WriteLine("Fel inträffat");
            }

            return(false);
        }

        public String getDescription()
        {
            return "is Arbetare ";
        }

        // gett Arbetare information
        public String getArbetare()
        {
            return name = "Arbetaren's Full namn är :  " + getName() + getEfternamn() + "\n" + " ID till användaren är : " + getId() + "\n" + " Arbetaren är typen of : " + getDescription() + isArbetareHasSkor();

        }






    }
}
