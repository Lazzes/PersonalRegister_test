namespace PersonalRegister_test
{
    public class Program
    {

        static void Main(string[] args)
        {
            Queue<Arbetare> queueArbetare = new Queue<Arbetare>();

            queueArbetare.Enqueue(new Arbetare("Aisha", "Hassan", 99));
            queueArbetare.Enqueue(new Ovrigaarbetare("Laza", "Gabriout", 90));
            queueArbetare.Enqueue(new ArbetsMyror("Oscar", "Wikström", 90));
            queueArbetare.Enqueue(new Arbetare("Alexander", "Nordström", 80));

            foreach (var i in queueArbetare)
            {
                Console.WriteLine(i.getArbetare()); 
            }












            //foreach(Arbetare arbetare in queueArbetare)

        }

    }




    
}
    
