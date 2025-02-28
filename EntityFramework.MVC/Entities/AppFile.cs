namespace EntityFramework.MVC.Entities
{
    public class AppFile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Nome { get; set; } = string.Empty;
    }
}
