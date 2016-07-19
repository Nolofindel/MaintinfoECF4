using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMaintinfo
{
    [TestClass]
    public class InitDBUnitTests
    {
        public string xmlPath { get; set; }
        public string xsdPath { get; set; }
        public string ConnectionString { get; set; }

        NDbUnit.Core.SqlClient.SqlDbUnitTest _mySqlDatabase;

        public InitDBUnitTests(string connectionString, string xsdPath, string xmlPath)
        {
            _mySqlDatabase = new NDbUnit.Core.SqlClient.SqlDbUnitTest(connectionString);
            this.xsdPath = xsdPath;
            this.xmlPath = xmlPath;
        }

        /// <summary>
        /// l'ordre ReadXmlSchema et ReadXml est important
        /// </summary>
        public void InitilizeDB()
        {
            _mySqlDatabase.ReadXmlSchema(xsdPath);
            _mySqlDatabase.ReadXml(xmlPath);
        }

        /*public void CleanUpDB()
        {
            _mySqlDatabase.PerformDbOperation(NDbUnit.Core.DbOperationFlag.Delete);
        }*/

        public void CleanUpAndInsertDB()
        {
            _mySqlDatabase.PerformDbOperation(NDbUnit.Core.DbOperationFlag.DeleteAll);

            _mySqlDatabase.ReadXmlSchema(xsdPath);
            _mySqlDatabase.ReadXml(xmlPath);
            _mySqlDatabase.PerformDbOperation(NDbUnit.Core.DbOperationFlag.CleanInsertIdentity);

        }

      
    }
}
