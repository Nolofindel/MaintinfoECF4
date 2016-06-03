using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using MaintinfoDal.Exceptions;
using MaintinfoBo;
using System.Data.SqlClient;

namespace MaintinfoDal
{
    public class BonEntreeDao : GenericDao<BonEntree>
    {
        public BonEntreeDao()
        {
            CmdInsert = "EnregistrerBonEntree";
            CmdUpdate = string.Empty;
            CmdDelete = string.Empty;
            CmdGetBy = string.Empty;
            CmdGetAll = "GetAllProduit";
            CmdGetAllBy = "GetAllGenByFam";

        }
       
        protected override void ObjectToParameters(BonEntree be, DbCommand oCommand)
        {
            // à implémenter lors d'operations Insert, Update 
            // le numero D'entrée n'est pas autoincrémenté : géré dans le code
            oCommand.Parameters.Clear();
            // Parametres DATE_ENTREE
            DbParameter odbP1 = oCommand.CreateParameter();
            odbP1.DbType = System.Data.DbType.DateTime;
            odbP1.Direction = System.Data.ParameterDirection.Input;
            odbP1.ParameterName = "@DateEntree";
            odbP1.Value = be.DateEntree;
            oCommand.Parameters.Add(odbP1);
            // Parametres DESIGNATION_ARTICLE
            DbParameter odbP10 = oCommand.CreateParameter();
            odbP10.DbType = System.Data.DbType.String;
            odbP10.Direction = System.Data.ParameterDirection.Input;
            odbP10.ParameterName = "@ArticleEntree";
            odbP10.Value = be.ArticleEntree;
            oCommand.Parameters.Add(odbP10);
            // Parametre QUANTITE_ENTREE
            DbParameter odbP2 = oCommand.CreateParameter();
            odbP2.DbType = System.Data.DbType.Int32;
            odbP2.Direction = System.Data.ParameterDirection.Input;
            odbP2.ParameterName = "@QuantiteEntree";
            odbP2.Value = be.QuantiteEntree;
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


        protected override BonEntree ReaderToObject(DbDataReader rdr)
        {

            throw new NotImplementedException();

        }


    }
}
