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
            CmdInsert = "EnregistrerBonDeCommande";
            CmdUpdate = string.Empty;
            CmdDelete = string.Empty;
            CmdGetBy = string.Empty;
            CmdGetAll = string.Empty;
            CmdGetAllBy = string.Empty;

        }

        protected override void ObjectToParameters(BonDeCommande BdC, DbCommand oCommand)
        {
            // à implémenter lors d'operations Insert, Update 
            oCommand.Parameters.Clear();
            DbParameter odbP1 = oCommand.CreateParameter();
            odbP1.DbType = System.Data.DbType.StringFixedLength;
            odbP1.Direction = System.Data.ParameterDirection.Input;
            odbP1.ParameterName = "@ArticleCommande";
            odbP1.Value = BdC.ArticleCommande.DesignationArticle;
            oCommand.Parameters.Add(odbP1);
            DbParameter odbP10 = oCommand.CreateParameter();
            odbP10.DbType = System.Data.DbType.DateTime;
            odbP10.Direction = System.Data.ParameterDirection.Input;
            odbP10.ParameterName = "@DateCommande";
            odbP10.Value = BdC.DateCommande;
            oCommand.Parameters.Add(odbP10);
            DbParameter odbP2 = oCommand.CreateParameter();
            odbP2.DbType = System.Data.DbType.Int32;
            odbP2.Direction = System.Data.ParameterDirection.Input;
            odbP2.ParameterName = "@QuantiteCommande";
            odbP2.Value = BdC.QuantiteCommande;
            oCommand.Parameters.Add(odbP2);
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
