using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic.DataModels
{
    public class Computer:BaseForAsset
    {
       
        public Computer() {
            Name = "Computer";
            Expiration = 1000;
            FirstExpiration = Expiration;
        }

        public override void methodList()
        {
            dictionary.Add(new Computer() {
                
            });            
        }

      
    }
}
