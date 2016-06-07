using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
namespace MaintinfoBll
{
    public interface DepartementFabrication
    {
        void EnvoyerBondeCommande(BonDeCommande BdC);
    }
    public class ImplementationDepartementFabrication : DepartementFabrication
    {
        void DepartementFabrication.EnvoyerBondeCommande(BonDeCommande BdC)
        {

        }
    }
}
