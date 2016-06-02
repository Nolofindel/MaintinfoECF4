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
            CmdGetAllBy = "GetAllGenByFam";

        }

        protected override void ObjectToParameters(Article p, DbCommand oCommand)
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


        protected override Article ReaderToObject(DbDataReader rdr)
        {

            throw new NotImplementedException();

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

