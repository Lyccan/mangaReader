using CommunityToolkit.Mvvm.ComponentModel;
using mangaReader.Models;

namespace mangaReader.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        [ObservableProperty]
        private User currentUser = new();

        [ObservableProperty]
        private string newPassword = string.Empty;

        [ObservableProperty]
        private string confirmPassword = string.Empty;

        public SettingsViewModel()
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            CurrentUser.Username = "johndoe";
            CurrentUser.Email = "johndoe@example.com";
            CurrentUser.Password = "••••••••";
        }
    }
}
