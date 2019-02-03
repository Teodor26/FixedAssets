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

        public int Expiration { get; set; }

        public Dictionary<string, int> dictionary = new Dictionary<string, int>();
           }
}
