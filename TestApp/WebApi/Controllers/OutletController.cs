using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Service;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletController : Controller
    {
        private readonly IOutletService _outletService;
        public OutletController(IOutletService outletService)
        {
            _outletService = outletService;
        }

        [HttpGet]
        [Route("get-city-list")]
        public List<string> GetCityList(string city, int maxCost, int page)
        {
            try
            {
                var itemList = _outletService.Get(city, page);
                if (itemList != null && itemList.data.Count > 0)
                {
                    var result = itemList.data.Where(m => m.City.ToLower() == city.ToLower() && m.Estimated_Cost <= maxCost).Select(m => m.Name).ToList();
                    if (result != null && result.Count() > 0)
                        return result;
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
