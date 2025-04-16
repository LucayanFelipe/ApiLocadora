using ApiLocadora.Dtos;
using ApiLocadora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using ApiLocadora.DbContext;


namespace ApiLocadora.Controllers
{
    [Route("/Genre")]
    [ApiController]
    public class GenreController : ControllerBase
    {

        [HttpGet("")]
        public IActionResult Search()
        {
            return Ok(DbContextApi.Genres);
        }



        [HttpPost("")]
        public IActionResult Create([FromBody] GenreDto item)
        {
            var newGenre = new Genre(item.Name);
            DbContextApi.Genres.Add(newGenre);
            return Ok(newGenre);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] FilmDto item)
        {
            bool updated = false;
            for (int i = 0; i < DbContextApi.Genres.Count; i++)
            {
                if (DbContextApi.Genres[i].Id == id)
                {
                    DbContextApi.Genres[i].Name = item.Name;
                    updated = true;
                }
            }
            if (updated = true) return Ok(DbContextApi.Genres);
            else return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult SearchId(Guid id)
        {
            for (int i = 0; i < DbContextApi.Genres.Count; i++)
            {
                if (DbContextApi.Genres[i].Id == id)
                {
                     var searchedGenre = new Genre(DbContextApi.Genres[i].Name);
                     List<Genre> listSearchedGenre = new List<Genre>();
                     listSearchedGenre.Add(searchedGenre);
                     return Ok(listSearchedGenre);
                }
            }
            return NotFound();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(Guid id, [FromBody] FilmDto item)
        {
            var newGenre = new Genre(item.Name);

            for (int i = 0; i < DbContextApi.Genres.Count; i++)
            {
                if (DbContextApi.Genres[i].Id == id)
                {
                    DbContextApi.Genres.RemoveAt(i);
                    return Ok(DbContextApi.Genres);
                }
            }
            return NotFound();
        }

    }
}
