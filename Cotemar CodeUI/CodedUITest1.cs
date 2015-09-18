using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Cotemar_CodeUI
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow IEWindow = BrowserWindow.Launch(new System.Uri("http://cotemaractivos.scio.local/"));
            this.UIMap.IngresarCotemar();
            this.UIMap.Assert_PanelDeControl();
            this.UIMap.AbrirSolicitudes();
            this.UIMap.Assert_BandejaDeSolicitudes();
            this.UIMap.AbrirCrearSolicitud();
            this.UIMap.Assert_CrearNuevaSolicitud();
            this.UIMap.ComprobarEstadoBotonAgregar();
            this.UIMap.CrearSolicitudIncremento();
            this.UIMap.ComprobarIncrementoIncrementoDeEquipo();
            this.UIMap.MostrarErrorer();
            this.UIMap.EtiquetadeError1();
            this.UIMap.EtiquetadeError2();
            this.UIMap.EtiquetadeError3();
            this.UIMap.BuscarCom();
            this.UIMap.ComprobrarSeleccionDeEquipo();
            this.UIMap.SalirDeTodo();

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

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
