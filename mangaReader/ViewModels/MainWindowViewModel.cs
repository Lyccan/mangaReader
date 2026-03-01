using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using mangaReader.Data;
using mangaReader.ViewModels;
using System;

namespace mangaReader.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {

        [ObservableProperty]
        private object? currentView = null;

        [ObservableProperty]
        private int selectedNavigationIndex = 0;

        private readonly HomeViewModel homeViewModel = new();
        private readonly ReadViewModel readViewModel = new();
        private readonly SettingsViewModel settingsViewModel = new();

        public MainWindowViewModel()
        {
            CurrentView = homeViewModel;      
        }

        [RelayCommand]
        public void NavigateToHome()
        {
            CurrentView = homeViewModel;
            SelectedNavigationIndex = 0;
        }

        [RelayCommand]
        public void NavigateToRead()
        {
            CurrentView = readViewModel;
            SelectedNavigationIndex = 1;
        }

        [RelayCommand]
        public void NavigateToSettings()
        {
            CurrentView = settingsViewModel;
            SelectedNavigationIndex = 2;
        }
    }
}
