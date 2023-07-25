namespace Name
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("type Yes ");
            string response = Console.ReadLine();

            if(response == "yes"){
                PrintLanguage();  
            } else if(response != "yes"){
                PrintNo();
            }
            
        }
        public static void PrintLanguage ()
        {
            Console.WriteLine("Success!");
        }
        public static void PrintNo ()
        {
            Console.WriteLine("No");
        }
    }    
}