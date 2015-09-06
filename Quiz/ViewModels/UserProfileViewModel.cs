using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.QuizServiceReference;
using QuizMaker.Models;

namespace Quiz.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class UserProfileViewModel : ObservableObject
    {
        private ObservableCollection<Test> _passedTests;
        private ObservableCollection<Test> _availableTests;
        private Test _selectedTest;

        public UserProfileViewModel()
        {
            _passedTests = new ObservableCollection<Test>();
            _availableTests = new ObservableCollection<Test>();

            var client = new TestOperationClient();

            foreach (var passedTest in client.GetPassedTests(1))
            {
                _passedTests.Add(passedTest);
            }
            foreach (var availableTest in client.GetAvailableTests(1))
            {
                _availableTests.Add(availableTest);
            }
        }
        public Test SelectedTest
        {
            get { return _selectedTest; }
            set
            {
                _selectedTest = value;
                OnPropertyChanged("SelectedTest");
            }
        }
        public ObservableCollection<Test> PassedTests
        {
            get { return _passedTests; }
            set
            {
                _passedTests = value;
                OnPropertyChanged("PassedTests");
            }
        }

        public ObservableCollection<Test> AvailableTests
        {
            get { return _availableTests; }
            set
            {
                _passedTests = value;
                OnPropertyChanged("AvailableTests");
            }
        }
    }
}
