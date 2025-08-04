namespace GameManagementAPI.Models
{
    public class Game
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}

