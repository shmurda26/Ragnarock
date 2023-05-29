namespace Ragnarock.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }


        public string ImageName { get; set; }
    }
}
