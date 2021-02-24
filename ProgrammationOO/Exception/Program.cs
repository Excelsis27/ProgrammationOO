using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            TestException();

            Console.WriteLine("Appuyez sur une touche pour continuer");
            Console.ReadKey(true);
        }


        static void TestException()
        {
            int[] tableau = { 1, 2, 25, 47, 125, 190 };
            Console.Write("Entrez un index du tableau: ");

            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Index donné: {0}", index);
                Console.WriteLine("Index {0} du tableau: {1}", index, tableau[index]);
                Console.WriteLine("Division de la valeur par l'index: " + tableau[index] / index);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un exception s'est produite: " + ex.Message);
            }

            Console.WriteLine("L'éxécution continue après le bloc try/catch");
        }


    }
}
