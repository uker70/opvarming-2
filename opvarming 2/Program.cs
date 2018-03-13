using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opvarming_2
{
    class Program
    {
        static int GetIntFromUser(string spørgsmål)
        {
            Console.Write(spørgsmål);
            string input;
            int resultat;
            input = Console.ReadLine();

            while(! int.TryParse(input, out resultat))
            {
                Console.Write("Fejl, prøv igen");
                input = Console.ReadLine();
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            int tal1, tal2;
            double resultat;



            tal1 = GetIntFromUser("Indtast et heltal: ");
            tal2 = GetIntFromUser("Indats et heltal, foskelligt fra nul: ");

            while (tal2 == 0)
            {
                tal2 = GetIntFromUser("Indtast et heltal, forskelligt fra nul: ");
            }

            resultat = (double)tal1 / (double)tal2;

            Console.WriteLine("Første tal divideret med andet tal er : " + resultat);
            Console.ReadKey();
        }
    }
}
