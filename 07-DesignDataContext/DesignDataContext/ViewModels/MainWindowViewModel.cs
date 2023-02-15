using Prism.Mvvm;

namespace DesignDataContext.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string example;

        public string Example
        {
            get => example;
            set => SetProperty(ref example, value);
        }

        public MainWindowViewModel()
        {
            Example = "String From ViewModel";
        }
    }
}
