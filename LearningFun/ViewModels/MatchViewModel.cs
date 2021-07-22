using Prism.Navigation;

namespace LearningFun.ViewModels
{
    public class MatchViewModel : ViewModelBase
    {
        private const string V = "{\"eBooks\":[{\"Id\":1,\"language\":\"Pascal\",\"edition\":\"third\"},{\"Id\":2,\"language\":\"Python\",\"edition\":\"four\"},{\"Id\":3,\"language\":\"SQL\",\"edition\":\"second\"}]}";
        private readonly string Json = V;
       
        public MatchViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
