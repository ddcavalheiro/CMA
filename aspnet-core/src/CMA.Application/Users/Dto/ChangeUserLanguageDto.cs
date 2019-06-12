using System.ComponentModel.DataAnnotations;

namespace CMA.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}