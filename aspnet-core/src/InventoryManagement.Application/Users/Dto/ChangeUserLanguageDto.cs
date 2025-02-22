using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}