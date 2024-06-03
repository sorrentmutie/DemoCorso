using DemoCorso.Core.Interfaces;

namespace DemoCorso.Business;

public class ManageStaticSalute : ISalute
{
    public string GetSalute()
    {
        return "Buongiorno Blazor!";
    }
}
