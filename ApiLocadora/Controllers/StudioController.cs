using ApiLocadora.Dtos;
using ApiLocadora.Models;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.DbContext;

namespace ApiLocadora.Controllers
{
    [Route("/Studio")]
    [ApiController]
    public class StudioController : ControllerBase
    {

        [HttpGet("")]
        public IActionResult Search()
        {
            return Ok(DbContextApi.Studios);
        }

        [HttpGet("{id}")]
        public IActionResult SearchId(Guid id)
        {
            for (int i = 0; i < DbContextApi.Studios.Count; i++)
            {
                if (DbContextApi.Studios[i].Id == id)
                {
                     var searchedStudio = new Studio(DbContextApi.Studios[i].Name, DbContextApi.Studios[i].Distributor);
                     List<Studio> listSearchedStudio = new List<Studio>();
                    listSearchedStudio.Add(searchedStudio);
                    return Ok(listSearchedStudio);
                }
            }
            return NotFound();
        }


        [HttpPost("")]
        public IActionResult Create([FromBody] StudioDto item)
        {
            var newStudio = new Studio(item.Name, item.Distributor);
            DbContextApi.Studios.Add(newStudio);
            return Ok(newStudio);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] StudioDto item)
        {
            bool updated = false;
            for (int i = 0; i < DbContextApi.Studios.Count; i++)
            {
                if (DbContextApi.Studios[i].Id == id)
                {
                    DbContextApi.Studios[i].Name = item.Name;
                    DbContextApi.Studios[i].Name = item.Distributor;
                    updated = true;
                }
            }
            if (updated = true) return Ok(DbContextApi.Studios);
            else return NotFound();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(Guid id, [FromBody] StudioDto item)
        {
            var newStudio = new Studio(item.Name, item.Distributor);

            for (int i = 0; i < DbContextApi.Studios.Count; i++)
            {
                if (DbContextApi.Studios[i].Id == id)
                {
                    DbContextApi.Studios.RemoveAt(i);
                    return Ok(DbContextApi.Studios);
                }
            }
            return NotFound();
        }
    }
}
