using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SilkTest.Ntf;
using SilkTest.Ntf.Wpf;

namespace Silk4NETProject1
{
    [SilkTestClass]
    public class UnitTest1
    {
        private readonly Desktop _desktop = Agent.Desktop;

        [TestInitialize]
        public void Initialize()
        {
            BaseState baseState = new BaseState();
            baseState.Execute();
        }

        [TestMethod]
        public void TestMethod1()
        {
            WPFWindow dimensionsCMMicrosoftVisualStudioAdministrator = _desktop.WPFWindow("DimensionsCM - Microsoft Visual Studio  (Administrator)");
            dimensionsCMMicrosoftVisualStudioAdministrator.WPFMenu("Menu_Bar").Select("/_View/Dimensions E_xplorer");
            dimensionsCMMicrosoftVisualStudioAdministrator.Size(1554, 1139);
            dimensionsCMMicrosoftVisualStudioAdministrator.Control("DevExpress XtraBars Controls DockedBarControl").TextClick("Connect...");

            Dialog logInToDimensions = _desktop.Dialog("Log in to Dimensions");
            logInToDimensions.TextField("txtPassword").SetPosition(new TextPosition(0, 0));
            logInToDimensions.TextField("txtPassword").TypePasswordKeys("4U1tDNuSHZfC2w==");
            logInToDimensions.PushButton("btnLogin").Select();
        }
    }
}