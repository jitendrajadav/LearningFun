using System;
using System.Linq;
using LearningFun.Interfaces;
using LearningFun.Models;
using Prism;
using System.Collections.ObjectModel;
using Prism.Navigation;
using System.Collections.Generic;

namespace LearningFun.ViewModels
{
    public class StoreViewModel : ViewModelBase, IActiveAware
    {
        private readonly IStoreService _storeService;

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        public event EventHandler IsActiveChanged;

        public ObservableCollection<StoreItemGroup> Groups { get; private set; }

        public StoreViewModel(IStoreService storeService, INavigationService navigationService) : base(navigationService)
        {
            _storeService = storeService;
            Groups = new ObservableCollection<StoreItemGroup>();
        }

        private async void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                if (!Groups.Any())
                {
                    IList<StoreItemGroup> storeGroups = await _storeService.GetItems();

                    foreach (var group in storeGroups)
                    {
                        Groups.Add(group);
                    }
                }
            }
        }
    }
}
