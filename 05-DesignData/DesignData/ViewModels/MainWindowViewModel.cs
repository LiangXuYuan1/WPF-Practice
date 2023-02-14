using Prism.Mvvm;

namespace DesignData.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string data1;

        public string Data1
        {
            get => data1;
            set => SetProperty(ref data1, value);
        }

        private string data2;

        public string Data2
        {
            get => data2;
            set => SetProperty(ref data2, value);
        }

        private string[] items;

        public string[] Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }

        public MainWindowViewModel()
        {
            Data1 = "String1 From MainWindowViewModel";
            Data2 = "String2 From MainWindowViewModel";
            Items = new[] { "Item1", "Item2", "Item3" };
        }
    }
}
