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

        public virtual void methodList() { }

        public static List<BaseForAsset> dictionary = new List<BaseForAsset>();
    }
}
