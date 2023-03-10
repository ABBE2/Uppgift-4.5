using System;
namespace uppgift4_5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal");
            string heltal = Console.ReadLine();

            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                if (siffra == 9)
                {
                    siffra = 0;
                }
                else
                {
                    siffra = siffra + 1;
                }
                Console.WriteLine(siffra);
            }
        }
    }
}