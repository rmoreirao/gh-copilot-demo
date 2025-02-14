namespace albums_api.Models
{
    public record Artist(int Id, string Name)
    {
        public static List<Artist> GetAll()
        {
            var artists = new List<Artist>()
            {
                new Artist(1, "Daprize"),
                new Artist(2, "The Blue-Green Stripes"),
                new Artist(3, "KEDA Club"),
                new Artist(4, "MegaDNS"),
                new Artist(5, "V is for VNET"),
                new Artist(6, "Guns N Probeses")
            };

            return artists;
        }

        public static void Add(Artist artist)
        {
            // Add logic to store the artist
        }
    }
}
