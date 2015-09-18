using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cotemar_CodeUI
{
    [CodedUITest]
    public class TestLogin
    {
        public TestLogin()
        {
        }

        [TestMethod]

        public void CodeUITestMethod1()
        {
            BrowserWindow IEWindow = BrowserWindow.Launch(new System.Uri("http://cotemaractivos.scio.local/"));
            this.UIMap.IngresarCotemar();
        }

        public TestContext TestContext
        {
            get
            { return testContextInstance; }

            set { testContextInstance = value; }
        }

        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }
                return this.map;
            }
        }

        private UIMap map;
    }
}
