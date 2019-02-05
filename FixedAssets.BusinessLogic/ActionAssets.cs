using FixedAssets.BusinessLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic
{
    public enum Items
    {
        Computer = 1,
        Furniture,
        Officeitems,
        HouseholdItem
    }
    public enum Methods
    {
        showList = 5,
        showOutofDayList,
        Working
    }

    public class ActionAssets : BaseForAsset
    {
        private const double Percent = 0.3;

        BaseForAsset[] assets = new BaseForAsset[4];

        Dictionary<int, Action> actionList = new Dictionary<int, Action>();

        public delegate void Message(string mes);     

        private Message _mes;

        public void Register(Message mes)
        {
            _mes = mes;
        }        

        public ActionAssets()
        {
            assets[0] = new Computer();
            assets[1] = new Furniture();
            assets[2] = new Officeitems();
            assets[3] = new HouseHoldItem();

            actionList.Add((int)Items.Computer, assets[0].methodList);
            actionList.Add((int)Items.Furniture, assets[1].methodList);
            actionList.Add((int)Items.HouseholdItem, assets[2].methodList);
            actionList.Add((int)Items.Officeitems, assets[3].methodList);
            actionList.Add((int)Methods.showList, ShowList);
            actionList.Add((int)Methods.showOutofDayList, ShowListOutOfDay);
            actionList.Add((int)Methods.Working, Work);
        }

        public void ShowName()
        {
            int j = 1;
            foreach(var c in assets)
            {
                Console.WriteLine("{0}.{1}",j++,c.Name);
            }
            _mes("5.Show the list's equimpemnt which is using now");
            _mes("6.Show the list's equimpemnt which is not using");
            _mes("7.Time to work");
            _mes("8.Log out");
        }

        public void GetList()
        {
            foreach (var c in dictionary)
            {
                Console.WriteLine("{0} {1} days left", c.Name, c.Expiration);
            }
            
        }

        public void Choise(int Opt)
        {
            Random rand = new Random();
            int result = rand.Next(1,5);


              Thread newThread = new Thread(assets[result - 1].methodList);
            newThread.Start();
            //var thread = new Action(assets[result-1].methodList);
            //thread.BeginInvoke(null,null);

            if (actionList.ContainsKey(Opt))
            {
                actionList[Opt]();               
            }
            else
                _mes("That is wrong number. Input correct number");
            
        }
        
        public void ShowList()
        {
            Console.WriteLine("List of purchasing items.");
            Console.WriteLine();
            dictionary = dictionary.OrderBy(x => x.Expiration).ToList();//Сортировка по оставшимся дням
            int j = 1;
            foreach (var c in dictionary)
            {                
                Console.WriteLine("{0}.{1} - {2} days left ",j++, c.Name, c.Expiration);
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void ShowListOutOfDay()
        {
            foreach(var c in outOfDaysList)
            {
                Console.WriteLine("Item {0} - has already expired ", c.Name);
            }
            Console.ReadLine();
        }

        public void Work()
        {
            _mes("Working....................................");
            for (int i = 0; i < dictionary.Count; i++)
            {
                Thread.Sleep(500);
                Random rand = new Random();

                int terminate = rand.Next(0, dictionary[i].FirstExpiration);

                dictionary[i].Expiration = dictionary[i].Expiration - terminate;  
                
                if ((double)dictionary[i].Expiration / dictionary[i].FirstExpiration <= Percent)
                {
                
                    Console.WriteLine($"70 percent of depreciation of {dictionary[i].Name}. You should purchase new {dictionary[i].Name}.");

                    Thread thread = new Thread(dictionary[i].methodList);
                    thread.Start();
                    //var order = new Action(dictionary[i].methodList);
                    //order.BeginInvoke(null,null);//Поставка новой продукции
                }
                if (dictionary[i].Expiration <= 0)
                {
                    outOfDaysList.Add(dictionary[i]);
                    dictionary.Remove(dictionary[i]);
                }
            }
        }
    }
}
