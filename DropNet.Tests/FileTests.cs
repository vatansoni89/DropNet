﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DropNet.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class FileTests
    {
        DropNetClient _client;

        public FileTests()
        {
            //
            // TODO: Add constructor logic here
            //
            _client = new DropNetClient(TestVarables.ApiKey, TestVarables.ApiSecret);
        }

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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Can_Get_File()
        {
            //
            // TODO: Add test logic here
            //
            _client.Login(TestVarables.Email, TestVarables.Password);
            var fileInfo = _client.GetFile("/Getting Started.rtf");

            Assert.IsNotNull(fileInfo);
        }

        [TestMethod]
        public void Can_Delete_File()
        {
            //
            // TODO: Add test logic here
            //
            _client.Login(TestVarables.Email, TestVarables.Password);
            _client.DeleteFile("/Test.txt");
        }

        [TestMethod]
        public void Can_Get_MetaData()
        {
            //
            // TODO: Add test logic here
            //
            _client.Login(TestVarables.Email, TestVarables.Password);
            var metaData = _client.GetMetaData("/Public");

            Assert.IsNotNull(metaData);
            Assert.IsNotNull(metaData.Contents);
        }

    }
}
