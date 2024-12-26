using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateDapperUI.DTOS.ToDoListDtos;
using System.Net.Http;

namespace RealEstateDapperUI.Controllers
{
    public class ToDoListController(IHttpClientFactory httpClientFactory) : Controller
    {
    }
}
