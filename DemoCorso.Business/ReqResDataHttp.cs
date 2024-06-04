using DemoCorso.Core.Interfaces;
using System.Net.Http.Json;

namespace DemoCorso.Business;

public class ReqResDataHttp : IReqResData
{
    public async Task<ReqResResponse?> GetDataAsync()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://reqres.in/api/users?page=2&delay=7");

        if (response.IsSuccessStatusCode)
        {
           return await response.Content.ReadFromJsonAsync<ReqResResponse>();
        } else
        {
            return null;
        }
    }
}
