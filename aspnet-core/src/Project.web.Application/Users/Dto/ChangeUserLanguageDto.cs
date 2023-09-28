using System.ComponentModel.DataAnnotations;

namespace Project.web.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}