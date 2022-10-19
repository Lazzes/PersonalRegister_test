namespace PersonalRegister_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bajs");
            Arbetare arbetare = new Arbetare();
            arbetare.getArbetare_id();
            arbetare.getArbetare();
            arbetare.startDatum();
            DateTime data = arbetare.startDatum();
            Console.WriteLine(data);
            Arbetsmyror arbetsmyror = new Arbetsmyror();
            arbetsmyror.getArbetare_id();
            arbetsmyror.getName();
            arbetsmyror.hasSkyddskor();
            Ovrigaarbetare ovrigaarbetare = new Ovrigaarbetare();
            ovrigaarbetare.getArbetare_id();
            ovrigaarbetare.getName();
            ovrigaarbetare.hasSkyddskor();  



        }
    }
}