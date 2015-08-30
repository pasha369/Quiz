using QuizMaker.Models;
using QuizMaker.Utils.QuestionBuilder.Abstract;

namespace QuizMaker.Utils.QuestionBuilder.Concrete
{
    internal class ImageQuestionBuilder : IQuestionBuilder
    {
        private int _testId;
        //TODO: Image questionmodel
        //TODO: image question 

        public int TestId
        {
            set { _testId = value; }
        }

        public ImageQuestionBuilder(QuestionModel questionModel)
        {
            //TODO
        }

        public void setTestId()
        {
            //TODO
        }

        public void setQuestion()
        {
            //TODO
        }

        public void setVariants()
        {
            //TODO
        }

        public void setAnswer()
        {
            //TODO
        }
    }
}