using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic.DataModels
{
    public class Officeitems : BaseForAsset
    {

        public Officeitems()
        {
            Name = "Office chair";
            Expiration = 365;
        }

        public override void methodList()
        {
            dictionary.Add(new Furniture()
            {

            });
        }
    }
}
