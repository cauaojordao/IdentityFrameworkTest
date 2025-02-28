using System.ComponentModel.DataAnnotations;

namespace EntityFramework.MVC.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required, MaxLength(80, ErrorMessage = "Nome não pode exceder 80 caracteres.")]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        [Required, MaxLength(120)]
        public string Email { get; set; } = string.Empty;
        public List<AppFile> AppFiles { get; set; } = new List<AppFile>();
        

    }
}
