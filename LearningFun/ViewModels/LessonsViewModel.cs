﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using LearningFun.Interfaces;
using LearningFun.Models;
using Prism.Commands;
using Prism.Navigation;

namespace LearningFun.ViewModels
{
    public class LessonsViewModel : ViewModelBase, IInitialize
    {
        private readonly ILessonService _lessonService;

        public ICommand NavigateToTrainingCommand { get; private set; }
        public ObservableCollection<LessonGroup> LessonGroup { get; private set; }

        public LessonsViewModel(ILessonService lessonService)
        {
            _lessonService = lessonService;
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
            LessonGroup = new ObservableCollection<LessonGroup>();
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("O FAB foi selecionado");
        }

        public async void Initialize(INavigationParameters parameters)
        {
            var groups = await GetLessonsGroup();

            foreach (var group in groups)
                LessonGroup.Add(group);
        }

        private async Task<IList<LessonGroup>> GetLessonsGroup()
        {
            return await _lessonService.GetLessonsGroup();
        }
    }
}
