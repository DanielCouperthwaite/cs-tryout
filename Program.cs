using System;

namespace Name
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Is it sunny today? Y/N ?");
            string? response = Console.ReadLine();

            if(response == "y"){
                Yes();  
            } else if(response == "n"){
                No();
            }

            Console.WriteLine("Thanks for playing!");
            
        }
        public static void Yes ()
        {
            Console.WriteLine("Great!");
            Console.WriteLine("Warm enough for ice-cream? Y/N ?");
            string? response = Console.ReadLine();

            if(response == "y"){
                Console.WriteLine("Nice! Better chase the ice-cream van!");
                system.Summary a = new system.Summary("sunny and warm", "eat ice-cream");
                a.PrintWriting();
            } else if(response == "n"){
                Console.WriteLine("No worries, cup of tea then");;
                system.Summary b = new system.Summary("sunny and cold", "drink a cup of tea");
                b.PrintWriting();
            }
        }
        public static void No ()
        {
            Console.WriteLine("No");
            Console.WriteLine("Cloudy enough for rain? Y/N ?");

            string? response = Console.ReadLine();

            if(response == "y"){
                Console.WriteLine("Maybe grab an umbrella!");
                system.Summary c = new system.Summary("cloudy and rainy", "use an umbrella");
                c.PrintWriting();
            } else if(response == "n"){
                Console.WriteLine("Perfect for a walk");
                system.Summary d = new system.Summary("cloudy but dry", "go for a walk");
                d.PrintWriting();
            
            }
        }
    }    
}