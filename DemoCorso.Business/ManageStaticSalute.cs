using DemoCorso.Core;
using DemoCorso.Core.Interfaces;

namespace DemoCorso.Business;

public class ManageStaticSalute : ISalute
{
    private readonly IClock clock;

    public ManageStaticSalute(IClock clock)
    {
        this.clock = clock;
    }

    public string GetSalute()
    {
        var dateTime = clock.GetNow();
        if(dateTime.Hour < 12) { 
            return "Buongiorno Blazor!";
        } else if(dateTime.Hour >= 12 && dateTime.Hour < 18) {
            return "Buon pomeriggio Blazor!";
        }

        return "Buonasera Blazor!";
    }
}
