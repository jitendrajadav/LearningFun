using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using LearningFun.Interfaces;
using LearningFun.Models;
using LearningFun.Views;
using Prism.Commands;
using Prism.Navigation;

namespace LearningFun.ViewModels
{
    public class LessonsViewModel : ViewModelBase, IInitialize
    {
        private readonly ILessonService _lessonService;
        public ICommand NavigateToTrainingCommand { get; private set; }
        public ObservableCollection<LessonGroup> LessonGroup { get; private set; }

        public LessonsViewModel(ILessonService lessonService, INavigationService navigationService) : base (navigationService)
        {
            _lessonService = lessonService;
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
            LessonGroup = new ObservableCollection<LessonGroup>();
        }

        private void NavigateToTrainingExecute()
        {
            string dragnDropAchievementPage = $"{nameof(DragnDropAchievement)}?createTab=DragnDropAchievement";
            _ = NavigationService.NavigateAsync(nameof(DragnDropAchievement));
        }

        public async void Initialize(INavigationParameters parameters)
        {
            IList<LessonGroup> groups = await GetLessonsGroup();

            foreach (LessonGroup group in groups)
            {
                LessonGroup.Add(group);
            }
        }

        private async Task<IList<LessonGroup>> GetLessonsGroup()
        {
            return await _lessonService.GetLessonsGroup();
        }
    }
}
