using System.Collections.Generic;
using LearningFun.Enums;

namespace LearningFun.Models
{
    public class LessonGroup
    {
        public LessonGroupTypeEnum Type { get; set; }
        public IList<Lesson> Lessons { get; set; }

        public LessonGroup()
        {
            Lessons = new List<Lesson>();
        }
    }
}
