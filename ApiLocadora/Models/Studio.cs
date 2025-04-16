namespace ApiLocadora.Models
{
    public class Studio
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        public string Distributor { get; set; }

        public Studio(string name, string distributor)
        {
            Name = name;
            Distributor = distributor;
        }
        public Studio() { }
    }
}
