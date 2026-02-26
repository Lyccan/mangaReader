using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using mangaReader.Models.DTOs;

namespace mangaReader.ViewModels
{
    public partial class ReadViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<MangaDTO> readMangaList = new();

        public ReadViewModel()
        {
            LoadReadMangaData();
        }

        private void LoadReadMangaData()
        {
            ReadMangaList.Clear();
            ReadMangaList.Add(new MangaDTO
            {
                Id = 3,
                Title = "Attack on Titan",
                Author = "Hajime Isayama",
                Description = "Humanity fights giant humanoid creatures to survive.",
                CoverUrl = "https://via.placeholder.com/150x200",
                ChaptersCount = 139,
                Rating = 9.1,
                Status = "Completed"
            });

            ReadMangaList.Add(new MangaDTO
            {
                Id = 4,
                Title = "My Hero Academia",
                Author = "Kohei Horikoshi",
                Description = "A boy without powers dreams of becoming a hero.",
                CoverUrl = "https://via.placeholder.com/150x200",
                ChaptersCount = 425,
                Rating = 8.9,
                Status = "Ongoing"
            });
        }
    }
}
