using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateDapperUI.DTOS.CatagoryDtos;
using RealEstateDapperUI.DTOS.ContactDtos;
using System.Net.Http;

namespace RealEstateDapperUI.ViewComponents.Dashboard
{
    public class _DashboardLastFourContactListComponentPartial(IHttpClientFactory httpClientFactory):ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44364/api/Contact/GetLastFourContactAsync");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
