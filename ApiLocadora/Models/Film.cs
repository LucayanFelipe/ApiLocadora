namespace ApiLocadora.Models
{
    public class Film
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public DateTime ReleaseDate {  get; set; }
        public string Director { get; set; }
        public List <Genre> Genre { get; set; }
        public Studio Studio { get; set; }
        public string Description { get; set; }
        public double AvaliationIMDB { get; set; }




        public Film()
        {
        }

        public Film(string name, DateTime releaseDate, string director, List<Genre> genre, Studio studio, string description)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Director = director;
            Genre = genre;
            Studio = studio;
            Description = description;
        }
    }
}
