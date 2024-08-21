using System.Formats.Asn1;
using System.Reflection;


namespace Pizza
{
    class Program
    {
       
        static async Task Main(string[] args)
        {
            Console.WriteLine("Write the type of pizza a.Napolion, b.Alecsander, c.Avrham");
            int s = 0;
            string? input = Console.ReadLine();
            while (input != "Napolion" || input != "Alecsander" || input != "Avrham")
            { 
                if (input != "Napolion" && input != "Alecsander" && input != "Avrham")
                {
                    Console.WriteLine("That aoption is not in my list please write anather pizza");
                    input = Console.ReadLine();
                }
                else
                {
                    if (input == "Napolion")
                    {
                        s = 70;
                    }

                    if (input == "Alecsander")
                    {
                        s = 130;
                    }
                    if (input == "Avrham")
                    {
                        s = 190;
                    }
                    for (int i = 1; s > 10;)
                    {
                        s -= 10;

                        Console.WriteLine($" The pizza {input} will be ready in {s} seconds ");
                        await Task.Delay(10000);
                    }
                    Console.WriteLine("The pizza is ready");
                    return;

                }
            
            }

            
        }

    }
}




