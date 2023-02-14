using System.Collections.Generic;
using Prism.Mvvm;

namespace DataTemplate.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ExampleClass ExampleClass { get; set; }

        public List<ExampleClass> ExampleClassList { get; set; }

        public MainWindowViewModel()
        {
            ExampleClass = new ExampleClass();
            ExampleClass.ExampleInt = 123;
            ExampleClass.ExampleLong = 123456789;
            ExampleClass.ExampleDouble = 123.456;
            ExampleClass.ExampleBool = true;
            ExampleClass.ExampleString = "Example String";
            ExampleClass.ExampleList = new List<string> { "Example List 1", "Example List 2", "Example List 3" };

            ExampleClassList = new List<ExampleClass>();
            ExampleClassList.Add(new ExampleClass
            {
                ExampleInt = 123, ExampleLong = 123456789, ExampleDouble = 123.456, ExampleBool = true,
                ExampleString = "Example String",
                ExampleList = new List<string> { "Example List 1", "Example List 2", "Example List 3" }
            });
            ExampleClassList.Add(new ExampleClass
            {
                ExampleInt = 456, ExampleLong = 987654321, ExampleDouble = 654.321, ExampleBool = false,
                ExampleString = "Example String 2",
                ExampleList = new List<string> { "Example List 4", "Example List 5", "Example List 6" }
            });
            ExampleClassList.Add(new ExampleClass
            {
                ExampleInt = 789, ExampleLong = 123456789, ExampleDouble = 987.654, ExampleBool = true,
                ExampleString = "Example String 3",
                ExampleList = new List<string> { "Example List 7", "Example List 8", "Example List 9" }
            });
        }
    }

    public class ExampleClass
    {
        public int ExampleInt { get; set; }

        public long ExampleLong { get; set; }

        public double ExampleDouble { get; set; }

        public bool ExampleBool { get; set; }

        public string ExampleString { get; set; }

        public List<string> ExampleList { get; set; }

        public ExampleClass()
        {
            ExampleList = new List<string>();
        }
    }
}