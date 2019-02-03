using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic.DataModels
{
    public class Computer:BaseForAsset
    {
        List<Computer> listComputer = new List<Computer>();
       
        
        private DateTime date;

        public Computer()
        {
        }

        public Computer(string name, DateTime date)
        {
            
            listComputer.Add(new Computer() { Name = name, Expiration = date });
            ListItems.AddRange(listComputer);
        }

        public void geItems()
        {
            for (int i = 0; i < ListItems.Count; i++)
            {
                Console.WriteLine("{0} {1}",ListItems[i].Name,ListItems[i].Expiration);
            }
        }
        public override void GetList()
        {
            foreach(var c in listComputer)
            {
                Console.Write("{0} {1}",c.Name,c.Expiration.Month);
            }
        }
    }
}
