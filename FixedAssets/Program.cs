using FixedAssets.BusinessLogic;
using FixedAssets.BusinessLogic.DataModels;
using System;

namespace FixedAssets
{
    class Program
    {
        
        static void Main(string[] args)
         {

            Console.WriteLine("Hello customer. Opt the next equimpent to purchase:");
            if(int.TryParse(Console.ReadLine(),out int Opt))
            {
                ActionAssets action = new ActionAssets();
                action.Choise(Opt);
                action.GetList();
            }
            else
                Console.WriteLine("That is not a number. Try again");
        }
    }
}
