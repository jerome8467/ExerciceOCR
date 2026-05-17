using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompte
{
    class ShowMenu
    {

        public static string Choice(List<string> FullMenu)
        {
            Console.WriteLine();
            foreach (var l in FullMenu)
            {
                Console.WriteLine(l);
            }

            List<string> ShortMenu = new List<string>();

            foreach (var item in FullMenu)
            {
                int end = item.IndexOf(']')-1;
                string shortM = item.Substring(1, end);
                ShortMenu.Add(shortM);
            }

            while (true) {
            Console.Write("Que souhaitez-vous faire ? ");
            string? selection = Console.ReadLine()?.ToUpper();
                if (selection != null && ShortMenu.Contains(selection))
                {
                    Console.WriteLine();
                    return selection;
                }
                else 
                {
                    Console.WriteLine("Erreur : saisie incorrect");
                    Console.WriteLine();
                }

            }

        }



    }

}