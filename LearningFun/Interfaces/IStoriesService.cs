using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LearningFun.Models;

namespace LearningFun.Interfaces
{
    public interface IStoriesService
    {
        Task<IList<StoriesGroup>> GetStories();
    }
}
