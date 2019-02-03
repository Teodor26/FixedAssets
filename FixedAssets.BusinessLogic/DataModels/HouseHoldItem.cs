using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic.DataModels
{
    public class HouseHoldItem : BaseForAsset
    {
        public HouseHoldItem()
        {
        }

        public HouseHoldItem(string Name, int Expiration)
        {
            this.Name = Name;
            this.Expiration = Expiration;
            dictionary.Add(Name, Expiration);
        }
    }
}
