using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_dotnet.Controllers
{
    [Route("api/[controller]")]
    public class DinoController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<DinosModel> Get()
        {
            var dinos = new DinosModel();
            List<DinosModel> DinoList = dinos.DinoListGetter();
            return DinoList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var dinos = new DinosModel();
            List<DinosModel> DinoList = dinos.DinoListGetter();
            return DinoList[id-1];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]int id, string name, string color, string diet)
        {
        var dinos = new DinosModel();
        List<DinosModel> DinoList = dinos.DinoListGetter();
        var newDino = new DinosModel
           {
            Id = id,
            Name = name,
            Color = color,
            Diet = diet
           };
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            var dinos = new DinosModel();
            List<DinosModel> DinoList = dinos.DinoListGetter();   
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
