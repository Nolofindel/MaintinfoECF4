using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoBll;
using MaintinfoDalEntity;

namespace MaintinfoBll
{
    class GestionnaireStock
    {
        BonEntreeManager Be;
        BonSortieManager Bs;
        BonDeCommandeManager BdC;
        public GestionnaireStock()
        {
            Be = new BonEntreeManager(new BonEntreeEntityDao());
            Bs = new BonSortieManager(new BonSortieEntityDao());
            BdC = new BonDeCommandeManager(new BonDeCommandeEntityDao());
        }
    }
}
