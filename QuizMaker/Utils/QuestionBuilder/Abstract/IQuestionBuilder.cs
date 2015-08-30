namespace QuizMaker.Utils.QuestionBuilder.Abstract
{
    /// <summary>
    /// Abstract builder
    /// </summary>
    interface IQuestionBuilder
    {
        void setTestId();
        void setQuestion();
        void setVariants();
        void setAnswer();
    }
}