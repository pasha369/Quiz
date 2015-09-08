using System.Collections.ObjectModel;
using System.Windows.Input;
using QuizMaker.Models;
using QuizMaker.Models.DatabaseEntity;

namespace QuizMaker.ViewModels
{
    /// <summary>
    /// View model for start page test
    /// </summary>
    class TestViewModel : ObservableObject
    {
        private ObservableCollection<Tests> _tests;

        private ICommand _runTestCmd;

        public ObservableCollection<Tests> AllTests
        {
            get { return _tests; }
            set
            {
                _tests = value;
                OnPropertyChanged("Tests");
            }
        }

        public TestViewModel()
        {
            _tests = new ObservableCollection<Tests>();
            using (var context = new QuizDBEntities())
            {
                foreach (var test in context.Tests)
                {
                    _tests.Add(test);
                }
            }
        }

    }
}
