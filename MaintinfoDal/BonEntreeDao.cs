using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using System.Data.SqlClient;

namespace MaintinfoDal
{
    class BonEntreeDao
    {
        public static bool EnregistrerBonEntree(BonEntree BonE)
        {
            //using (SqlConnection sqlConnect = DaoProjet.ConnectSQLServ())
            //{
            //    using (SqlCommand sqlCde = new SqlCommand())
            //    {//TODO verifier le conflict
            //        try
            //        {
            //            // Ouvre la connection. 
            //            sqlConnect.Open();
            //            // Création de la commande  
            //            SqlDataReader sqlRdr;
            //            sqlCde.Connection = sqlConnect;
            //            // Constitution Requête SQL  

            //            //sqlCde.CommandText = strSql;
            //            sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
            //            sqlCde.CommandText = "AddPrevision";
            //            //affectation du parametre à la procédure stockée
            //            sqlCde.Parameters.Add(new SqlParameter("@idProjet", System.Data.SqlDbType.Int)).Value = pr.CodeProjet;
            //            sqlCde.Parameters.Add(new SqlParameter("@idQualif", System.Data.SqlDbType.TinyInt)).Value = pr.LaQualif.CodeQualif;
            //            sqlCde.Parameters.Add(new SqlParameter("@nbJours", System.Data.SqlDbType.SmallInt)).Value = pr.NbJours;

            //            //affectation du parametre OUT à la procédure stockée
            //            SqlParameter pOut = new SqlParameter("@idPrevision", System.Data.SqlDbType.Int);
            //            pOut.Direction = System.Data.ParameterDirection.Output;
            //            sqlCde.Parameters.Add(pOut);

            //            // Exécution de la commande  
            //            sqlRdr = sqlCde.ExecuteReader();
            //            sqlRdr.Close();

            //            return true;
            //        }
            //        catch (Exception ex)
            //        {
            //            throw new DaoException("Ajout prévision impossible  : " + ex.Message, ex);
            //        }
            //        finally { sqlConnect.Close(); }
            //    }
            //}
            return true;
        }
    }
}
