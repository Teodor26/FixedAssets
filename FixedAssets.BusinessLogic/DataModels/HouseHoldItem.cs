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
            Name = "Soap";
            Expiration = 30;
        }

        public override void methodList()
        {
            dictionary.Add(new Furniture()
            {

            });
        }
    }
}
