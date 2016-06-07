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
    public class DepanneurDao : GenericDao<Depanneur>
    {
        public DepanneurDao()
        {
            CmdInsert = string.Empty;
            CmdUpdate = string.Empty;
            CmdDelete = string.Empty;
            CmdGetBy = string.Empty;
            CmdGetAll = "RecupererDepanneur";
            CmdGetAllBy = "GetAllGenByFam";

        }

        protected override void ObjectToParameters(Depanneur p, DbCommand oCommand)
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


        protected override Depanneur ReaderToObject(DbDataReader rdr)
        {

            Depanneur dep = new Depanneur
            {
                NomDepanneur = rdr[0] as string
            };
            return dep;

        }

    }
}
