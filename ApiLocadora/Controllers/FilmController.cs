using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.Models;
using ApiLocadora.Dtos;
using ApiLocadora.DbContext;

namespace ApiLocadora.Controllers
{
    [Route("/")]
    [ApiController]
    public class FilmController : ControllerBase
    {

        public FilmController() 
        {
        
        }

        [HttpGet("films")]
        public IActionResult Search()
        {
            return Ok(DbContextApi.Films);
        }

        [HttpGet("films/{id}")]
        public IActionResult SearchId(Guid id)
        {
            for (int i = 0; i < DbContextApi.Films.Count; i++)
            {
                if (DbContextApi.Films[i].Id == id)
                {
                    var searchedFilm = new Film(
              DbContextApi.Films[i].Name, DbContextApi.Films[i].ReleaseDate, DbContextApi.Films[i].Director,
              DbContextApi.Films[i].Genre, DbContextApi.Films[i].Studio, DbContextApi.Films[i].Description
              );
                    List<Film> listSearchedFilm = new List<Film>();
                   listSearchedFilm.Add(searchedFilm);
                   return Ok(listSearchedFilm);
                }
            }
            return NotFound();
        }


        [HttpPost("films")]
        public IActionResult Create([FromBody] FilmDto item)
        {
            var newFilm = new Film(
                item.Name, item.ReleaseDate, item.Director,
                item.Genre,item.Studio,item.Description
                );
            DbContextApi.Films.Add(newFilm);
            return Ok(newFilm);
        }

        [HttpPut("films/{id}")]
        public IActionResult Update(Guid id, [FromBody] FilmDto item)
        {
            bool updated = false;
            for(int i=0;i< DbContextApi.Films.Count;i++)
            {
                if(DbContextApi.Films[i].Id==id)
                {
                    DbContextApi.Films[i].Name = item.Name;
                    DbContextApi.Films[i].ReleaseDate = item.ReleaseDate;
                    DbContextApi.Films[i].Director = item.Director;
                    DbContextApi.Films[i].Genre = item.Genre;
                    DbContextApi.Films[i].Studio = item.Studio;
                    DbContextApi.Films[i].Description = item.Description;
                    updated = true;
                }
            }
            if(updated = true) return Ok(DbContextApi.Films);
            else return NotFound();
        }

        [HttpDelete("films/{id}")]

        public IActionResult Delete(Guid id, [FromBody] FilmDto item)
        {
            var newFilm = new Film(
                  item.Name, item.ReleaseDate, item.Director,
                item.Genre, item.Studio, item.Description
                );
            
            for (int i=0; i< DbContextApi.Films.Count;i++)
            {
                if (DbContextApi.Films[i].Id == id)
                {
                    DbContextApi.Films.RemoveAt(i);
                    return Ok(DbContextApi.Films);
                }
            }
            return NotFound();
        }


    }
}
