using System.ComponentModel.DataAnnotations;

namespace InnovationSoft.Olh.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}