namespace ConsoleAppDesignPattern
{
    internal class program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = Singleton.GetInstance();

            //Singleton s2 = Singleton.GetInstance();

            //if (s1 != s2)
            //{
            //    Console.WriteLine("Not shering the same resource");
            //}
            //else 
            //{
            //    Console.WriteLine("Shering the same resorce");
            //}
            //Console.ReadLine();

            Singleton s1 = Singleton.GetInstance();
            s1.getDatabaseObject().StringSet("persone", "Claverperson");

            Singleton s2 = Singleton.GetInstance();

            Console.WriteLine(s2.getDatabaseObject().StringGet("person"));

            Console.ReadLine();

        }
    }
}