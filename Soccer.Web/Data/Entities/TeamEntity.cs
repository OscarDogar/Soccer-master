using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        public string LogoPath { get; set; }

        public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
        ? "https://SoccerWebod.azurewebsites.net//images/noimage.png"
        : $"https://SoccerWebod.azurewebsites.net{LogoPath.Substring(1)}";

        public ICollection<GroupDetailEntity> GroupDetails { get; set; }

        public ICollection<UserEntity> Users { get; set; }

    }
}
