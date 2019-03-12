using System;
using System.Collections.Generic;
using SilkTest.Ntf;
using Silk.KeywordDriven;
using SilkTest.Ntf.Wpf;

public class Keywords
{
    private readonly Desktop _desktop = Agent.Desktop;

    [Keyword("Start application", IsBaseState = true)]
    public void Start_application(string Argument, bool UseRunDialog)
    {
        BaseState baseState = new BaseState();
        baseState.Execute();
    }

    [Keyword("TestKeyword")]
    public void TestKeyword()
    {
        Agent.SystemFunctions.CreateDirectory("C:\\SILKCENTRAL");
        //
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