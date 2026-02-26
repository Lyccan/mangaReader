namespace mangaReader.Models.DTOs
{
    public class MangaDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CoverUrl { get; set; } = string.Empty;
        public int ChaptersCount { get; set; }
        public double Rating { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
