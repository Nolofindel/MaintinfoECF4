using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using MaintinfoDal.Exceptions;
using MaintinfoBo;

namespace MaintinfoDal
{
    [Serializable]
    public class ArticleDao : GenericDao<Article>
    {

        public ArticleDao()
        {
            CmdInsert = string.Empty;
            CmdUpdate = "MaJQuantiteArticle";
            CmdDelete = string.Empty;
            CmdGetBy = "RecupererArticle";
            CmdGetAll = string.Empty;
            CmdGetAllBy = "RecupererCatalogueParCategorie";
          

        }

        protected override void ObjectToParameters(Article p, DbCommand oCommand)
        {
            // à implémenter lors d'operations Insert, Update 
            oCommand.Parameters.Clear();
            // Parametres DESIGNATION_ARTICLE
            DbParameter odbP1 = oCommand.CreateParameter();
            odbP1.DbType = System.Data.DbType.String;
            odbP1.Direction = System.Data.ParameterDirection.Input;
            odbP1.ParameterName = "@DesignationArticle";
            odbP1.Value = p.DesignationArticle;
            oCommand.Parameters.Add(odbP1);
            //// Parametres NOM_ARTICLE
            //DbParameter odbP3 = oCommand.CreateParameter();
            //odbP3.DbType = System.Data.DbType.String;
            //odbP3.Direction = System.Data.ParameterDirection.Input;
            //odbP3.ParameterName = "@ArticleEntree";
            //odbP3.Value = p.NomArticle;
            //oCommand.Parameters.Add(odbP3);
            // Parametre QUANTITE_STOCK
            DbParameter odbP4 = oCommand.CreateParameter();
            odbP4.DbType = System.Data.DbType.Int32;
            odbP4.Direction = System.Data.ParameterDirection.Input;
            odbP4.ParameterName = "@Quantite";
            odbP4.Value = p.QuantiteArticle;
            oCommand.Parameters.Add(odbP4);
            //// Parametre SEUIL_MINIMAL
            //DbParameter odbP5 = oCommand.CreateParameter();
            //odbP5.DbType = System.Data.DbType.Int32;
            //odbP5.Direction = System.Data.ParameterDirection.Input;
            //odbP5.ParameterName = "@QuantiteEntree";
            //odbP5.Value = p.SeuilMinimal;
            //oCommand.Parameters.Add(odbP5);
        }
        protected override void IdToParameter(object id, DbCommand oCommand)
        {
            // à implémenter lors d'operations Get ou Delete
            // Parametre Designation Article
            oCommand.Parameters.Clear();
            string DesignationArticle = (string)id;
            DbParameter odbP1 = oCommand.CreateParameter();
            odbP1.DbType = System.Data.DbType.String;
            odbP1.Direction = System.Data.ParameterDirection.Input;
            odbP1.ParameterName = "@DesignationArticle";
            odbP1.Value = DesignationArticle;
            oCommand.Parameters.Add(odbP1);
        }

        protected override void FindByPameter(object id, DbCommand oCommand)
        {
            // à implémenter lors d'operations FindAllBy
            //throw new NotImplementedException();
            oCommand.Parameters.Clear();
            DbParameter odbP1 = oCommand.CreateParameter();
            odbP1.DbType = System.Data.DbType.StringFixedLength;
            odbP1.Direction = System.Data.ParameterDirection.Input;
            odbP1.ParameterName = "@Categorie";
            odbP1.Value = id.ToString();
            oCommand.Parameters.Add(odbP1);
        }


        protected override Article ReaderToObject(DbDataReader rdr)
        {

            Article a = new Article
            {
                DesignationArticle = rdr[0] as string,
                NomArticle = rdr[2] as string,
                QuantiteArticle = rdr.GetInt32(3),
                SeuilMinimal = rdr.GetInt32(4)

            };

            return a;

        }
        
    }
}

