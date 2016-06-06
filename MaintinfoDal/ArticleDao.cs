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
            CmdUpdate = string.Empty;
            CmdDelete = string.Empty;
            CmdGetBy = string.Empty;
            CmdGetAll = "GetAllProduit";

            CmdGetAllBy = "RecupererArticle"; 
          

        }

        protected override void ObjectToParameters(Article p, DbCommand oCommand)
        {
            // à implémenter lors d'operations Insert, Update 
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }


        protected override Article ReaderToObject(DbDataReader rdr)
        {

            Article a = new Article
            {
                DesignationArticle = rdr[0] as string,
                NomArticle = rdr[2] as string,
                QuantiteArticle = rdr.GetInt32(3)

            };

            return a;

        }


        public static Article RecupererArticle(string DesignationArticle)
        {
            Article art = new Article();
            return art;
        }
        public static void MaJArticle(Article art)
        {

        }
    }
}

