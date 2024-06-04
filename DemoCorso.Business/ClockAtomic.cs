using DemoCorso.Core;

namespace DemoCorso.Business;

public class ClockAtomic : IClock
{
    public DateTime GetNow()
    {
        return new DateTime(2000, 1, 1,19,0,0); 
    }
}

public class SystemClock : IClock
{
    public DateTime GetNow()
    {
        return DateTime.Now;
    }
}
