using FixedAssets.BusinessLogic;
using FixedAssets.BusinessLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Hello customer. Choose the next equipment:");
            
                if (int.TryParse(Console.ReadLine(), out int Opt))
                {

                    DateTime date = new DateTime(2018, 7, 2);
                    Computer computer = new Computer("Computer", date);
                    computer.GetList();
                    computer.geItems();                  

                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Try again");
                    Main();
                    Console.Clear();
                }           
            
            Console.Clear();
            Main();
            Console.ReadLine();
        }
    }
}
