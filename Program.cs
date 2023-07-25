namespace Name
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Is it sunny today?");
            string response = Console.ReadLine();

            if(response == "yes"){
                Yes();  
            } else if(response != "yes"){
                No();
            }
            
        }
        public static void Yes ()
        {
            Console.WriteLine("Great!");
            Console.WriteLine("Warm enough for ice-cream? Y/N ?");
            string response = Console.ReadLine();

            if(response == "y"){
                Console.WriteLine("Nice! Better chase the ice-cream van!");
            } else if(response != "n"){
                Console.WriteLine("No worries, cup of tea then");;
            }
        }
        public static void No ()
        {
            Console.WriteLine("No");
            Console.WriteLine("Cloudy enough for rain? Y/N ?");

            string response = Console.ReadLine();

            if(response == "y"){
                Console.WriteLine("Maybe grab an umbrella!");
            } else if(response != "n"){
                Console.WriteLine("Perfect for a walk");
            
            }
        }
    }    
}