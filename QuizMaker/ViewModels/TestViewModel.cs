using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.Windows.Input;
using QuizMaker.Commands;
using QuizMaker.Models;
using QuizMaker.Models.DatabaseEntity;
using QuizMaker.Views;
using QuizMaker.WcfService;

namespace QuizMaker.ViewModels
{
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
        public ICommand RunTestCmd
        {
            get
            {
                if(_runTestCmd == null)
                {
                    _runTestCmd = new RelayCommand(param => RunTest());
                }
                return _runTestCmd;
            }
        }
        /// <summary>
        /// WCF for running test
        /// </summary>
        public void RunTest()
        {
            //TODO: implement WCF server
            ServiceHost sh = new ServiceHost(typeof(Service));
            sh.Open();
        }
    }
}
