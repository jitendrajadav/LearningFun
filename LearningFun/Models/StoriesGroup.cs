using System.Collections.Generic;

namespace LearningFun.Models
{
    public class StoriesGroup : List<Stories>
    {
        public string Name { get; private set; }

        public StoriesGroup(string name, List<Stories> stories) : base(stories)
        {
            Name = name;
        }
    }
}
