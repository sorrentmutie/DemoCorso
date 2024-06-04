using DemoCorso.Core.Interfaces;

namespace DemoCorso.Business;

public class MockReqResData : IReqResData
{
    public Task<ReqResResponse?> GetDataAsync()
    {
        var response = new ReqResResponse
        {
            page = 1,
            per_page = 6,
            total = 12,
            total_pages = 2,
            Data = new User[]
            {
                new User
                {
                    id = 1,
                    Email = "mario@gmail.com",
                    FirstName = "Mario",
                    LastName = "Rossi",
                },
                 new User
                {
                    id = 1,
                    Email = "luigi@gmail.com",
                    FirstName = "Luigi",
                    LastName = "Bianchi",
                }
            }
        };
        return Task.FromResult(response);
    }
}
