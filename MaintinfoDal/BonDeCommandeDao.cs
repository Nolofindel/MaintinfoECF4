using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MaintinfoDal.Exceptions;
using MaintinfoBo;

namespace MaintinfoDal
{
    public class BonDeCommandeDao : GenericDao<BonDeCommande>
    {

        public BonDeCommandeDao()
        {
            CmdInsert = string.Empty;
            CmdUpdate = string.Empty;
            CmdDelete = string.Empty;
            CmdGetBy = string.Empty;
            CmdGetAll = "GetAllProduit";
            CmdGetAllBy = "GetAllGenByFam";

        }

        protected override void ObjectToParameters(BonDeCommande p, DbCommand oCommand)
        {
            // à implémenter lors d'operations Insert, Update 
            throw new NotImplementedException();
        }
        protected override void IdToParameter(object id, DbCommand oCommand)
        {
            // à implémenter lors d'operations Get ou Delete
            throw new NotImplementedException();
        }

        protected override void FindByPameter(object id, DbCommand oCommand)
        {
            // à implémenter lors d'operations FindAllBy
            throw new NotImplementedException();
        }


        protected override BonDeCommande ReaderToObject(DbDataReader rdr)
        {

            throw new NotImplementedException();

        }
    }
}
