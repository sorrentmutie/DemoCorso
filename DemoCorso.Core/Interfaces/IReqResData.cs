namespace DemoCorso.Core.Interfaces;

public interface IReqResData
{
    Task<ReqResResponse?> GetDataAsync();
}
