using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Models;
using Quiz.QuizServiceReference;
using QuizMaker.Models;

namespace Quiz.ViewModels
{
    /// <summary>
    /// View model for TestScoreView
    /// </summary>
    class TestScoreViewModel
    {
        private ObservableCollection<ScoreModel> _scores = new ObservableCollection<ScoreModel>();
        public ObservableCollection<ScoreModel> Scores
        {
            get
            {
                return _scores;
            }
        }

        public TestScoreViewModel(Test test, List<QuestionModel> answers)
        {
            var score = CalcResult(answers);

            var client = new TestOperationClient();
            client.PassTest(1, test.Id, score);
        }

        private double CalcResult(List<QuestionModel> questions)
        {
            var client = new TestOperationClient();
            var countCorrect = 0;
            var countWrong = 0;
            int score = 0;

            foreach (var questionItem in questions)
            {
                var answers = client.GetAnswers(questionItem.QuestionId).ToList();
                var variants = questionItem.Variants.Where(v => v.IsCorrect == true).ToList();

                foreach (var variantItem in variants)
                {
                    var variant = answers
                        .FirstOrDefault(v => v.variantId == variantItem.VariantId);
                    if(variant != null)
                    {
                        score++;
                        countCorrect++;
                    }
                    else
                    {
                        countWrong++;
                    }
                }
            }
            _scores.Add(new ScoreModel() { Type = "Correct", Number = countCorrect });
            _scores.Add(new ScoreModel() { Type = "Wrong", Number = countWrong });

            return (questions.Count/100)*countCorrect;
        }
    }
}
