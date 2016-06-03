using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;
using MaintinfoDal.Exceptions;


namespace MaintinfoDal
{
    class Connection
    {
        static public DbConnection GetConnection()
        {
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["MaintInfoConnection"];
            if (oConfig != null)
            {
                DbProviderFactory oFabrique = DbProviderFactories.GetFactory(oConfig.ProviderName);
                DbConnection oConnection = oFabrique.CreateConnection();
                oConnection.ConnectionString = oConfig.ConnectionString;
                try
                {
                    oConnection.Open();
                    return oConnection;
                }
                catch (Exception)
                {
                   throw new DaoExceptionFinAppli("Connexion à la base impossible");
                }
            }
            throw new DaoExceptionFinAppli("Connexion à la base impossible");
        }
    }
}
