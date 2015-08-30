using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuizMaker.Models.Abstract
{
    public interface IQuestionModel
    {
        int QuestionId { set; get; }
        string QuestionText { set; get; }
        ObservableCollection<VariantModel> Variants { set; get; }
        int AnswerId { set; get; }
    }
}