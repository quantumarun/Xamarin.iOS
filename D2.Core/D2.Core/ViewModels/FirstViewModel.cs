using MvvmCross.Core.ViewModels;

namespace D2.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
			set { SetProperty (ref _hello, value); RaisePropertyChanged(() => Hello); }
        }
    }
}
