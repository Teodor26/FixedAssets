using FixedAssets.BusinessLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic
{
    public class ActionAssets
    {

        BaseForAsset[] assets = new BaseForAsset[5];

        public ActionAssets()
        {
            assets[0] = new Computer();
            assets[1] = new Furniture();
            assets[2] = new Officeitems();
            assets[3] = new HouseHoldItem();
        }



    }
}
