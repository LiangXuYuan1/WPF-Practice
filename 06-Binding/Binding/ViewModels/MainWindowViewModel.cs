using Prism.Commands;
using Prism.Mvvm;

namespace Binding.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand TestCommand { get; set; }

        public MainWindowViewModel()
        {
            TestCommand = new DelegateCommand(Test);
        }

        private static void Test()
        {
            System.Diagnostics.Debug.WriteLine("Test");
        }
    }
}
