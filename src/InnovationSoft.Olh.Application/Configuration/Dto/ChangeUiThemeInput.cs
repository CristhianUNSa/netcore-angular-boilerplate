using System.ComponentModel.DataAnnotations;

namespace InnovationSoft.Olh.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
