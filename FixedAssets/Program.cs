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
            action.Register(ShowMessage);
            Console.WriteLine("Hello customer.");
            bool finish = true;
            while (finish)
            {
                // Console.Clear();
                Console.WriteLine("Opt the next equimpent to purchase:");
                action.ShowName(); //показать список вещей, которые можно приобрести
                if (int.TryParse(Console.ReadLine(), out int Opt))
                {                    
                    if (Opt == 8)                    
                        finish = false;                    
                    else
                    {
                        Console.Clear();
                        action.Choise(Opt);
                    }

                }
                else
                {
                    Console.WriteLine("That is not a number. Try again");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
        
}
