using System.ComponentModel.DataAnnotations;

namespace RssFeedReader.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}