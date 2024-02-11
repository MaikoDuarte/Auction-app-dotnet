namespace RocketseatAuction.API.Entities
{
    public class Auction
    {
        private static readonly List<Item> items = new List<Item>();

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        public List<Item> Items { get; set; } = [];
    }
}
