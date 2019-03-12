using SilkTest.Ntf;
using Silk.KeywordDriven;

public class Keywords
{
    [Keyword("TestKeyword")]
    public void TestKeyword()
    {
        Agent.SystemFunctions.CreateDirectory("C:\\SILKCENTRALKDT");
    }
}