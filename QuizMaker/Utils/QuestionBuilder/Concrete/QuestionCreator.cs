using QuizMaker.Utils.QuestionBuilder.Abstract;

namespace QuizMaker.Utils.QuestionBuilder.Concrete
{
    /// <summary>
    /// Question creator
    /// </summary>
    class QuestionCreator
    {
        private IQuestionBuilder _questionBuilder;

        public QuestionCreator(IQuestionBuilder questionBuilder)
        {
            _questionBuilder = questionBuilder;
        }

        public void CreateQuestion()
        {
            this._questionBuilder.setTestId();
            this._questionBuilder.setQuestion();
            this._questionBuilder.setVariants();
            this._questionBuilder.setAnswer();
        }
    }
}