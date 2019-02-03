using FixedAssets.BusinessLogic;
using FixedAssets.BusinessLogic.DataModels;
using System;

namespace FixedAssets
{
    class Program
    {
        
        static void Main(string[] args)
         {
            ActionAssets action = new ActionAssets();
            Console.WriteLine("Hello customer. Opt the next equimpent to purchase:");
            action.ShowName();
            if (int.TryParse(Console.ReadLine(),out int Opt))
            {
                
                action.Choise(Opt);
                action.GetList();
            }
            else
                Console.WriteLine("That is not a number. Try again");
        }
    }
}
