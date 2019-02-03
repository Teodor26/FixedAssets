using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic.DataModels
{
    public class Furniture : BaseForAsset
    {
        public Furniture()
        {
        }

        public Furniture(string Name, int Expiration)
        {
            this.Name = Name;
            this.Expiration = Expiration;
            dictionary.Add(Name,Expiration);
        }
    }
}
