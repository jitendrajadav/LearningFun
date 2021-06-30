using System.Collections.Generic;
using System.Threading.Tasks;
using LearningFun.Models;

namespace LearningFun.Interfaces
{
    public interface IAchievementsService
    {
        Task<IList<Achievement>> GetAchievementsAsync();
    }
}
