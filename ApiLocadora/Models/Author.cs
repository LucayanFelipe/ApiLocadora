namespace ApiLocadora.Models
{
    public class Author
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Job{ get; set; }
        public string SocialMedia { get; set; }

        public Author() { }

        public Author(string name, string email, string job, string socialMedia)
        {
            Name = name;
            Email = email;
            Job = job;
            SocialMedia = socialMedia;
        }
    }
}
