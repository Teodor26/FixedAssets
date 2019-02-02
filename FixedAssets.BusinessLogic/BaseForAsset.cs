using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic
{
    public abstract class BaseForAsset
    {
        public string Name { get; set; }

        public DateTime Expiration { get; set; }
    }
}
