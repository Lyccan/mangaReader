using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using mangaReader.Models.DTOs;
using mangaReader.Data;

namespace mangaReader.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<MangaDTO> mangaList = new();

        public HomeViewModel()
        {
            LoadMangaData();
        }

        private void LoadMangaData()
        {
            MangaList.Clear();
            MangaList.Add(new MangaDTO
            {
                Id = 1,
                Title = "One Piece",
                Author = "Eiichiro Oda",
                Description = "A pirate adventure story about finding the greatest treasure.",
                CoverUrl = "https://via.placeholder.com/150x200",
                ChaptersCount = 1100,
                Rating = 9.2,
                Status = "Ongoing"
            });

            MangaList.Add(new MangaDTO
            {
                Id = 2,
                Title = "Demon Slayer",
                Author = "Koyoharu Gotouge",
                Description = "A young boy becomes a demon slayer to save his sister.",
                CoverUrl = "https://via.placeholder.com/150x200",
                ChaptersCount = 205,
                Rating = 9.0,
                Status = "Completed"
            });
        }
    }
}
