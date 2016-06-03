using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using MaintinfoBo;
using MaintinfoDal.Exceptions;
using System.Configuration;

namespace MaintinfoDal
{
    public abstract class GenericDao<T>
    {

        // command Text : requetes ou procedures stockees
        protected string CmdInsert;
        protected string CmdUpdate;
        protected string CmdDelete;
        protected string CmdGetBy;
        protected string CmdGetAll;
        protected string CmdGetAllBy;

        // Imposé  Si une procédure stockée retourne un identifiant ce sera le dernier parametre

        // Affectation des parametres de la proc stockée (Insert, Update) à partir de l'objet
        protected abstract void ObjectToParameters(T obj, DbCommand oCommand);
        // Affectation des propriétés de l'objet (à créer )à partir du reader
        protected abstract T ReaderToObject(DbDataReader rdr);
        // Affectation du parametre de la procédure stockée permettant la lecture par identifiant
        protected abstract void IdToParameter(object id, DbCommand oCommand);

        // Affectation du parametre de la procédure stockée permettant une selection all en base
        protected abstract void FindByPameter(object id, DbCommand oCommand);

        public virtual T GetById(object Id)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = CmdGetBy;
                    oCommand.CommandType = CommandType.StoredProcedure;

                    // affectation du parametre à la procédure stockée
                    IdToParameter(Id, oCommand);

                    T obj = default(T);
                    try
                    {
                        using (DbDataReader rdr = oCommand.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                if (rdr.Read())
                                {
                                    obj = ReaderToObject(rdr);
                                }
                                return obj;
                            }
                            throw new DaoExceptionAfficheMessage("Inexistant");
                        }
                    }
                    catch (DaoException daoex)
                    {
                        throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée: \n" + daoex.Message);
                    }
                    catch (DbException dbe)
                    {
                        // pas de possibilité de switch sur dbException
                        throw new DaoExceptionAfficheMessage("L'opération de lecture n'a pas été réalisée: \n" + dbe.Message);
                    }
                }

            }
        }

        public virtual List<T> GetAll()
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {

                    oCommand.CommandText = CmdGetAll;
                    oCommand.CommandType = CommandType.StoredProcedure;

                    T obj;
                    List<T> liste = new List<T>();

                    try
                    {
                        using (DbDataReader rdr = oCommand.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                obj = ReaderToObject(rdr);
                                liste.Add(obj);
                            }
                            return liste;
                        }
                    }
                    catch (DbException dbe)
                    {
                        // pas de possibilité de switch sur dbException
                        throw new DaoExceptionAfficheMessage("L'opération de lecture n'a pas été réalisée: \n" +
                                                             dbe.Message);
                    }
                }

            }
        }
        // FindAllBy reçoit un objet permettant une selection
        public virtual List<T> FindAllBy(object Id)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {

                    oCommand.CommandText = CmdGetAllBy;
                    oCommand.CommandType = CommandType.StoredProcedure;

                    // affectation du parametre à la procédure stockée
                    FindByPameter(Id, oCommand);

                    T obj;
                    List<T> liste = new List<T>();

                    try
                    {
                        using (DbDataReader rdr = oCommand.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                obj = ReaderToObject(rdr);
                                liste.Add(obj);
                            }
                            return liste;
                        }
                    }
                    catch (DbException dbe)
                    {
                        // pas de possibilité de switch sur dbException
                        throw new DaoExceptionAfficheMessage("L'opération de lecture n'a pas été réalisée: \n" +
                                                             dbe.Message);
                    }
                }

            }
        }
    }
}
