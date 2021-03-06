﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Cotemar_CodeUI
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {

        public IDictionary<string, HtmlControl> ElementDic;
        Elementos TraerElementos = new Elementos();
        public CodedUITest1()
        {
        }


        public void HacerLogIn()
        {
            var uIEmailEdit = TraerElementos.GetDictionayElement<HtmlEdit>("uIEmailEdit");
            var uIPasswordEdit = TraerElementos.GetDictionayElement<HtmlEdit>("uIPasswordEdit");
            var uIEntrarButton = TraerElementos.GetDictionayElement<HtmlButton>("uIEntrarButton");
            uIEmailEdit.Text = "admin@test.com";
            uIPasswordEdit.Text = "$Test1234";
            Mouse.Click(uIEntrarButton);

        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow IEWindow = BrowserWindow.Launch(new System.Uri("http://cotemaractivos.scio.local/"));
            this.UIMap.IngresarCotemar();
            HacerLogIn();
            /*this.UIMap.IngresarCotemar();
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
            this.UIMap.SalirDeTodo();*/

        }

        #region Additional test attributes

        #endregion

   
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
