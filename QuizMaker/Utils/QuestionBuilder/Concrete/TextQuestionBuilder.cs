using QuizMaker.Models;
using QuizMaker.Models.DatabaseEntity;
using QuizMaker.Utils.QuestionBuilder.Abstract;

namespace QuizMaker.Utils.QuestionBuilder.Concrete
{
    /// <summary>
    /// Concrete builder for question without image
    /// </summary>
    class TextQuestionBuilder:IQuestionBuilder
    {
        private int _testId;
        private QuestionModel _questionModel;
        private Questions question;

        public int TestId
        {
            set { _testId = value; }
        }

        public TextQuestionBuilder(QuestionModel questionModel)
        {
            _questionModel = questionModel;
        }

        public void setTestId()
        {
            question.testId = this._testId;
        }

        public void setQuestion()
        {
            question.question = _questionModel.QuestionText;
        }

        public void setVariants()
        {
            foreach (var one in this._questionModel.Variants)
            {
                var variant = new Variants();
                variant.variant = one.VariantText;
                variant.questionId = this._questionModel.QuestionId;
                
                question.Variants.Add(variant);
            }
        }

        public void setAnswer()
        {
            throw new System.NotImplementedException();
        }
    }
}