using System.Collections.Generic;
using AdminCore.BusinessLogic.Products.Models;
using AdminCore.BusinessLogic.Products.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdminCore.API.Controllers
{
    [Route("api/[controller]")]
    public class BrandsController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        // GET api/values
        [HttpGet]
        public List<Marcas> Get()
        {
            return _brandService.GetAllBrands();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Marcas marca)
        {
            _brandService.CreateBrand(marca);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
