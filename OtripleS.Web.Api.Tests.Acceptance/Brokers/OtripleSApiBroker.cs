using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;

namespace OtripleS.Web.Api.Tests.Acceptance.Brokers;

public class OtripleSApiBroker
{
    private readonly WebApplicationFactory<Program> _webApplicationFactory;
    private readonly HttpClient _httpClient;
    private readonly IRESTFulApiFactoryClient _apiFactoryClient;

    public OtripleSApiBroker()
    {
        _webApplicationFactory = new WebApplicationFactory<Program>();
        _httpClient = _webApplicationFactory.CreateClient();
        _apiFactoryClient = new RESTFulApiFactoryClient(_httpClient);
    }
}