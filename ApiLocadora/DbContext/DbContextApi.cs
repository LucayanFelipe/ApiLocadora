using ApiLocadora.Models;

namespace ApiLocadora.DbContext
{
    public static class DbContextApi
    {
        public static List<Genre> Genres { get; set; } = new List<Genre>
        {
              new Genre("ação"),
              new Genre("Aventura"),
              new Genre("Terror"),
        };
            
            
        
        public static List <Studio> Studios { get; set; } = new List<Studio>();
        public static List<Film> Films { get; set; } = new List<Film>();

    }
}
