using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LearningFun.Interfaces;
using LearningFun.Models;
using Prism;
using Prism.Navigation;

namespace LearningFun.ViewModels
{
    public class ProfileViewModel : ViewModelBase, IActiveAware
    {
        private readonly IAchievementsService _achievementsService;
        private readonly IFriendsService _friendsService;

        public ObservableCollection<Achievement> Achievements { get; private set; }
        public ObservableCollection<Friend> Friends { get; private set; }

        public ProfileViewModel(
            IAchievementsService achievementsService,
            IFriendsService friendsService, INavigationService navigationService) : base(navigationService)
        {
            _achievementsService = achievementsService;
            _friendsService = friendsService;

            Achievements = new ObservableCollection<Achievement>();
            Friends = new ObservableCollection<Friend>();
        }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        private async void RaiseIsActivatedChanged()
        {
            await RaiseIsActivatedChangedAsync();
        }

        private async Task RaiseIsActivatedChangedAsync()
        {
            if (IsActive)
            {
                if (Achievements.Count == 0)
                {
                    IList<Achievement> achievements = await _achievementsService.GetAchievementsAsync();

                    foreach (Achievement achievement in achievements)
                    {
                        Achievements.Add(achievement);
                    }
                }

                if (Friends.Count == 0)
                {
                    IList<Friend> friends = await _friendsService.GetFriends();
                    
                    foreach (Friend friend in friends)
                    {
                        Friends.Add(friend);
                    }
                }
            }
        }
    }
}
