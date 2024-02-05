namespace Watchlist.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string? Prenom { get; set; }
        public string? nom { get; set; }
        public ICollection<Films>? Films { get; set; }
    }
}
