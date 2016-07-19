using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMaintinfo
{
    [TestClass]
    public class TestUnitaire
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            //Act

            //Assert
            
        }
        [AssemblyInitialize]
        public static void Classinit(TestContext context)
        {
            InitDbSetup();
            dbSetup.InitilizeDB();
        }
        private static void InitDbSetup()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BddTest"].ConnectionString;

            string xsdPath = ConfigurationManager.AppSettings["xsdPath"];
            string xmlPath = ConfigurationManager.AppSettings["xmlPath"];

            dbSetup = new InitDBUnitTests(connectionString, xsdPath, xmlPath);
        }
    }
}
