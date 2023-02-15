using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using Prism.Mvvm;

namespace DesignTimeViewModel.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        // challenge 1: a string

        private string testString;

        public string TestString
        {
            get => testString;
            set => SetProperty(ref testString, value);
        }

        // // challenge 2: a string List
        //
        // private List<string> testStringList;
        //
        // public List<string> TestStringList
        // {
        //     get => testStringList;
        //     set => SetProperty(ref testStringList, value);
        // }
        //
        // // challenge 3: a string ObservableCollection
        //
        // private ObservableCollection<string> testStringObservableCollection;
        //
        // public ObservableCollection<string> TestStringObservableCollection
        // {
        //     get => testStringObservableCollection;
        //     set => SetProperty(ref testStringObservableCollection, value);
        // }

        // challenge 4: a custom class

        // challenge 5: a custom class List

        // challenge 6: a super complex custom class List

        public MainWindowViewModel()
        {
            TestString = "This is a test string from MainWindowViewModel()";
        }
    }
}
