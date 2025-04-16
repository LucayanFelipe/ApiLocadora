namespace ApiLocadora.Models
{
    public class Genre
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }


        public Genre()
        {
        }

        public Genre(string name)
        {
            Name = name;
        }
    }
}
