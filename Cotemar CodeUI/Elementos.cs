using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace Cotemar_CodeUI
{
    class Elementos
    {
        public IDictionary<string, HtmlControl> ElementDic;

        public Elementos()
        {
            ElementDic = new Dictionary<string, HtmlControl>();
            Menu_Login_Elements();
        }

        private void Menu_Login_Elements()
        {
            ElementDic.Add("uIEmailEdit", UIMap.UICOTEMARInternetExploWindow.UICOTEMARDocument.UIEmailEdit);
            ElementDic.Add("uIPasswordEdit", UIMap.UICOTEMARInternetExploWindow.UICOTEMARDocument.UIPasswordEdit);
            ElementDic.Add("uIEntrarButton", UIMap.UICOTEMARInternetExploWindow.UICOTEMARDocument.UIEntrarPane.UIEntrarButton);
        }

        public Elemento GetDictionayElement<Elemento>(string name) where Elemento : HtmlControl
        {
            return (Elemento) ElementDic[name];
        }

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
