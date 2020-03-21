namespace Soccer.Common.Models
{
    public class TeamResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LogoPath { get; set; }

        public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
        ? "https://SoccerWebod.azurewebsites.net//images/noimage.png"
        : $"https://SoccerWebod.azurewebsites.net{LogoPath.Substring(1)}";
    }
}
