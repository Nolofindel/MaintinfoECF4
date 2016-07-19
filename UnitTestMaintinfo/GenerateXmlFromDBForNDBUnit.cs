using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace UnitTestMaintinfo
{

    [TestClass]
    public class GenerateXmlFromDBForNDBUnit
    {
        InitDBUnitTests dbSetup;

      

        private void InitDbSetup()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BddTest"].ConnectionString;

            string xsdPath = ConfigurationManager.AppSettings["xsdPath"];
            string xmlPath = ConfigurationManager.AppSettings["xmlPath"];
            dbSetup = new InitDBUnitTests(connectionString, xsdPath, xmlPath);
        }

    }
}
