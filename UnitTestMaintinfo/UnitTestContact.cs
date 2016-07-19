using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.IO;
using System.Xml.Linq;

namespace UnitTestMaintinfo
{
    [TestClass]
    public class UnitTestContact
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
      
        #region "Initialize and CleanUp"

        private static InitDBUnitTests dbSetup;

        private static void InitDbSetup()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BddTest"].ConnectionString;

            string xsdPath = ConfigurationManager.AppSettings["xsdPath"];
            string xmlPath = ConfigurationManager.AppSettings["xmlPath"];

            dbSetup = new InitDBUnitTests(connectionString, xsdPath, xmlPath);
        }

        [AssemblyInitialize]
        public static void Classinit(TestContext context)
        {
            InitDbSetup();
            dbSetup.InitilizeDB();
        }

        [AssemblyCleanup]
        public static void CleanUp()
        {
            dbSetup.CleanUpAndInsertDB();
        }

        #endregion


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\ContactDatas.xml", "Contact", DataAccessMethod.Sequential), DeploymentItem("MyTest.TestUnits\\TestData\\ContactDatas.xml"), TestMethod]
        public void InsertListContact()
        {
            string email = TestContext.DataRow["Email"].ToString();
            string message = TestContext.DataRow["Message"].ToString();
            string category = TestContext.DataRow["Category"].ToString();
            int status = int.Parse(TestContext.DataRow["Status"].ToString());

            Business.Contacts _contact = new Business.Contacts();
            _contact.pEmail = email;
            _contact.pMessage = message;
            _contact.pCategory = category;
            _contact.pStatus = status;
            _contact.pCreatedDate = DateTime.Now;
            _contact.Save();

            int? id = _contact.pId;
            _contact.Load((int)id);

            Assert.IsNotNull(_contact);

        }

        [DeploymentItem(@"TestData\ContactDatas.xml", "TestData")]
        [TestMethod]
        public void TestCallContactDatasXML()
        {
            string filepath = Path.Combine(TestContext.TestDeploymentDir, @"TestData\ContactDatas.xml");

            XDocument document = XDocument.Load(filepath);
        }


    }
}
