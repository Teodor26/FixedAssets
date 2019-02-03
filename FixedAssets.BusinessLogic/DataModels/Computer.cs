using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic.DataModels
{
    public class Computer:BaseForAsset
    {
        public Computer()
        {
        }

        public Computer(string Name, int Expiration)
        {
            this.Name = Name;
            this.Expiration = Expiration;
            dictionary.Add(Name, Expiration);
        }
    }
}
